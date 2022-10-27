# WinsockChat
A simple socket chat resolution.

![image](https://user-images.githubusercontent.com/41315874/198241329-8addfa89-746a-4689-a5de-e9c7a2e14617.JPG)

## [C-Binding API](https://github.com/wa-kakalala/WSChatDLL)
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
