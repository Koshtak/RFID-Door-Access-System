/*
  ESP32 + RC522 + I2C LCD + LEDs/Buzzer
  Calls: GET http://<PC_IP>:7071/api/Cards/check/{UID}
  Expects: {"authorized": true/false}
*/

#include <WiFi.h>
#include <HTTPClient.h>
#include <SPI.h>
#include <MFRC522.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <ArduinoJson.h>

// ---------- CONFIG ----------
const char* WIFI_SSID     = "eduroam";
const char* WIFI_PASSWORD = "123321Aa";

// Use your PC's LAN IP and API port from launchSettings.json
String API_BASE = "http://10.0.14.200:7071/api/Cards";

// RC522 pins (ESP32 VSPI default: SCK=18, MISO=19, MOSI=23)
#define RC522_SS_PIN   21
#define RC522_RST_PIN  22

// I2C LCD


// Outputs
#define GREEN_LED 13
#define RED_LED   14

// Objects
MFRC522 rfid(RC522_SS_PIN, RC522_RST_PIN);

// ---------- HELPERS ----------
String toHexUid(const MFRC522::Uid& uid) {
  // Format: "XX:YY:ZZ:AA"
  char buf[3 * 10] = {0}; // supports up to 10-byte UID safely
  char* p = buf;
  for (byte i = 0; i < uid.size; i++) {
    if (i > 0) *p++ = ':';
    byte b = uid.uidByte[i];
    byte hi = (b >> 4) & 0x0F;
    byte lo = b & 0x0F;
    *p++ = hi < 10 ? ('0' + hi) : ('A' + (hi - 10));
    *p++ = lo < 10 ? ('0' + lo) : ('A' + (lo - 10));
  }
  return String(buf);
}

String urlEncodeColons(const String& s) {
  // Replace ":" with "%3A" for safe URL
  String out;
  out.reserve(s.length() + 6);
  for (size_t i = 0; i < s.length(); i++) {
    if (s[i] == ':') out += "%3A";
    else out += s[i];
  }
  return out;
}



void grantAccess() {
  digitalWrite(GREEN_LED, HIGH);
  delay(1000);
  digitalWrite(GREEN_LED, LOW);
}

void denyAccess() {
  digitalWrite(RED_LED, HIGH);
 
  delay(1000);
  digitalWrite(RED_LED, LOW);
}

bool checkAuthorized(const String& uid) {
  if (WiFi.status() != WL_CONNECTED) return false;

  String encoded = urlEncodeColons(uid);
  String url = API_BASE + "/check/" + encoded;

  HTTPClient http;
  http.setConnectTimeout(3000);  // 3s
  http.setTimeout(3000);         // 3s
  http.begin(url);

  int code = http.GET();
  if (code != 200) {
    Serial.printf("HTTP GET failed, code=%d\n", code);
    http.end();
    return false;
  }

  String payload = http.getString();
  http.end();

  // Expected: {"authorized":true}
  StaticJsonDocument<64> doc;
  DeserializationError err = deserializeJson(doc, payload);
  if (err) {
    Serial.println("JSON parse error");
    return false;
  }
  bool authorized = doc["authorized"] | false;
  return authorized;
}

// ---------- SETUP / LOOP ----------
void setup() {
  Serial.begin(115200);

  // GPIOs
  pinMode(GREEN_LED, OUTPUT);
  pinMode(RED_LED, OUTPUT);
  digitalWrite(GREEN_LED, LOW);
  digitalWrite(RED_LED, LOW);

  // LCD
  

  // WiFi
  WiFi.mode(WIFI_STA);
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  unsigned long t0 = millis();
  while (WiFi.status() != WL_CONNECTED && millis() - t0 < 15000) {
    delay(300);
    Serial.print(".");
  }
  if (WiFi.status() == WL_CONNECTED) {
    Serial.print("\nWiFi OK, IP: ");
    Serial.println(WiFi.localIP());
    
  } else {
   
  }
  delay(1000);

  // RC522 (SPI)
  SPI.begin(18, 19, 23, RC522_SS_PIN);  // SCK, MISO, MOSI, SS
  rfid.PCD_Init(); // with pins from constructor

  delay(500);
}

void loop() {
  // Wait for a new card
  if (!rfid.PICC_IsNewCardPresent() || !rfid.PICC_ReadCardSerial()) {
    delay(50);
    return;
  }

  String uid = toHexUid(rfid.uid);
  Serial.print("UID: "); Serial.println(uid);

  bool ok = checkAuthorized(uid);
  if (ok) grantAccess();
  else    denyAccess();

  // Halt and stop crypto
  rfid.PICC_HaltA();
  rfid.PCD_StopCrypto1();

  delay(300);
}
