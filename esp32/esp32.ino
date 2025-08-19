#include <WiFi.h>
#include <HTTPClient.h>
#include <SPI.h>
#include <MFRC522.h>
#include <ArduinoJson.h>

// ---------- CONFIG ----------
const char* WIFI_SSID     = "YOUR_WIFI_SSID";
const char* WIFI_PASSWORD = "YOUR_WIFI_PASSWORD";

// API (PC’nin IP’sini ve portunu doğru yaz)
String API_BASE = "http://10.0.13.159:7071/api/Cards";

// RC522 pins
#define RC522_SS_PIN   5
#define RC522_RST_PIN  27

// LEDs
#define GREEN_LED 16
#define RED_LED   17

MFRC522 rfid(RC522_SS_PIN, RC522_RST_PIN);

// ---------- HELPERS ----------
String toHexUid(const MFRC522::Uid& uid) {
  char buf[3 * 10] = {0};
  char* p = buf;
  for (byte i = 0; i < uid.size; i++) {
    if (i > 0) *p++ = ':';
    sprintf(p, "%02X", uid.uidByte[i]);
    p += 2;
  }
  return String(buf);
}

bool checkAuthorized(const String& uid) {
  if (WiFi.status() != WL_CONNECTED) return false;

  String url = API_BASE + "/check/" + uid;
  HTTPClient http;
  http.begin(url);
  int code = http.GET();
  if (code != 200) {
    Serial.printf("HTTP GET failed, code=%d\n", code);
    http.end();
    return false;
  }
  String payload = http.getString();
  http.end();

  StaticJsonDocument<64> doc;
  if (deserializeJson(doc, payload)) {
    Serial.println("JSON parse error");
    return false;
  }
  return doc["authorized"] | false;
}

// ---------- SETUP ----------
void setup() {
  Serial.begin(115200);

  pinMode(GREEN_LED, OUTPUT);
  pinMode(RED_LED, OUTPUT);
  digitalWrite(GREEN_LED, LOW);
  digitalWrite(RED_LED, LOW);

  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  Serial.print("Connecting WiFi");
  while (WiFi.status() != WL_CONNECTED) {
    delay(300); Serial.print(".");
  }
  Serial.println("\nWiFi connected!");

  SPI.begin();
  rfid.PCD_Init();
  Serial.println("RFID Ready");
}

// ---------- LOOP ----------
void loop() {
  if (!rfid.PICC_IsNewCardPresent() || !rfid.PICC_ReadCardSerial()) return;

  String uid = toHexUid(rfid.uid);
  Serial.print("UID: "); Serial.println(uid);

  bool ok = checkAuthorized(uid);
  if (ok) {
    Serial.println("Access GRANTED");
    digitalWrite(GREEN_LED, HIGH);
    delay(1000);
    digitalWrite(GREEN_LED, LOW);
  } else {
    Serial.println("Access DENIED");
    digitalWrite(RED_LED, HIGH);
    delay(1000);
    digitalWrite(RED_LED, LOW);
  }

  rfid.PICC_HaltA();
  rfid.PCD_StopCrypto1();
  delay(500);
}
