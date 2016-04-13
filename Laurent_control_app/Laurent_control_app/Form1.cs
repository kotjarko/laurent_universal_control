using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace Laurent_control_app
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            laurent1 = new Connection("192.168.0.101", 2424);
            if (laurent1.connect())
            {
                laurent1.send("$KE\r\n");
                label1.Text += laurent1.read();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
