#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include "MFRC522.h"

MFRC522 rfid(10, 9);  // SS_PIN, RST_PIN
LiquidCrystal_I2C lcd(0x27, 16, 2); 

// LED and buzzer pins
#define GREEN_LED 7
#define RED_LED 8
#define BUZZER 6

void setup() {
  lcd.init();
  lcd.backlight();
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();
  
  pinMode(GREEN_LED, OUTPUT);
  pinMode(RED_LED, OUTPUT);
  pinMode(BUZZER, OUTPUT);
  
  lcd.print("RFID System Ready");
  delay(1000);
  lcd.clear();
}

void loop() {
  if (rfid.PICC_IsNewCardPresent() && rfid.PICC_ReadCardSerial()) {
    String uid = getFormattedUID();
    Serial.println(uid); // Send to C#
    
    // Wait for response
    String response = waitForResponse();
    
    updateDisplay(uid, response);
    controlAccess(response);
    
    rfid.PICC_HaltA();
    rfid.PCD_StopCrypto1();
  }
  delay(100);
}

String getFormattedUID() {
  String uid = "";
  for (byte i = 0; i < rfid.uid.size; i++) {
    if(rfid.uid.uidByte[i] < 0x10) uid += "0";
    uid += String(rfid.uid.uidByte[i], HEX);
    if(i < rfid.uid.size-1) uid += ":";
  }
  uid.toUpperCase();
  return uid;
}

String waitForResponse() {
  unsigned long startTime = millis();
  while(!Serial.available() && millis() - startTime < 3000) {
    delay(10);
  }
  if(Serial.available()) {
    return Serial.readStringUntil('\n');
  }
  return "TIMEOUT";
}

void updateDisplay(String uid, String response) {
  lcd.clear();
  lcd.print("ID: " + uid.substring(0, 15));
  lcd.setCursor(0, 1);
  if(response.startsWith("ACCESS_GRANTED")) {
    lcd.print("Access Granted");
  } else {
    lcd.print("Access Denied");
  }
}

void controlAccess(String response) {
  if(response.startsWith("ACCESS_GRANTED")) {
    digitalWrite(GREEN_LED, HIGH);
    delay(1000);
    digitalWrite(GREEN_LED, LOW);
  } else {
    digitalWrite(RED_LED, HIGH);
    digitalWrite(BUZZER, HIGH);
    delay(1000);
    digitalWrite(RED_LED, LOW);
    digitalWrite(BUZZER, LOW);
  }
}