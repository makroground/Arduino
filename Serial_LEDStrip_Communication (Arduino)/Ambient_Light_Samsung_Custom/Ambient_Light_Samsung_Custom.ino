#include <Adafruit_NeoPixel.h>
#include <LiquidCrystal.h>
#include <LiquidCrystal_I2C.h>
#include <Wire.h>  

#define PIN_STRIP1 2
#define PIN_STRIP2 3
#define PIN_STRIP3 4
#define PIN_STRIP4 5

Adafruit_NeoPixel strip1 = Adafruit_NeoPixel(11, PIN_STRIP1, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip2 = Adafruit_NeoPixel(18, PIN_STRIP2, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip3 = Adafruit_NeoPixel(11, PIN_STRIP3, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip4 = Adafruit_NeoPixel(14, PIN_STRIP4, NEO_GRB + NEO_KHZ800);

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
  strip1.show();
  strip2.show();
  strip3.show();
  strip4.show();
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
          
          strip1.show();
          strip2.show();
          strip3.show();
          strip4.show();
          break;
      }
      
      bufferRead = "";
    }
  }
}
