#include <Adafruit_NeoPixel.h>

#define PIN_STRIP1 3

#define LED_maxCount 150 // 5x 1m Strips a 30 LED's 

Adafruit_NeoPixel strip1 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP1, NEO_GRB + NEO_KHZ800);

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  strip1.begin();
}

void loop() {
  // put your main code here, to run repeatedly:
  for (uint16_t i = 0; i < strip1.numPixels(); i++)
  {
      strip1.setPixelColor(i, strip1.Color(120, 120, 120));
  }
  strip1.show();
  delay(1000);
}
