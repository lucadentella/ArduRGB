/*
    ArduRGB 1.0
    Luca Dentella, 27/09/2011
    
    A simple program which receives 3 bytes from serial port
    (RGB value) and outputs to PWM pins to drive a
    common-anode RGB led (output value = 255 - real value).      
*/

// pins definition
const int red_pin = 9;
const int green_pin = 10;
const int blue_pin = 11;

// message variables
byte message[3];
int message_index;

void setup() {
  
  // init serial communication
  Serial.begin(9600);

  // pins configured as output
  pinMode(red_pin, OUTPUT);
  pinMode(green_pin, OUTPUT);
  pinMode(blue_pin, OUTPUT);  
  
  // Start with black value (leds off)
  analogWrite(red_pin, 255);
  analogWrite(green_pin, 255);
  analogWrite(blue_pin, 255);
  
  // reset message position pointer
  message_index = 0;
}

void loop() {
  
  // new byte from serial communication
  if (Serial.available() > 0) {

    // store received byte in message array
    // and increment pointer
    message[message_index] = Serial.read();
    message_index++;

    // if we received 3 bytes, reset pointer
    // and output the values
    if(message_index == 3) {
      message_index = 0;
      analogWrite(red_pin, 255 - message[0]);
      analogWrite(green_pin, 255 - message[1]);
      analogWrite(blue_pin, 255 - message[2]);
    }
  }
}
