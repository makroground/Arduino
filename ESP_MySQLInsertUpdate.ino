/*
  Einfache Verwendung der MySQL Library auf dem ESP8266
  Version: 1.2
  Author: Ricardo Breßler
*/

#include <ESP8266WiFi.h>
#include <WiFiClient.h>
#include <MySQL_Connection.h>
#include <MySQL_Cursor.h>

IPAddress server_addr(192,168,188,100); // IP of the MySQL server here
char user[] = "root"; // MySQL user login username
char password[] = "...............*"; // MySQL user login password

// WiFi card example
char ssid[] = ".............."; // your SSID
char pass[] = ".............."; // your SSID Password

// Sample query
char UPDATE_SQL[] = "UPDATE rb_iot.mbrightlight SET value = '%s' WHERE name = 'bh1750fvi_1';";
char SELECT_SQL[] = "SELECT name, value FROM rb_iot.mbrightlight WHERE name = 'strip_1' OR name = 'strip_2';";
char tempQuery[128];

String sens_val1 = "";
String sens_val2 = "";

WiFiClient client;
MySQL_Connection conn((Client *)&client);

void setup()
{
  Serial.begin(9600);
  // Begin WiFi section
  WiFi.begin(ssid, pass);
  // Wait for connection
  while (WiFi.status() != WL_CONNECTED)
  {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.print("Connected to ");
  Serial.println(ssid);
  Serial.print("IP address: ");
  Serial.println(WiFi.localIP());
  // End WiFi section
  
  Serial.println("DB - Connecting...");
  while (conn.connect(server_addr, 3306, user, password) != true)
  {
    delay(500);
    Serial.print(".");
  }
}

void loop()
{
  delay(10000);
  
  Serial.println("INSERT of values");
  
  // Initiate the query class instance
  MySQL_Cursor *cur_mem1 = new MySQL_Cursor(&conn);
  // Execute the query
  sprintf(tempQuery, UPDATE_SQL, String(random(20000)).c_str());
  cur_mem1->execute(tempQuery);
  // Note: since there are no results, we do not need to read any data
  // Deleting the cursor also frees up memory used
  //delete cur_mem1;

  // Initiate the query class instance
  //MySQL_Cursor *cur_mem2 = new MySQL_Cursor(&conn);
  // Execute the query
  cur_mem1->execute(SELECT_SQL);
  // Fetch the columns (required) but we don't use them.
  column_names *columns = cur_mem1->get_columns();

  // Read the row (we are only expecting the one)
  row_values *row = NULL;
  do {
    row = cur_mem1->get_next_row();
    if (row != NULL) {
      // Sensorname auslesen
      String sens_name = row->values[0];
      Serial.print(sens_name + ": ");
      // Senserwert auslesen
      String sens_value = row->values[1];
      if (sens_name == "strip_1")
      {
        sens_val1 = sens_value;
        Serial.println(sens_val1);
      }
      else if (sens_name == "strip_2")
      {
        sens_val2 = sens_value;
        Serial.println(sens_val2);
      }
    }
  } while (row != NULL);
  
  // Deleting the cursor also frees up memory used
  delete cur_mem1;
}
