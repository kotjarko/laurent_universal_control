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
        private LaurentTCP controller_1;
        private LaurentTCP controller_2;

        public Form1()
        {
            InitializeComponent();
            controller_1 = new LaurentTCP();
            controller_2 = new LaurentTCP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller_1.connect("192.168.0.101", 2424);
            //controller_2.connect("192.168.0.101", 2424);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Связь с 1 контроллером
            if (controller_1.connected)
            {
                lbl_controller1_connected.Text = "Есть связь";
                lbl_controller1_connected.ForeColor = Color.Green;
            }
            else
            {
                lbl_controller1_connected.Text = "Нет связи";
                lbl_controller1_connected.ForeColor = Color.Red;
            }

            // Связь со 2 контроллером
            if (controller_2.connected)
            {
                lbl_controller2_connected.Text = "Есть связь";
                lbl_controller2_connected.ForeColor = Color.Green;
            }
            else
            {
                lbl_controller2_connected.Text = "Нет связи";
                lbl_controller2_connected.ForeColor = Color.Red;
            }
        }
    }
}
