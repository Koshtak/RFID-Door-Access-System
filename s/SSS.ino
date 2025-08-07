
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include "MFRC522.h" // Kütüphane ekleniyor
MFRC522 rfid(10, 9);  // Kütüphane tanımlanıyor
 
String kart = "E3:1D:67:19";
LiquidCrystal_I2C lcd(0x27,16,2); 

 
void setup() {
  lcd.init();
  lcd.backlight();
  Serial.begin(9600);        // Seri Port Ekranı başlatılıyor
  SPI.begin();               // SPI bağlantısı başlatılıyor
  rfid.PCD_Init();
  pinMode(8,OUTPUT);
  pinMode(7,OUTPUT);
  pinMode(6,OUTPUT);           
}
 
void loop() {
  if(rfid.PICC_IsNewCardPresent()) {RFID();} // Kart yaklaştırılana kadar bekle
  delay(100);
  
}
 
void RFID()
{
  rfid.PICC_ReadCardSerial(); // Bağlantı kuruluyor
  
  
  Serial.print("Kart ID: ");
  Serial.println(kartID()); 
  lcd.clear();
  lcd.print("ID= "+kartID());

  if (kart == kartID()) {
    digitalWrite(7,1);
    delay(1000);
     digitalWrite(7,0); // Kart listemizde var
  } else {
    digitalWrite(8,1);
    digitalWrite(6, HIGH);
    delay(1000);
     digitalWrite(8,0);
     digitalWrite(6, LOW);

         // Kartı tanımıyoruz
  }
  rfid.PICC_HaltA(); // Kart ile iletişimi sonlandır
  rfid.PCD_StopCrypto1();
}
 
String kartID() { 
  String metin = "";
  for (int x = 0; x < rfid.uid.size; x++) {
    if(rfid.uid.uidByte[x] < 10) metin += "0";
    metin += String(rfid.uid.uidByte[x], HEX);
    if(x < rfid.uid.size-1) metin += ":";
    metin.toUpperCase();
  }
  return metin;
}