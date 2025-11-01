# RFID-Door-Access-System
RFID Access System using Arduino + C# + MS SQL

##System Overview
RFID Card Scan → 
  The RC522 module reads the card UID.

Data Transmission →
  Arduino sends UID via Serial to the PC app.
  ESP32 sends UID via HTTP POST to the Web API.
  Database Check → The API verifies UID in the SQL Server database.
 
Response →
  Verified → Green LED, LCD shows user name.
  Denied → Red LED.

##How to Run
-Clone this repository.
-Set up the SQL Server database and update the connection string in appsettings.json.
-Run the ASP.NET Core API (dotnet run or from Visual Studio).
-Upload the Arduino/ESP32 sketches to your boards.
-Launch the WinForms app for admin operations.

##Hardware Components
Arduino Uno
ESP32
RC522 RFID Reader
I2C LCD Display
LEDs

## Used Technologies
Tools: Visual Studio, Arduino IDE
Languages & Frameworks: C# (.NET, ASP.NET Core Web API), Arduino
Database: Microsoft SQL Server
Communication: Serial, HTTP (JSON)




