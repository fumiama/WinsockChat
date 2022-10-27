using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace WinsockChat
{
    public partial class MainForm : Form
    {
        private readonly CBinding cb;
        public MainForm(string dllpath)
        {
            try
            {
                cb = new CBinding(dllpath, OnReceive);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
            InitializeComponent();
            var r = new Random();
            var i = r.Next(0, 99999);
            textBoxLocalName.Text = "User"+ string.Format("{0:00000}", i);
        }

        private readonly Mutex mu = new Mutex();
        private void OnReceive(string msg)
        {
            mu.WaitOne();
            Invoke(new Action(() =>
            {
                textBoxChatReceive.Text += msg + "\r\n";
                textBoxChatReceive.SelectionStart = textBoxChatReceive.Text.Length;
                textBoxChatReceive.ScrollToCaret();
            }));
            mu.ReleaseMutex();
        }

        private void buttonChatClear_Click(object sender, EventArgs e)
        {
            mu.WaitOne();
            textBoxChatReceive.Text = "";
            mu.ReleaseMutex();
        }

        private void buttonLocalListen_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonLocalListen.Text == "listen")
                {
                    int mode = 0;
                    if(checkBoxLocalUDP.Checked) mode |= 1;
                    if (checkBoxLocalTCP.Checked) mode |= 2;
                    if(mode == 0)
                    {
                        throw new Exception("NULL protocol.");
                    }
                    ushort port = ushort.Parse(textBoxLocalPort.Text);
                    cb.ServerStart(textBoxLocalIP.Text, port, textBoxLocalName.Text, mode);
                    textBoxLocalPort.Text = port.ToString();
                    buttonLocalListen.Text = "close";
                } else
                {
                    cb.ServerClose();
                    buttonLocalListen.Text = "listen";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void buttonRemoteConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRemoteConnect.Text == "connect")
                {
                    int mode;
                    if (radioButtonRemoteUDP.Checked) mode = 1;
                    else if (radioButtonRemoteTCP.Checked) mode = 2;
                    else
                    {
                        MessageBox.Show("NULL protocol.", "ERROR");
                        return;
                    }
                    ushort port = ushort.Parse(textBoxRemotePort.Text);
                    if (port == 0)
                    {
                        MessageBox.Show("Invalid Remote Port.", "ERROR");
                        return;
                    }
                    cb.ClientConnect(textBoxRemoteIP.Text, port, mode);
                    buttonRemoteConnect.Text = "close";
                }
                else
                {
                    cb.ClientClose();
                    buttonRemoteConnect.Text = "connect";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void buttonChatSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxChatSend.Text != "")
                {
                    OnReceive("Me -> " + textBoxChatSend.Text);
                    cb.ClientSendMessage(textBoxChatSend.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void checkBoxLocalUDP_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
