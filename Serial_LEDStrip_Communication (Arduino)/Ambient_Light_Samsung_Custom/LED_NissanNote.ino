#include <Adafruit_NeoPixel.h>

#define PIN_STRIP1 3 // Beifahrer
#define PIN_STRIP2 5 // Fahrer
#define PIN_STRIP3 6 // Handschuhfach
#define PIN_STRIP4 9 // Rückbank Fahrer
#define PIN_STRIP5 10 // Rückbank Beifahrer
#define PIN_STRIP6 11 // Kofferraum

#define LED_maxCount1 12 // other: 5x 1m Strips a 30 LED's 
#define LED_maxCount2 6
#define LED_maxCount3 5
#define LED_maxCount4 6
#define LED_maxCount5 6
#define LED_maxCount6 10

Adafruit_NeoPixel strip1 = Adafruit_NeoPixel(LED_maxCount1, PIN_STRIP1, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip2 = Adafruit_NeoPixel(LED_maxCount2, PIN_STRIP2, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip3 = Adafruit_NeoPixel(LED_maxCount3, PIN_STRIP3, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip4 = Adafruit_NeoPixel(LED_maxCount4, PIN_STRIP4, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip5 = Adafruit_NeoPixel(LED_maxCount5, PIN_STRIP5, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip6 = Adafruit_NeoPixel(LED_maxCount6, PIN_STRIP6, NEO_GRB + NEO_KHZ800);

int relayBATT = 2;
int relayIGN = 4;

const long interval1 = 30000;
unsigned long previousMillis1 = 0;
boolean firstRun = true;
const long interval2 = 60000;
unsigned long previousMillis2 = 0;

boolean IGNoff = false;

void setup() {
  // put your setup code here, to run once:
  pinMode(PIN_STRIP1, OUTPUT);
  pinMode(PIN_STRIP2, OUTPUT);
  pinMode(PIN_STRIP3, OUTPUT);
  pinMode(PIN_STRIP4, OUTPUT);
  pinMode(PIN_STRIP5, OUTPUT);
  pinMode(PIN_STRIP6, OUTPUT);
  pinMode(relayBATT, OUTPUT);
  pinMode(relayIGN, INPUT_PULLUP);
  
  Serial.begin(115200);
  strip1.begin();
  strip1.setBrightness(230);
  strip2.begin();
  strip2.setBrightness(230);
  strip3.begin();
  strip3.setBrightness(230);
  strip4.begin();
  strip4.setBrightness(230);
  strip5.begin();
  strip5.setBrightness(230);
  strip6.begin();
  strip6.setBrightness(230);

  digitalWrite(relayBATT, LOW);
}

void loop() {
  unsigned long currentMillis1 = millis();

  //Wiederhole loop() alle 30000 msec (Interval)
  if ((currentMillis1 - previousMillis1 >= interval1) || (firstRun == true)) {
    // Speichere letzten Invervalzeitpunkt
    previousMillis1 = currentMillis1;

    // Aktiviere alle Pixel in einer Farbe
    for (uint16_t i = 0; i < strip1.numPixels(); i++)
    {
        strip1.setPixelColor(i, strip1.Color(255, 80, 0));
    }
    strip1.show();
    for (uint16_t i = 0; i < strip2.numPixels(); i++)
    {
        strip2.setPixelColor(i, strip2.Color(255, 80, 0));
    }
    strip2.show();
    for (uint16_t i = 0; i < strip3.numPixels(); i++)
    {
        strip3.setPixelColor(i, strip3.Color(255, 80, 0));
    }
    strip3.show();
    for (uint16_t i = 0; i < strip4.numPixels(); i++)
    {
        strip4.setPixelColor(i, strip4.Color(150, 210, 255));
    }
    strip4.show();
    for (uint16_t i = 0; i < strip5.numPixels(); i++)
    {
        strip5.setPixelColor(i, strip5.Color(150, 210, 255));
    }
    strip5.show();
    for (uint16_t i = 0; i < strip6.numPixels(); i++)
    {
        strip6.setPixelColor(i, strip6.Color(150, 210, 255));
    }
    strip6.show();

    firstRun = false;
  }

  if (IGNoff == true) {
    unsigned long currentMillis2 = millis();

    if (previousMillis2 == 0) {
      previousMillis2 = currentMillis2;
    }
    
    // Wenn nach 60 Sek immernoch LOW, dann Spannung von BATT ausschalten
    if (currentMillis2 - previousMillis2 >= interval2) {
      digitalWrite(relayBATT, HIGH);
    }
  }

  // Ueberwache die Zuendungsspannung.
  if (digitalRead(relayIGN) == LOW) {
    IGNoff = true;
  } else if (digitalRead(relayIGN) == HIGH) {
    IGNoff = false;
    previousMillis2 = 0;
  }
}
