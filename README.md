# Demo Controller App

You can use the code below for the mbed to test the CSharp app. Make sure to attach an application board and to include the library https://developer.mbed.org/users/chris/code/C12832/

```C++
#include "mbed.h"
#include "C12832.h"
 
Serial pc(USBTX, USBRX); // tx, rx
C12832 lcd(p5, p7, p6, p8, p11);
 
int main() {
    pc.baud(9600);
    lcd.cls();
    lcd.locate(0,3);
    lcd.printf("Received:");
    
    pc.printf("Hello World!\n");
    while(1) {
        // Display received data
        char c = pc.getc();
        if (c != EOF) {
            lcd.locate(0,15);
            lcd.printf("Byte : %d", c);
            wait(0.1);
        }    
    }
}
```