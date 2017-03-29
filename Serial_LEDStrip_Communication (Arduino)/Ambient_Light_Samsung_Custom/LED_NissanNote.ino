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
#define LED_maxCount6 15

Adafruit_NeoPixel strip1 = Adafruit_NeoPixel(LED_maxCount1, PIN_STRIP1, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip2 = Adafruit_NeoPixel(LED_maxCount2, PIN_STRIP2, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip3 = Adafruit_NeoPixel(LED_maxCount3, PIN_STRIP3, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip4 = Adafruit_NeoPixel(LED_maxCount4, PIN_STRIP4, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip5 = Adafruit_NeoPixel(LED_maxCount5, PIN_STRIP5, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip6 = Adafruit_NeoPixel(LED_maxCount6, PIN_STRIP6, NEO_GRB + NEO_KHZ800);

int relayBATT = 2;
int relayIGN = 4;

const long interval = 30000;
unsigned long previousMillis = 0;

void setup() {
  // put your setup code here, to run once:
  pinMode(PIN_STRIP1, OUTPUT);
  pinMode(PIN_STRIP2, OUTPUT);
  pinMode(PIN_STRIP3, OUTPUT);
  pinMode(PIN_STRIP4, OUTPUT);
  pinMode(PIN_STRIP5, OUTPUT);
  pinMode(PIN_STRIP6, OUTPUT);
  pinMode(relayBATT, OUTPUT);
  pinMode(relayIGN, INPUT);
  
  Serial.begin(115200);
  strip1.begin();
  strip1.setBrightness(200);
  strip2.begin();
  strip2.setBrightness(200);
  strip3.begin();
  strip3.setBrightness(200);
  strip4.begin();
  strip4.setBrightness(200);
  strip5.begin();
  strip5.setBrightness(200);
  strip6.begin();
  strip6.setBrightness(200);

  digitalWrite(relayBATT, LOW);
}

void loop() {
  unsigned long currentMillis = millis();

  //Wiederhole loop() alle 30000 msec (Interval)
  if (currentMillis - previousMillis >= interval) {
    // Speichere letzten Invervalzeitpunkt
    previousMillis = currentMillis;

    // Aktiviere alle Pixel in einer Farbe
    for (uint16_t i = 0; i < strip1.numPixels(); i++)
    {
        strip1.setPixelColor(i, strip1.Color(150, 210, 255));
    }
    strip1.show();
    for (uint16_t i = 0; i < strip2.numPixels(); i++)
    {
        strip2.setPixelColor(i, strip2.Color(150, 210, 255));
    }
    strip2.show();
    for (uint16_t i = 0; i < strip3.numPixels(); i++)
    {
        strip3.setPixelColor(i, strip3.Color(150, 210, 255));
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
  }

  // Ueberwache die Zuendungsspannung.
  if (digitalRead(relayIGN) == LOW) {
    delay(30000);
    // Wenn nach 30 Sek immernoch LOW, dann Spannung von BATT ausschalten
    if (digitalRead(relayIGN) == LOW) {
      digitalWrite(relayBATT, HIGH);
    }
  }
}
