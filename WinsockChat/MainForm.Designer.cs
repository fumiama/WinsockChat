
namespace WinsockChat
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLocalProp = new System.Windows.Forms.GroupBox();
            this.textBoxLocalName = new System.Windows.Forms.TextBox();
            this.checkBoxLocalUDP = new System.Windows.Forms.CheckBox();
            this.checkBoxLocalTCP = new System.Windows.Forms.CheckBox();
            this.buttonLocalListen = new System.Windows.Forms.Button();
            this.textBoxLocalPort = new System.Windows.Forms.TextBox();
            this.labelLocalPort = new System.Windows.Forms.Label();
            this.labelLocalIP = new System.Windows.Forms.Label();
            this.textBoxLocalIP = new System.Windows.Forms.TextBox();
            this.groupBoxRemoteProp = new System.Windows.Forms.GroupBox();
            this.radioButtonRemoteUDP = new System.Windows.Forms.RadioButton();
            this.radioButtonRemoteTCP = new System.Windows.Forms.RadioButton();
            this.buttonRemoteConnect = new System.Windows.Forms.Button();
            this.textBoxRemotePort = new System.Windows.Forms.TextBox();
            this.labelRemotePort = new System.Windows.Forms.Label();
            this.labelRemoteIP = new System.Windows.Forms.Label();
            this.textBoxRemoteIP = new System.Windows.Forms.TextBox();
            this.textBoxChatReceive = new System.Windows.Forms.TextBox();
            this.groupBoxChat = new System.Windows.Forms.GroupBox();
            this.buttonChatClear = new System.Windows.Forms.Button();
            this.buttonChatSend = new System.Windows.Forms.Button();
            this.textBoxChatSend = new System.Windows.Forms.TextBox();
            this.groupBoxLocalProp.SuspendLayout();
            this.groupBoxRemoteProp.SuspendLayout();
            this.groupBoxChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLocalProp
            // 
            this.groupBoxLocalProp.AutoSize = true;
            this.groupBoxLocalProp.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLocalProp.Controls.Add(this.textBoxLocalName);
            this.groupBoxLocalProp.Controls.Add(this.checkBoxLocalUDP);
            this.groupBoxLocalProp.Controls.Add(this.checkBoxLocalTCP);
            this.groupBoxLocalProp.Controls.Add(this.buttonLocalListen);
            this.groupBoxLocalProp.Controls.Add(this.textBoxLocalPort);
            this.groupBoxLocalProp.Controls.Add(this.labelLocalPort);
            this.groupBoxLocalProp.Controls.Add(this.labelLocalIP);
            this.groupBoxLocalProp.Controls.Add(this.textBoxLocalIP);
            this.groupBoxLocalProp.Font = new System.Drawing.Font("Meiryo UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLocalProp.Location = new System.Drawing.Point(19, 19);
            this.groupBoxLocalProp.Name = "groupBoxLocalProp";
            this.groupBoxLocalProp.Size = new System.Drawing.Size(661, 227);
            this.groupBoxLocalProp.TabIndex = 0;
            this.groupBoxLocalProp.TabStop = false;
            this.groupBoxLocalProp.Text = "Local Properties";
            // 
            // textBoxLocalName
            // 
            this.textBoxLocalName.Location = new System.Drawing.Point(246, 134);
            this.textBoxLocalName.Name = "textBoxLocalName";
            this.textBoxLocalName.Size = new System.Drawing.Size(217, 43);
            this.textBoxLocalName.TabIndex = 9;
            // 
            // checkBoxLocalUDP
            // 
            this.checkBoxLocalUDP.AutoSize = true;
            this.checkBoxLocalUDP.Location = new System.Drawing.Point(135, 136);
            this.checkBoxLocalUDP.Name = "checkBoxLocalUDP";
            this.checkBoxLocalUDP.Size = new System.Drawing.Size(105, 40);
            this.checkBoxLocalUDP.TabIndex = 8;
            this.checkBoxLocalUDP.Text = "UDP";
            this.checkBoxLocalUDP.UseVisualStyleBackColor = true;
            // 
            // checkBoxLocalTCP
            // 
            this.checkBoxLocalTCP.AutoSize = true;
            this.checkBoxLocalTCP.Location = new System.Drawing.Point(29, 136);
            this.checkBoxLocalTCP.Name = "checkBoxLocalTCP";
            this.checkBoxLocalTCP.Size = new System.Drawing.Size(100, 40);
            this.checkBoxLocalTCP.TabIndex = 7;
            this.checkBoxLocalTCP.Text = "TCP";
            this.checkBoxLocalTCP.UseVisualStyleBackColor = true;
            // 
            // buttonLocalListen
            // 
            this.buttonLocalListen.Location = new System.Drawing.Point(469, 125);
            this.buttonLocalListen.Name = "buttonLocalListen";
            this.buttonLocalListen.Size = new System.Drawing.Size(166, 60);
            this.buttonLocalListen.TabIndex = 6;
            this.buttonLocalListen.Text = "listen";
            this.buttonLocalListen.UseVisualStyleBackColor = true;
            this.buttonLocalListen.Click += new System.EventHandler(this.buttonLocalListen_Click);
            // 
            // textBoxLocalPort
            // 
            this.textBoxLocalPort.Location = new System.Drawing.Point(469, 59);
            this.textBoxLocalPort.Name = "textBoxLocalPort";
            this.textBoxLocalPort.Size = new System.Drawing.Size(166, 43);
            this.textBoxLocalPort.TabIndex = 3;
            // 
            // labelLocalPort
            // 
            this.labelLocalPort.AutoSize = true;
            this.labelLocalPort.Location = new System.Drawing.Point(391, 62);
            this.labelLocalPort.Name = "labelLocalPort";
            this.labelLocalPort.Size = new System.Drawing.Size(72, 36);
            this.labelLocalPort.TabIndex = 2;
            this.labelLocalPort.Text = "port";
            // 
            // labelLocalIP
            // 
            this.labelLocalIP.AutoSize = true;
            this.labelLocalIP.Location = new System.Drawing.Point(23, 62);
            this.labelLocalIP.Name = "labelLocalIP";
            this.labelLocalIP.Size = new System.Drawing.Size(43, 36);
            this.labelLocalIP.TabIndex = 1;
            this.labelLocalIP.Text = "IP";
            // 
            // textBoxLocalIP
            // 
            this.textBoxLocalIP.Location = new System.Drawing.Point(84, 59);
            this.textBoxLocalIP.Name = "textBoxLocalIP";
            this.textBoxLocalIP.Size = new System.Drawing.Size(293, 43);
            this.textBoxLocalIP.TabIndex = 0;
            // 
            // groupBoxRemoteProp
            // 
            this.groupBoxRemoteProp.AutoSize = true;
            this.groupBoxRemoteProp.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRemoteProp.Controls.Add(this.radioButtonRemoteUDP);
            this.groupBoxRemoteProp.Controls.Add(this.radioButtonRemoteTCP);
            this.groupBoxRemoteProp.Controls.Add(this.buttonRemoteConnect);
            this.groupBoxRemoteProp.Controls.Add(this.textBoxRemotePort);
            this.groupBoxRemoteProp.Controls.Add(this.labelRemotePort);
            this.groupBoxRemoteProp.Controls.Add(this.labelRemoteIP);
            this.groupBoxRemoteProp.Controls.Add(this.textBoxRemoteIP);
            this.groupBoxRemoteProp.Font = new System.Drawing.Font("Meiryo UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRemoteProp.Location = new System.Drawing.Point(19, 252);
            this.groupBoxRemoteProp.Name = "groupBoxRemoteProp";
            this.groupBoxRemoteProp.Size = new System.Drawing.Size(661, 224);
            this.groupBoxRemoteProp.TabIndex = 9;
            this.groupBoxRemoteProp.TabStop = false;
            this.groupBoxRemoteProp.Text = "Remote Properties";
            // 
            // radioButtonRemoteUDP
            // 
            this.radioButtonRemoteUDP.AutoSize = true;
            this.radioButtonRemoteUDP.Location = new System.Drawing.Point(135, 132);
            this.radioButtonRemoteUDP.Name = "radioButtonRemoteUDP";
            this.radioButtonRemoteUDP.Size = new System.Drawing.Size(104, 40);
            this.radioButtonRemoteUDP.TabIndex = 12;
            this.radioButtonRemoteUDP.TabStop = true;
            this.radioButtonRemoteUDP.Text = "UDP";
            this.radioButtonRemoteUDP.UseVisualStyleBackColor = true;
            // 
            // radioButtonRemoteTCP
            // 
            this.radioButtonRemoteTCP.AutoSize = true;
            this.radioButtonRemoteTCP.Location = new System.Drawing.Point(29, 132);
            this.radioButtonRemoteTCP.Name = "radioButtonRemoteTCP";
            this.radioButtonRemoteTCP.Size = new System.Drawing.Size(99, 40);
            this.radioButtonRemoteTCP.TabIndex = 11;
            this.radioButtonRemoteTCP.TabStop = true;
            this.radioButtonRemoteTCP.Text = "TCP";
            this.radioButtonRemoteTCP.UseVisualStyleBackColor = true;
            // 
            // buttonRemoteConnect
            // 
            this.buttonRemoteConnect.Location = new System.Drawing.Point(246, 122);
            this.buttonRemoteConnect.Name = "buttonRemoteConnect";
            this.buttonRemoteConnect.Size = new System.Drawing.Size(392, 60);
            this.buttonRemoteConnect.TabIndex = 8;
            this.buttonRemoteConnect.Text = "connect";
            this.buttonRemoteConnect.UseVisualStyleBackColor = true;
            this.buttonRemoteConnect.Click += new System.EventHandler(this.buttonRemoteConnect_Click);
            // 
            // textBoxRemotePort
            // 
            this.textBoxRemotePort.Location = new System.Drawing.Point(469, 59);
            this.textBoxRemotePort.Name = "textBoxRemotePort";
            this.textBoxRemotePort.Size = new System.Drawing.Size(166, 43);
            this.textBoxRemotePort.TabIndex = 3;
            // 
            // labelRemotePort
            // 
            this.labelRemotePort.AutoSize = true;
            this.labelRemotePort.Location = new System.Drawing.Point(391, 62);
            this.labelRemotePort.Name = "labelRemotePort";
            this.labelRemotePort.Size = new System.Drawing.Size(72, 36);
            this.labelRemotePort.TabIndex = 2;
            this.labelRemotePort.Text = "port";
            // 
            // labelRemoteIP
            // 
            this.labelRemoteIP.AutoSize = true;
            this.labelRemoteIP.Location = new System.Drawing.Point(23, 62);
            this.labelRemoteIP.Name = "labelRemoteIP";
            this.labelRemoteIP.Size = new System.Drawing.Size(43, 36);
            this.labelRemoteIP.TabIndex = 1;
            this.labelRemoteIP.Text = "IP";
            // 
            // textBoxRemoteIP
            // 
            this.textBoxRemoteIP.Location = new System.Drawing.Point(84, 59);
            this.textBoxRemoteIP.Name = "textBoxRemoteIP";
            this.textBoxRemoteIP.Size = new System.Drawing.Size(293, 43);
            this.textBoxRemoteIP.TabIndex = 0;
            // 
            // textBoxChatReceive
            // 
            this.textBoxChatReceive.AcceptsReturn = true;
            this.textBoxChatReceive.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChatReceive.Location = new System.Drawing.Point(29, 42);
            this.textBoxChatReceive.Multiline = true;
            this.textBoxChatReceive.Name = "textBoxChatReceive";
            this.textBoxChatReceive.ReadOnly = true;
            this.textBoxChatReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChatReceive.Size = new System.Drawing.Size(606, 350);
            this.textBoxChatReceive.TabIndex = 8;
            // 
            // groupBoxChat
            // 
            this.groupBoxChat.AutoSize = true;
            this.groupBoxChat.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxChat.Controls.Add(this.buttonChatClear);
            this.groupBoxChat.Controls.Add(this.buttonChatSend);
            this.groupBoxChat.Controls.Add(this.textBoxChatSend);
            this.groupBoxChat.Controls.Add(this.textBoxChatReceive);
            this.groupBoxChat.Font = new System.Drawing.Font("Meiryo UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChat.Location = new System.Drawing.Point(19, 482);
            this.groupBoxChat.Name = "groupBoxChat";
            this.groupBoxChat.Size = new System.Drawing.Size(661, 575);
            this.groupBoxChat.TabIndex = 10;
            this.groupBoxChat.TabStop = false;
            this.groupBoxChat.Text = "Chat";
            // 
            // buttonChatClear
            // 
            this.buttonChatClear.BackColor = System.Drawing.Color.LightCoral;
            this.buttonChatClear.Location = new System.Drawing.Point(481, 416);
            this.buttonChatClear.Name = "buttonChatClear";
            this.buttonChatClear.Size = new System.Drawing.Size(157, 55);
            this.buttonChatClear.TabIndex = 10;
            this.buttonChatClear.Text = "clear";
            this.buttonChatClear.UseVisualStyleBackColor = false;
            this.buttonChatClear.Click += new System.EventHandler(this.buttonChatClear_Click);
            // 
            // buttonChatSend
            // 
            this.buttonChatSend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonChatSend.Location = new System.Drawing.Point(481, 477);
            this.buttonChatSend.Name = "buttonChatSend";
            this.buttonChatSend.Size = new System.Drawing.Size(157, 55);
            this.buttonChatSend.TabIndex = 9;
            this.buttonChatSend.Text = "send";
            this.buttonChatSend.UseVisualStyleBackColor = false;
            this.buttonChatSend.Click += new System.EventHandler(this.buttonChatSend_Click);
            // 
            // textBoxChatSend
            // 
            this.textBoxChatSend.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChatSend.Location = new System.Drawing.Point(29, 416);
            this.textBoxChatSend.Multiline = true;
            this.textBoxChatSend.Name = "textBoxChatSend";
            this.textBoxChatSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChatSend.Size = new System.Drawing.Size(434, 116);
            this.textBoxChatSend.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WinsockChat.Properties.Resources.アイキャッチ紬1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1472, 1076);
            this.Controls.Add(this.groupBoxChat);
            this.Controls.Add(this.groupBoxRemoteProp);
            this.Controls.Add(this.groupBoxLocalProp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::WinsockChat.Properties.Resources.splash_flower;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "WinsockChat";
            this.groupBoxLocalProp.ResumeLayout(false);
            this.groupBoxLocalProp.PerformLayout();
            this.groupBoxRemoteProp.ResumeLayout(false);
            this.groupBoxRemoteProp.PerformLayout();
            this.groupBoxChat.ResumeLayout(false);
            this.groupBoxChat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLocalProp;
        private System.Windows.Forms.TextBox textBoxLocalIP;
        private System.Windows.Forms.Label labelLocalIP;
        private System.Windows.Forms.Label labelLocalPort;
        private System.Windows.Forms.TextBox textBoxLocalPort;
        private System.Windows.Forms.Button buttonLocalListen;
        private System.Windows.Forms.GroupBox groupBoxRemoteProp;
        private System.Windows.Forms.TextBox textBoxRemotePort;
        private System.Windows.Forms.Label labelRemotePort;
        private System.Windows.Forms.Label labelRemoteIP;
        private System.Windows.Forms.TextBox textBoxRemoteIP;
        private System.Windows.Forms.CheckBox checkBoxLocalUDP;
        private System.Windows.Forms.CheckBox checkBoxLocalTCP;
        private System.Windows.Forms.TextBox textBoxChatReceive;
        private System.Windows.Forms.GroupBox groupBoxChat;
        private System.Windows.Forms.Button buttonChatSend;
        private System.Windows.Forms.TextBox textBoxChatSend;
        private System.Windows.Forms.RadioButton radioButtonRemoteUDP;
        private System.Windows.Forms.RadioButton radioButtonRemoteTCP;
        private System.Windows.Forms.TextBox textBoxLocalName;
        private System.Windows.Forms.Button buttonRemoteConnect;
        private System.Windows.Forms.Button buttonChatClear;
    }
}

