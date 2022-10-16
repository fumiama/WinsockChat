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
                cb = new CBinding(dllpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
            InitializeComponent();
            var r = new Random();
            var i = r.Next(0, 99999);
            textBoxLocalName.Text = "Listener"+ string.Format("{0:00000}", i);
            textBoxRemoteName.Text = "Sender" + string.Format("{0:00000}", i);
        }
    }
}

