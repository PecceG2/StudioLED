#include <EEPROM.h>

struct rgb {
  int r,g,b;
};
bool uncached;
int cache_r, cache_g, cache_b;

void setup(){
    pinMode(3, OUTPUT);
    pinMode(5, OUTPUT);
    pinMode(6, OUTPUT);
    Serial.begin(9600);
    Serial.setTimeout(200);

    rgb rgbSaved;
    EEPROM.get(0, rgbSaved);
    setColor(rgbSaved.r, rgbSaved.g, rgbSaved.b);
}

void loop(){
  if(Serial.available() > 0){
    char buff[14];
    int r,g,b;
    int buffLength = Serial.readBytes(buff, 13);
    if(buffLength == 12){
      //simple length validation
      char * p_ocurrence = strchr(buff, ':');
      if(p_ocurrence-buff+1 == 4){
        //First separator
        if(strchr(p_ocurrence+1, ':')-buff+1 == 8){
          //Second separator
          r = charToIntRGB(buff[0], buff[1], buff[2]);
          g = charToIntRGB(buff[4], buff[5], buff[6]);
          b = charToIntRGB(buff[8], buff[9], buff[10]);
          setColor(r,g,b);

          rgb rgbObject = {
            r,g,b
          };
          
          // Evite excessive writing in the eeprom
          if(cache_r != r){
            cache_r = r;
            uncached = true;
          }
          if(cache_g != g){
            cache_g = g;
            uncached = true;
          }
          if(cache_b != b){
            cache_b = b;
            uncached = true;
          }

          if(uncached){
            uncached = false;
            EEPROM.put(0, rgbObject);
          }
          
        }
      }      
    }
  }else{
    
  }
  
}

int charToIntRGB(char one, char two, char tree){
  // easy conversion char array -> int without ASCII conversion
  String s_intbuffer = "";
  s_intbuffer.concat(one);
  s_intbuffer.concat(two);
  s_intbuffer.concat(tree);
  int intvalue = s_intbuffer.toInt();
  return intvalue;
}

void setColor(int r, int g, int b){
  analogWrite(3, b);
  analogWrite(5, r);
  analogWrite(6, g);
}
