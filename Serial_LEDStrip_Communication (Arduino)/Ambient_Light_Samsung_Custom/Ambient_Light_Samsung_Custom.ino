#include <Adafruit_NeoPixel.h>
#include <LiquidCrystal.h>
#include <LiquidCrystal_I2C.h>
#include <Wire.h>  

#define PIN_STRIP1 2
#define PIN_STRIP2 3
#define PIN_STRIP3 4
#define PIN_STRIP4 5
#define PIN_STRIP5 6
#define PIN_STRIP6 7
#define PIN_STRIP7 8
#define PIN_STRIP8 9
#define PIN_STRIP9 10
#define PIN_STRIP10 11
#define PIN_STRIP11 12
#define PIN_STRIP12 13

#define LED_maxCount 150 // 5 Strips a 30 LED's 

Adafruit_NeoPixel strip1 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP1, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip2 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP2, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip3 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP3, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip4 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP4, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip5 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP5, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip6 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP6, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip7 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP7, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip8 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP8, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip9 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP9, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip10 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP10, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip11 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP11, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip12 = Adafruit_NeoPixel(LED_maxCount, PIN_STRIP12, NEO_GRB + NEO_KHZ800);

// LCD Adresse 0x27 für 16*2 Display setzen
//                    addr, en,rw,rs,d4,d5,d6,d7,bl,blpol
LiquidCrystal_I2C lcd(0x27, 2, 1, 0, 4, 5, 6, 7, 3, POSITIVE);  

String bufferRead = "";

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  
  lcd.begin(16,2);        
  lcd.backlight(); 
  lcd.setCursor(0,0);
  
  strip1.begin();
  strip2.begin();
  strip3.begin();
  strip4.begin();
  strip5.begin();
  strip6.begin();
  strip7.begin();
  strip8.begin();
  strip9.begin();
  strip10.begin();
  strip11.begin();
  strip12.begin();
  strip1.show();
  strip2.show();
  strip3.show();
  strip4.show();
  strip5.show();
  strip6.show();
  strip7.show();
  strip8.show();
  strip9.show();
  strip10.show();
  strip11.show();
  strip12.show();
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0){
    char character = Serial.read();
    bufferRead.concat(character);
    if (character == '\n')
    {
      /*Serial.print("Received: >");
      Serial.print(bufferRead);
      Serial.print("<");*/
      
      lcd.setCursor(0,0);
      lcd.print(bufferRead);

      int idx = bufferRead.substring(0, 3).toInt();
      int redColor = bufferRead.substring(3, 6).toInt();
      int greenColor = bufferRead.substring(6, 9).toInt();
      int blueColor = bufferRead.substring(9, 12).toInt();

      if (redColor > 255 || redColor < 0)
      {
        redColor = 255;
      }
      if (greenColor > 255 || greenColor < 0)
      {
        greenColor = 255;
      }
      if (blueColor > 255 || blueColor < 0)
      {
        blueColor = 255;
      }

      switch (idx)
      {
        case 1:
          for (uint16_t i = 0; i < strip1.numPixels(); i++)
          {
            strip1.setPixelColor(i, strip1.Color(redColor, greenColor, blueColor));
          }
          strip1.show();
          break;
        case 2:
          for (uint16_t i = 0; i < strip2.numPixels(); i++)
          {
            strip2.setPixelColor(i, strip2.Color(redColor, greenColor, blueColor));
          }
          strip2.show();
          break;
        case 3:
          for (uint16_t i = 0; i < strip3.numPixels(); i++)
          {
            strip3.setPixelColor(i, strip3.Color(redColor, greenColor, blueColor));
          }
          strip3.show();
          break;
        case 4:
          for (uint16_t i = 0; i < strip4.numPixels(); i++)
          {
            strip4.setPixelColor(i, strip4.Color(redColor, greenColor, blueColor));
          }
          strip4.show();
          break;
        case 5:
          for (uint16_t i = 0; i < strip5.numPixels(); i++)
          {
            strip5.setPixelColor(i, strip5.Color(redColor, greenColor, blueColor));
          }
          strip5.show();
          break;
        case 6:
          for (uint16_t i = 0; i < strip6.numPixels(); i++)
          {
            strip6.setPixelColor(i, strip6.Color(redColor, greenColor, blueColor));
          }
          strip6.show();
          break;
        case 7:
          for (uint16_t i = 0; i < strip7.numPixels(); i++)
          {
            strip7.setPixelColor(i, strip7.Color(redColor, greenColor, blueColor));
          }
          strip7.show();
          break;
        case 8:
          for (uint16_t i = 0; i < strip8.numPixels(); i++)
          {
            strip8.setPixelColor(i, strip8.Color(redColor, greenColor, blueColor));
          }
          strip8.show();
          break;
        case 9:
          for (uint16_t i = 0; i < strip9.numPixels(); i++)
          {
            strip9.setPixelColor(i, strip9.Color(redColor, greenColor, blueColor));
          }
          strip9.show();
          break;
        case 10:
          for (uint16_t i = 0; i < strip10.numPixels(); i++)
          {
            strip10.setPixelColor(i, strip10.Color(redColor, greenColor, blueColor));
          }
          strip10.show();
          break;
        case 11:
          for (uint16_t i = 0; i < strip11.numPixels(); i++)
          {
            strip11.setPixelColor(i, strip11.Color(redColor, greenColor, blueColor));
          }
          strip11.show();
          break;
        case 12:
          for (uint16_t i = 0; i < strip12.numPixels(); i++)
          {
            strip12.setPixelColor(i, strip12.Color(redColor, greenColor, blueColor));
          }
          strip12.show();
          break;
        default:
          for (uint16_t i = 0; i < strip1.numPixels(); i++)
          {
            strip1.setPixelColor(i, strip1.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip2.numPixels(); i++)
          {
            strip2.setPixelColor(i, strip2.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip3.numPixels(); i++)
          {
            strip4.setPixelColor(i, strip3.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip4.numPixels(); i++)
          {
            strip4.setPixelColor(i, strip4.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip5.numPixels(); i++)
          {
            strip5.setPixelColor(i, strip5.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip6.numPixels(); i++)
          {
            strip6.setPixelColor(i, strip6.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip7.numPixels(); i++)
          {
            strip7.setPixelColor(i, strip7.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip8.numPixels(); i++)
          {
            strip8.setPixelColor(i, strip8.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip9.numPixels(); i++)
          {
            strip9.setPixelColor(i, strip9.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip10.numPixels(); i++)
          {
            strip10.setPixelColor(i, strip10.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip11.numPixels(); i++)
          {
            strip11.setPixelColor(i, strip11.Color(63, 63, 63));
          }
          for (uint16_t i = 0; i < strip12.numPixels(); i++)
          {
            strip12.setPixelColor(i, strip12.Color(63, 63, 63));
          }
          
          strip1.show();
          strip2.show();
          strip3.show();
          strip4.show();
          strip5.show();
          strip6.show();
          strip7.show();
          strip8.show();
          strip9.show();
          strip10.show();
          strip11.show();
          strip12.show();
          break;
      }
      
      bufferRead = "";
    }
  }
}
