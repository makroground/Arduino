/*
 * ********************************************************************************************** *
  IOT Projekt - MissBrightLight

  Author: Ricardo Breßler
  Erstellt: 28.11.2016
  Version: 1.80

  Beschreibung:

  Dies ist ein Schulprojekt zur Vernetzung eines Arduino µC mit einer MySQL Datenbank.
  Es wird ein Lux Sensor ausgelesen und mehrere LED-Strips angesteuert, deren Werte online gespeichert werden.

  Weiterführend soll hier die Steuerung von LED Strips über eine dedizierte Webseite ermöglicht werden.
  Der Lux-Sensor entscheidet über eine notwendige Farb- und Helligkeitsanpassung bei Daemmerung.
 * ********************************************************************************************** *
*/

#include <Ethernet.h>
#include <Wire.h>
#include <AS_BH1750.h>
#include <Adafruit_NeoPixel.h>

#define PIN_STRIP1 3 // Beleuchtung 1
#define PIN_STRIP2 5 // Beleuchtung 2
#define LED_maxCount 1 // maximale Anzahl der anzusteuernden LEDs pro Strip

byte mac_addr[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };

//char user[] = ".....................";              // Benutzername
//char password[] = ".....................";        // Benutzerpasswort

EthernetClient client;
//MySQL_Connection conn((Client *)&client);
char host[]    = "85.214.232.234";              // Domain oder IP-Adresse des Servers (fuer die URL)
char url[]     = "/arduino/more/SaveWertToMySQL.php";    // Pfad zur PHP-Datei
char passkey[]     = "FZJV23zjtr78kUHJBV324";   // Kennwort aus PHP-Datei
String result = "";                             // Variable fuer Rueckgabe des Servers
byte server[]  = { 85, 214, 232, 234 };         // IP-Adresse des Servers (zum Verbindungsaufbau)

AS_BH1750 lux_sens; // Lux Sensor definieren
float last_luxVal = 0;
boolean NightMode = false;

Adafruit_NeoPixel strip1 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP1, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip2 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP2, NEO_GRB + NEO_KHZ800);

String strip1_colorS = "255255255";
String strip2_colorS = "255255255";

unsigned long previousMillis = 0;        // will store last time loop triggered

const long interval = 10000;             // loop interval

void setup()
{
  Serial.begin(115200);
  //while (!Serial); // wait for serial port to connect
  Ethernet.begin(mac_addr);
  /*Serial.println("Connecting...");
  if (conn.connect(server_addr, 3306, user, password))
  {
    delay(1000);
  }
  else
  {
    Serial.println("Connection failed.");
  }*/

  // Initialisieren des Lux Sensors
  if (!lux_sens.begin())
  {
    Serial.println("Sensor not present");
  }
  
  // Initialisieren der Strips
  strip1.begin();
  strip2.begin();
  // Vermindern der LED Helligkeit fuer laengere Lebensdauer
  strip1.setBrightness(230);
  strip2.setBrightness(230);
}


void loop()
{
  unsigned long currentMillis = millis();

  if (currentMillis - previousMillis >= interval) {
    // save the last time you blinked the LED
    previousMillis = currentMillis;

    last_luxVal = lux_sens.readLightLevel();
    //Serial.println(last_luxVal);
    
    // Senden der Messwerte an den Server
    WerteSenden();
  
    WerteEmpfangen();
  
    client.stop();
    delay(5);
    client.flush();
  
    // Aktivieren der Nachtschaltung
    isLowLight();
  
    // Auswerten und Setzen der LED Strip Farben
    setLEDLights();
  
    Serial.println();  
  }
}

void WerteSenden()
{
  if (client.connect(server, 80)) // Verbindung zum Server aufbauen
  {    
    /*Serial.print("GET " + String(url));
    Serial.print("?bh1750fvi_1=");
    Serial.print(String((int) last_luxVal));
    Serial.print("&pkey=" + String(passkey));
    Serial.println(" HTTP/1.1");
    Serial.print("Host: " + String(host));
    Serial.println();
    Serial.println("User-Agent: Arduino");
    Serial.println("Connection: close");
    Serial.println();*/
    
    client.print("GET " + String(url));
    client.print("?bh1750fvi_1=");
    client.print(String((int) last_luxVal));
    client.print("&pkey=" + String(passkey));
    client.println(" HTTP/1.1");
    client.print("Host: " + String(host));
    client.println();
    client.println("User-Agent: Arduino");
    client.println("Connection: close");
    client.println();

    Serial.println("Werte erfolgreich an den Server gesendet.");
  }
  else
  {
    Serial.println("!!! Werte konnten nicht gesendet werden !!!");
  }
}

void WerteEmpfangen()
{
  byte maxReads = 10; //Seconds
  while ((maxReads-- > 0) && client.connected())    // Antwort des Servers lesen
  {
    delay(1000);
    while (client.available())
    {
      result += String((char)client.read());

      // Entferne den HTTP Header
      if (result.endsWith("Content-Length: 59")) // charset=UTF-8
      {
        result = "";
      }
    }
    // Entferne Zeilenumbrüche und Leerzeichen, sowie den HTTP Request
    // am Anfang des result Strings
    result = result.substring(4);
    //Serial.println(result.substring(0, 9));
    //Serial.println(result.substring(9, 18));
    strip1_colorS = result.substring(0, 9);
    strip2_colorS = result.substring(9, 18);
    Serial.println(result.substring(18));
    result = "";
  }
}

boolean isLowLight()
{
  // Auswerten des Lux Wertes
  if (last_luxVal >= 50.00)
  {
    // Tageshelligkeit
    NightMode = false;
    return false;
  }
  else if (last_luxVal < 50.00)
  {
    // Daemmerung bis Nacht
    NightMode = true;
    return true;
  }
  else
  {
    return false;
  }
}

void setLEDLights()
{
  if (NightMode)
  {
    // Nachtschaltung
    strip1.setBrightness(100);
    strip2.setBrightness(100);
    Serial.println("Nachtmodus aktiv");
  }
  else
  {
    // Tagschaltung
    strip1.setBrightness(230);
    strip2.setBrightness(230);
  }

  // Setze Strip1
  int r1 = validColor(strip1_colorS.substring(0, 3).toInt());
  int g1 = validColor(strip1_colorS.substring(3, 6).toInt());
  int b1 = validColor(strip1_colorS.substring(6, 9).toInt());
  if (NightMode)
  {
    // Reduzieren des Blauanteils in der Nachtschaltung
    if (b1 >= 50)
    {
      b1 -= 50;
    }
  }
  strip1.setPixelColor(0, strip1.Color(r1, g1, b1));

  //Setze Strip2
  int r2 = validColor(strip2_colorS.substring(0, 3).toInt());
  int g2 = validColor(strip2_colorS.substring(3, 6).toInt());
  int b2 = validColor(strip2_colorS.substring(6, 9).toInt());
  if (NightMode)
  {
    // Reduzieren des Blauanteils in der Nachtschaltung
    if (b2 >= 50)
    {
      b2 -= 50;
    }
  }
  strip2.setPixelColor(0, strip2.Color(r2, g2, b2));
  
  // Anzeigen der gesetzten Farben
  strip1.show();
  strip2.show();

  Serial.println("Farben der Strips gesetzt.");
}

// Ueberpruefen des Farbwertes
// Gegebenfalls berichtigen des Wertes (min. 0 && max. 255)
int validColor(int color)
{
  if (color > 255)
  {
    color = 255;
  }
  else if (color < 0)
  {
    color = 0;
  }
  return color;
}
