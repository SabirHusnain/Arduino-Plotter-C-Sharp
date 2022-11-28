#define aData A7

int aRead;

void setup()
{
  Serial.begin(115200);
}

void loop()
{
  aRead=analogRead(aData);
  Serial.println(aRead);
  delay(10);
}
