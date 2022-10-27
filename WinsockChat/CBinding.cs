using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinsockChat
{
    class CBinding
    {
        private bool nobinding = false;
        private IntPtr hLib;
        private int fd = 0;
        private EndPoint localEP, remoteEP;
        private bool stopRecv = true;
        private string servername;

        [DllImport("kernel32.dll")]
        private extern static IntPtr LoadLibrary(string path);

        [DllImport("kernel32.dll")]
        private extern static IntPtr GetProcAddress(IntPtr lib, string funcName);

        [DllImport("kernel32.dll")]
        private extern static bool FreeLibrary(IntPtr lib);

        private delegate int Type_Init(IntPtr f);
        private delegate void Type_Defer();
        private Type_Defer funcDefer;
        private delegate int Type_ServerStart(string ip,ushort port, string name, int mode);
        private Type_ServerStart funcServerStart;
        private delegate int Type_ServerClose();
        private Type_ServerClose funcServerClose;
        private delegate int Type_ClientConnect(string ip, ushort port, int mode);
        private Type_ClientConnect funcClientConnect;
        private delegate int Type_ClientSendMessage(string msg, int msglen);
        private Type_ClientSendMessage funcClientSendMessage;
        private delegate int Type_ClientClose();
        private Type_ClientClose funcClientClose;

        public delegate void Type_OnReceive(string msg);

        private Type_OnReceive fonrecv;

        public CBinding(string dllpath, Type_OnReceive f)
        {
            fonrecv = f;
            if (dllpath.Length == 0)
            {
                nobinding = true;
                return;
            }
            hLib = LoadLibrary(dllpath);
            if (hLib == IntPtr.Zero)
            {
                nobinding = true;
                return;
            }
            if (hLib != IntPtr.Zero)
            {
                Type_Init funcInit = (Type_Init)Invoke("Init", typeof(Type_Init));
                int r = funcInit(Marshal.GetFunctionPointerForDelegate(f));
                if (r < 0)
                {
                    FreeLibrary(hLib);
                    nobinding = true;
                    throw new SystemException("Call funcInit error.");
                }
                funcDefer = (Type_Defer)Invoke("Defer", typeof(Type_Defer));
                funcServerStart = (Type_ServerStart)Invoke("ServerStart", typeof(Type_ServerStart));
                funcServerClose = (Type_ServerClose)Invoke("ServerClose", typeof(Type_ServerClose));
                funcClientConnect = (Type_ClientConnect)Invoke("ClientConnect", typeof(Type_ClientConnect));
                funcClientSendMessage = (Type_ClientSendMessage)Invoke("ClientSendMessage", typeof(Type_ClientSendMessage));
                funcClientClose = (Type_ClientClose)Invoke("ClientClose", typeof(Type_ClientClose));
            }
        }

        private Socket s;

        ~CBinding()
        {
            if (hLib != IntPtr.Zero)
            {
                funcDefer();
                serThread.Abort();
                FreeLibrary(hLib);
            }
            else if (nobinding)
            {
                if (s != null) s.Close();
            }

        }

        /// <summary>
        /// 将要执行的函数转换为委托
        /// </summary>
        private Delegate Invoke(string APIName, Type t)
        {
            IntPtr api = GetProcAddress(hLib, APIName);
            return Marshal.GetDelegateForFunctionPointer(api, t);
        }

        private Thread serThread;



        /// <summary>
        /// C signature: int ServerStart(const char* ip, unsigned short* port, const char* name, int mode)
        /// return socket fd
        /// </summary>
        public int ServerStart(string ip, ushort port, string name, int mode)
        {
            if (ip == "") throw new ArgumentNullException("ip");
            if (nobinding)
            {
                if (fd != 0) throw new Exception("Dulplicate Bind.");
                s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                localEP = new IPEndPoint(IPAddress.Parse(ip), port);
                s.Bind(localEP);
                port = (ushort)((IPEndPoint)s.LocalEndPoint).Port;
                fd = (int)s.Handle;
                if (!stopRecv) throw new Exception("Dulplicate Receive.");
                stopRecv = false;
                servername = name;
                byte[] buf = new byte[65535];
                // 创建ip+port
                EndPoint rEP = new IPEndPoint(0, 0);
                s.BeginReceiveFrom(buf, 0, 65535, SocketFlags.None, ref rEP, ReceiveCallback(buf, fonrecv), rEP);
            } else
            {
                serThread = new Thread( () => {
                    fd = funcServerStart(ip,port, name, mode);
                });
                serThread.Start();
                
            }
            return fd;
        }

        /// <summary>
        /// C signature: int  ServerClose();
        /// </summary>
        public void ServerClose()
        {
            if (fd == 0) throw new Exception("Dulplicate Close.");
            if (nobinding)
            {
                stopRecv = true;
                s.Close();
            }
            else
            {
                serThread.Abort();
                int r = funcServerClose();
                if (r < 0) throw new Exception("funcServerClose error.");
            }
            fd = 0;
        }

        private AsyncCallback ReceiveCallback(byte[] buf, Type_OnReceive f)
        {
            return ar =>
            {
                try
                {
                    EndPoint rEP = (EndPoint)ar.AsyncState;
                    int n = s.EndReceiveFrom(ar, ref rEP);
                    if (n > 0)
                    {
                        // 将数据流转成字符串
                        string msg = Encoding.Unicode.GetString(buf, 0, n);
                        f("[" + rEP.ToString() + "] " + msg);
                    }
                    if (!stopRecv) s.BeginReceiveFrom(buf, 0, 65535, SocketFlags.None, ref rEP, ReceiveCallback(buf, f), rEP);
                } catch (Exception) { }
            };
        }

        /// <summary>
        /// C signature: int  ClientConnect(const char* ip, unsigned short port, int mode);
        /// </summary>
        public int ClientConnect(string ip, ushort port, int mode)
        {
            if (nobinding)
            {
                remoteEP = new IPEndPoint(IPAddress.Parse(ip), port);
                return 0;
            }
            return funcClientConnect(ip, port, mode);
        }

        /// <summary>
        /// C signature: int  ClientSendMessage(const char* msg, int msglen);
        /// </summary>
        public void ClientSendMessage(string msg)
        {
            if (nobinding)
            {
                EndPoint rep = remoteEP;
                Socket tmp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                tmp.Bind(new IPEndPoint(0, 0));
                tmp.SendTo(Encoding.Unicode.GetBytes(servername + ": " + msg), rep);
                tmp.Close();
            }
            else
            {
                int r = funcClientSendMessage(msg, System.Text.Encoding.Default.GetByteCount(msg));
                if (r < 0) throw new Exception("funcClientSendMessage error.");
            }
        }

        /// <summary>
        /// C signature: int  ClientClose();
        /// </summary>
        public void ClientClose()
        {
            if (nobinding) return;
            funcClientClose();
        }
    }
}
