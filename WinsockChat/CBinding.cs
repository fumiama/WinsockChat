using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WinsockChat
{
    class CBinding
    {
        const int CHAT_MODE_UDP = 1;
        const int CHAT_MODE_TCP = 2;
        private bool nobinding = false;
        private IntPtr hLib;
        private int fd = 0;
        private EndPoint localEP;
        private bool stopRecv = true;

        [DllImport("kernel32.dll")]
        private extern static IntPtr LoadLibrary(string path);

        [DllImport("kernel32.dll")]
        private extern static IntPtr GetProcAddress(IntPtr lib, string funcName);

        [DllImport("kernel32.dll")]
        private extern static bool FreeLibrary(IntPtr lib);

        private delegate int Type_Init(IntPtr f);
        private delegate void Type_Defer();
        private Type_Defer funcDefer;
        private delegate int Type_ServerStart(string ip, ref ushort port, string name, int mode);
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

        public CBinding(string dllpath, Type_OnReceive f)
        {
            if(dllpath.Length == 0)
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

        private Socket stcp, sudp;

        ~CBinding()
        {
            if (hLib != IntPtr.Zero)
            {
                funcDefer();
                FreeLibrary(hLib);
            }
            else if (nobinding)
            {
                if (stcp != null) stcp.Close();
                if (sudp != null) sudp.Close();
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

        /// <summary>
        /// C signature: int ServerStart(const char* ip, unsigned short* port, const char* name, int mode)
        /// return socket fd
        /// </summary>
        public int ServerStart(string ip, ref ushort port, string name, int mode)
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
            } else
            {
                fd = funcBind(ip, ref port);
                if (fd <= 0) throw new Exception("funcBind error.");
            }
            return fd;
        }

        /// <summary>
        /// C signature: void Close(int fd)
        /// </summary>
        public void Close()
        {
            if (fd == 0) throw new Exception("Dulplicate Close.");
            if (nobinding) s.Close();
            else
            {
                int r = funcClose();
                if (r < 0) throw new Exception("funcClose error.");
            }
            fd = 0;
        }

        public delegate void Type_LogListen(string msg);

        /// <summary>
        /// C signature: void Receive(void (*f) (const char* msg))
        /// </summary>
        public void Receive(Type_LogListen f)
        {
            if (fd == 0) throw new Exception("No Binding.");
            if (!stopRecv) throw new Exception("Dulplicate Receive.");
            stopRecv = false;
            if (nobinding)
            {
                byte[] buf = new byte[65535];
                // 创建ip+port
                EndPoint remoteEP = new IPEndPoint(0, 0);
                s.BeginReceiveFrom(buf, 0, 65535, SocketFlags.None, ref remoteEP, ReceiveCallback(buf, f), remoteEP);
            }
            else
            {
                stopRecv = funcReceive(Marshal.GetFunctionPointerForDelegate(f)) < 0;
            }
        }

        private AsyncCallback ReceiveCallback(byte[] buf, Type_LogListen f)
        {
            return ar =>
            {
                try
                {
                    EndPoint remoteEP = (EndPoint)ar.AsyncState;
                    int n = s.EndReceiveFrom(ar, ref remoteEP);
                    if (n > 0)
                    {
                        s.SendTo(buf, 0, n, SocketFlags.None, remoteEP);
                        // 将数据流转成字符串
                        string msg = Encoding.Default.GetString(buf, 0, n);
                        f("[" + remoteEP.ToString() + "] " + msg);
                    }
                    if (!stopRecv) s.BeginReceiveFrom(buf, 0, 65535, SocketFlags.None, ref remoteEP, ReceiveCallback(buf, f), remoteEP);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name);
                }
            };
        }

        /// <summary>
        /// C signature: void StopReceive()
        /// </summary>
        public void StopReceive()
        {
            if (fd == 0) throw new Exception("No Binding.");
            if (stopRecv) return;
            stopRecv = true;
            if (!nobinding)
            {
                int r = funcStopReceive();
                if (r < 0) throw new Exception("funcStopReceive error.");
            }
        }

        byte[] pingbuf = new byte[65535];
        /// <summary>
        /// C signature: int Ping(const char* ip, unsigned short port)
        /// </summary>
        public void Ping(string ip, ushort port)
        {
            if (nobinding)
            {
                EndPoint rep = new IPEndPoint(IPAddress.Parse(ip), port);
                Socket tmp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                tmp.Bind(new IPEndPoint(0, 0));
                tmp.SendTo(Encoding.Default.GetBytes(DateTime.Now.ToString()), rep);
                tmp.ReceiveFrom(pingbuf, ref rep);
                tmp.Close();
            }
            else
            {
                int r = funcPing(ip, port);
                if (r < 0) throw new Exception("funcPing error.");
            }
        }
    }
}
