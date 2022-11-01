
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
            this.groupBoxLocalProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLocalProp.Location = new System.Drawing.Point(13, 12);
            this.groupBoxLocalProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLocalProp.Name = "groupBoxLocalProp";
            this.groupBoxLocalProp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLocalProp.Size = new System.Drawing.Size(441, 142);
            this.groupBoxLocalProp.TabIndex = 0;
            this.groupBoxLocalProp.TabStop = false;
            this.groupBoxLocalProp.Text = "Local Properties";
            // 
            // textBoxLocalName
            // 
            this.textBoxLocalName.Location = new System.Drawing.Point(164, 84);
            this.textBoxLocalName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLocalName.Name = "textBoxLocalName";
            this.textBoxLocalName.Size = new System.Drawing.Size(146, 27);
            this.textBoxLocalName.TabIndex = 9;
            // 
            // checkBoxLocalUDP
            // 
            this.checkBoxLocalUDP.AutoSize = true;
            this.checkBoxLocalUDP.Checked = true;
            this.checkBoxLocalUDP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLocalUDP.Location = new System.Drawing.Point(90, 85);
            this.checkBoxLocalUDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxLocalUDP.Name = "checkBoxLocalUDP";
            this.checkBoxLocalUDP.Size = new System.Drawing.Size(70, 26);
            this.checkBoxLocalUDP.TabIndex = 8;
            this.checkBoxLocalUDP.Text = "UDP";
            this.checkBoxLocalUDP.UseVisualStyleBackColor = true;
            this.checkBoxLocalUDP.CheckedChanged += new System.EventHandler(this.checkBoxLocalUDP_CheckedChanged);
            // 
            // checkBoxLocalTCP
            // 
            this.checkBoxLocalTCP.AutoSize = true;
            this.checkBoxLocalTCP.Checked = true;
            this.checkBoxLocalTCP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLocalTCP.Location = new System.Drawing.Point(19, 85);
            this.checkBoxLocalTCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxLocalTCP.Name = "checkBoxLocalTCP";
            this.checkBoxLocalTCP.Size = new System.Drawing.Size(69, 26);
            this.checkBoxLocalTCP.TabIndex = 7;
            this.checkBoxLocalTCP.Text = "TCP";
            this.checkBoxLocalTCP.UseVisualStyleBackColor = true;
            // 
            // buttonLocalListen
            // 
            this.buttonLocalListen.Location = new System.Drawing.Point(313, 78);
            this.buttonLocalListen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLocalListen.Name = "buttonLocalListen";
            this.buttonLocalListen.Size = new System.Drawing.Size(111, 38);
            this.buttonLocalListen.TabIndex = 6;
            this.buttonLocalListen.Text = "listen";
            this.buttonLocalListen.UseVisualStyleBackColor = true;
            this.buttonLocalListen.Click += new System.EventHandler(this.buttonLocalListen_Click);
            // 
            // textBoxLocalPort
            // 
            this.textBoxLocalPort.Location = new System.Drawing.Point(313, 37);
            this.textBoxLocalPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLocalPort.Name = "textBoxLocalPort";
            this.textBoxLocalPort.Size = new System.Drawing.Size(112, 27);
            this.textBoxLocalPort.TabIndex = 3;
            // 
            // labelLocalPort
            // 
            this.labelLocalPort.AutoSize = true;
            this.labelLocalPort.Location = new System.Drawing.Point(261, 39);
            this.labelLocalPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocalPort.Name = "labelLocalPort";
            this.labelLocalPort.Size = new System.Drawing.Size(41, 22);
            this.labelLocalPort.TabIndex = 2;
            this.labelLocalPort.Text = "port";
            // 
            // labelLocalIP
            // 
            this.labelLocalIP.AutoSize = true;
            this.labelLocalIP.Location = new System.Drawing.Point(15, 39);
            this.labelLocalIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocalIP.Name = "labelLocalIP";
            this.labelLocalIP.Size = new System.Drawing.Size(26, 22);
            this.labelLocalIP.TabIndex = 1;
            this.labelLocalIP.Text = "IP";
            // 
            // textBoxLocalIP
            // 
            this.textBoxLocalIP.Location = new System.Drawing.Point(56, 37);
            this.textBoxLocalIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLocalIP.Name = "textBoxLocalIP";
            this.textBoxLocalIP.Size = new System.Drawing.Size(197, 27);
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
            this.groupBoxRemoteProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRemoteProp.Location = new System.Drawing.Point(13, 158);
            this.groupBoxRemoteProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRemoteProp.Name = "groupBoxRemoteProp";
            this.groupBoxRemoteProp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRemoteProp.Size = new System.Drawing.Size(441, 140);
            this.groupBoxRemoteProp.TabIndex = 9;
            this.groupBoxRemoteProp.TabStop = false;
            this.groupBoxRemoteProp.Text = "Remote Properties";
            // 
            // radioButtonRemoteUDP
            // 
            this.radioButtonRemoteUDP.AutoSize = true;
            this.radioButtonRemoteUDP.Location = new System.Drawing.Point(90, 82);
            this.radioButtonRemoteUDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonRemoteUDP.Name = "radioButtonRemoteUDP";
            this.radioButtonRemoteUDP.Size = new System.Drawing.Size(69, 26);
            this.radioButtonRemoteUDP.TabIndex = 12;
            this.radioButtonRemoteUDP.TabStop = true;
            this.radioButtonRemoteUDP.Text = "UDP";
            this.radioButtonRemoteUDP.UseVisualStyleBackColor = true;
            // 
            // radioButtonRemoteTCP
            // 
            this.radioButtonRemoteTCP.AutoSize = true;
            this.radioButtonRemoteTCP.Location = new System.Drawing.Point(19, 82);
            this.radioButtonRemoteTCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonRemoteTCP.Name = "radioButtonRemoteTCP";
            this.radioButtonRemoteTCP.Size = new System.Drawing.Size(68, 26);
            this.radioButtonRemoteTCP.TabIndex = 11;
            this.radioButtonRemoteTCP.TabStop = true;
            this.radioButtonRemoteTCP.Text = "TCP";
            this.radioButtonRemoteTCP.UseVisualStyleBackColor = true;
            // 
            // buttonRemoteConnect
            // 
            this.buttonRemoteConnect.Location = new System.Drawing.Point(164, 76);
            this.buttonRemoteConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemoteConnect.Name = "buttonRemoteConnect";
            this.buttonRemoteConnect.Size = new System.Drawing.Size(261, 38);
            this.buttonRemoteConnect.TabIndex = 8;
            this.buttonRemoteConnect.Text = "connect";
            this.buttonRemoteConnect.UseVisualStyleBackColor = true;
            this.buttonRemoteConnect.Click += new System.EventHandler(this.buttonRemoteConnect_Click);
            // 
            // textBoxRemotePort
            // 
            this.textBoxRemotePort.Location = new System.Drawing.Point(313, 37);
            this.textBoxRemotePort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRemotePort.Name = "textBoxRemotePort";
            this.textBoxRemotePort.Size = new System.Drawing.Size(112, 27);
            this.textBoxRemotePort.TabIndex = 3;
            // 
            // labelRemotePort
            // 
            this.labelRemotePort.AutoSize = true;
            this.labelRemotePort.Location = new System.Drawing.Point(261, 39);
            this.labelRemotePort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRemotePort.Name = "labelRemotePort";
            this.labelRemotePort.Size = new System.Drawing.Size(41, 22);
            this.labelRemotePort.TabIndex = 2;
            this.labelRemotePort.Text = "port";
            // 
            // labelRemoteIP
            // 
            this.labelRemoteIP.AutoSize = true;
            this.labelRemoteIP.Location = new System.Drawing.Point(15, 39);
            this.labelRemoteIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRemoteIP.Name = "labelRemoteIP";
            this.labelRemoteIP.Size = new System.Drawing.Size(26, 22);
            this.labelRemoteIP.TabIndex = 1;
            this.labelRemoteIP.Text = "IP";
            // 
            // textBoxRemoteIP
            // 
            this.textBoxRemoteIP.Location = new System.Drawing.Point(56, 37);
            this.textBoxRemoteIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRemoteIP.Name = "textBoxRemoteIP";
            this.textBoxRemoteIP.Size = new System.Drawing.Size(197, 27);
            this.textBoxRemoteIP.TabIndex = 0;
            // 
            // textBoxChatReceive
            // 
            this.textBoxChatReceive.AcceptsReturn = true;
            this.textBoxChatReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChatReceive.Location = new System.Drawing.Point(19, 26);
            this.textBoxChatReceive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxChatReceive.Multiline = true;
            this.textBoxChatReceive.Name = "textBoxChatReceive";
            this.textBoxChatReceive.ReadOnly = true;
            this.textBoxChatReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChatReceive.Size = new System.Drawing.Size(405, 220);
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
            this.groupBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChat.Location = new System.Drawing.Point(13, 301);
            this.groupBoxChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChat.Name = "groupBoxChat";
            this.groupBoxChat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChat.Size = new System.Drawing.Size(441, 359);
            this.groupBoxChat.TabIndex = 10;
            this.groupBoxChat.TabStop = false;
            this.groupBoxChat.Text = "Chat";
            // 
            // buttonChatClear
            // 
            this.buttonChatClear.BackColor = System.Drawing.Color.LightCoral;
            this.buttonChatClear.Location = new System.Drawing.Point(321, 260);
            this.buttonChatClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChatClear.Name = "buttonChatClear";
            this.buttonChatClear.Size = new System.Drawing.Size(105, 34);
            this.buttonChatClear.TabIndex = 10;
            this.buttonChatClear.Text = "clear";
            this.buttonChatClear.UseVisualStyleBackColor = false;
            this.buttonChatClear.Click += new System.EventHandler(this.buttonChatClear_Click);
            // 
            // buttonChatSend
            // 
            this.buttonChatSend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonChatSend.Location = new System.Drawing.Point(321, 298);
            this.buttonChatSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChatSend.Name = "buttonChatSend";
            this.buttonChatSend.Size = new System.Drawing.Size(105, 34);
            this.buttonChatSend.TabIndex = 9;
            this.buttonChatSend.Text = "send";
            this.buttonChatSend.UseVisualStyleBackColor = false;
            this.buttonChatSend.Click += new System.EventHandler(this.buttonChatSend_Click);
            // 
            // textBoxChatSend
            // 
            this.textBoxChatSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChatSend.Location = new System.Drawing.Point(19, 260);
            this.textBoxChatSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxChatSend.Multiline = true;
            this.textBoxChatSend.Name = "textBoxChatSend";
            this.textBoxChatSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChatSend.Size = new System.Drawing.Size(291, 74);
            this.textBoxChatSend.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WinsockChat.Properties.Resources.アイキャッチ紬1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(981, 672);
            this.Controls.Add(this.groupBoxChat);
            this.Controls.Add(this.groupBoxRemoteProp);
            this.Controls.Add(this.groupBoxLocalProp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::WinsockChat.Properties.Resources.splash_flower;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
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

