# WinsockChat
A simple socket chat resolution.

![image](https://user-images.githubusercontent.com/41315874/197382904-6a2f2880-d8a5-4b68-afad-f3251d52dca5.png)

## C-Binding API
> Minus return value represents an error
```c
#define CHAT_MODE_UDP (1)
#define CHAT_MODE_TCP (2)

int  Init(void (*f) (const char* msg, int msglen)); // f print msg to chat
int  ServerStart(const char* ip, unsigned short* port, const char* name, int mode);
int  ServerClose();
int  ClientConnect(const char* ip, unsigned short port, int mode);
int  ClientSendMessage(const char* msg, int msglen);
int  ClientClose();
void Defer();
```
