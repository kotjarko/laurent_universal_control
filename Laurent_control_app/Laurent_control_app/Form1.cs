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

        Status_Check check_1;
        Status_Check check_2;

        Thread thread_check_1;
        Thread thread_check_2;

        public Form1()
        {
            InitializeComponent();
            controller_1 = new LaurentTCP();
            controller_2 = new LaurentTCP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!controller_1.connected) controller_1.connect("192.168.0.101", 2424);
            check_1 = new Status_Check(controller_1);
            thread_check_1 = new Thread(check_1.DoWork);
            thread_check_1.Start();

            /* if (!controller_2.connected) controller_2.connect("192.168.0.102", 2424); // TODO
            check_2 = new Status_Check(controller_2);
            thread_check_2 = new Thread(check_2.DoWork);
            thread_check_2.Start();
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Кнопка связи
            if (controller_1.connected && controller_2.connected) btn_connect.Enabled = false;
            else btn_connect.Enabled = true;
            // Запрос изменения состояния - вынесено в отдельный поток
            //if (controller_1.connected) controller_1.request_changes();
            //if (controller_2.connected) controller_2.request_changes();
            // Связь с 1 контроллером
            if (controller_1.alive)
            {
                lbl_controller1_connected.Text = "Есть связь";
                lbl_controller1_connected.ForeColor = Color.Green;

               // controller_1.request_changes();
            }
            else
            {
                lbl_controller1_connected.Text = "Нет связи";
                lbl_controller1_connected.ForeColor = Color.Red;
            }

            // Связь со 2 контроллером
            if (controller_2.alive)
            {
                lbl_controller2_connected.Text = "Есть связь";
                lbl_controller2_connected.ForeColor = Color.Green;

                // controller_2.request_changes();
            }
            else
            {
                lbl_controller2_connected.Text = "Нет связи";
                lbl_controller2_connected.ForeColor = Color.Red;
            }
            // Контроллер 1 - реле
            set_relay_out_btn(relay_1_1, controller_1.laurent_relay[0], "relay");
            set_relay_out_btn(relay_1_2, controller_1.laurent_relay[1], "relay");
            set_relay_out_btn(relay_1_3, controller_1.laurent_relay[2], "relay");
            set_relay_out_btn(relay_1_4, controller_1.laurent_relay[3], "relay");
            // Контроллер 2 - реле
            set_relay_out_btn(relay_2_1, controller_2.laurent_relay[0], "relay");
            set_relay_out_btn(relay_2_2, controller_2.laurent_relay[1], "relay");
            set_relay_out_btn(relay_2_3, controller_2.laurent_relay[2], "relay");
            set_relay_out_btn(relay_2_4, controller_2.laurent_relay[3], "relay");
            // Контроллер 1 - дискретные выходы
            set_relay_out_btn(out_1_1, controller_1.laurent_out[0], "out");
            set_relay_out_btn(out_1_2, controller_1.laurent_out[1], "out");
            set_relay_out_btn(out_1_3, controller_1.laurent_out[2], "out");
            set_relay_out_btn(out_1_4, controller_1.laurent_out[3], "out");
            set_relay_out_btn(out_1_5, controller_1.laurent_out[4], "out");
            set_relay_out_btn(out_1_6, controller_1.laurent_out[5], "out");
            set_relay_out_btn(out_1_7, controller_1.laurent_out[6], "out");
            set_relay_out_btn(out_1_8, controller_1.laurent_out[7], "out");
            set_relay_out_btn(out_1_9, controller_1.laurent_out[8], "out");
            set_relay_out_btn(out_1_10, controller_1.laurent_out[9], "out");
            set_relay_out_btn(out_1_11, controller_1.laurent_out[10], "out");
            set_relay_out_btn(out_1_12, controller_1.laurent_out[11], "out");
            // Контроллер 2 - дискретные выходы
            set_relay_out_btn(out_2_1, controller_2.laurent_out[0], "out");
            set_relay_out_btn(out_2_2, controller_2.laurent_out[1], "out");
            set_relay_out_btn(out_2_3, controller_2.laurent_out[2], "out");
            set_relay_out_btn(out_2_4, controller_2.laurent_out[3], "out");
            set_relay_out_btn(out_2_5, controller_2.laurent_out[4], "out");
            set_relay_out_btn(out_2_6, controller_2.laurent_out[5], "out");
            set_relay_out_btn(out_2_7, controller_2.laurent_out[6], "out");
            set_relay_out_btn(out_2_8, controller_2.laurent_out[7], "out");
            set_relay_out_btn(out_2_9, controller_2.laurent_out[8], "out");
            set_relay_out_btn(out_2_10, controller_2.laurent_out[9], "out");
            set_relay_out_btn(out_2_11, controller_2.laurent_out[10], "out");
            set_relay_out_btn(out_2_12, controller_2.laurent_out[11], "out");
            // Контроллер 1 - входы
            set_relay_out_btn(in_1_1, controller_1.laurent_in[0], "in");
            set_relay_out_btn(in_1_2, controller_1.laurent_in[1], "in");
            set_relay_out_btn(in_1_3, controller_1.laurent_in[2], "in");
            set_relay_out_btn(in_1_4, controller_1.laurent_in[3], "in");
            set_relay_out_btn(in_1_5, controller_1.laurent_in[4], "in");
            set_relay_out_btn(in_1_6, controller_1.laurent_in[5], "in");
            // Контроллер 2 - входы
            set_relay_out_btn(in_2_1, controller_2.laurent_in[0], "in");
            set_relay_out_btn(in_2_2, controller_2.laurent_in[1], "in");
            set_relay_out_btn(in_2_3, controller_2.laurent_in[2], "in");
            set_relay_out_btn(in_2_4, controller_2.laurent_in[3], "in");
            set_relay_out_btn(in_2_5, controller_2.laurent_in[4], "in");
            set_relay_out_btn(in_2_6, controller_2.laurent_in[5], "in");
        }

        private void set_relay_out_btn(Button button, short state, string type)
        {
            switch(state)
            {
                case -1:
                    if (type!="in") button.Enabled = false;
                    button.BackColor = Color.LightGray;
                    button.Text = "---";
                    break;
                case 0:
                    if (type != "in") button.Enabled = true;
                    button.BackColor = Color.LightCoral;
                    if (type == "relay") button.Text = "Выкл";
                    else button.Text = "0";
                    break;
                case 1:
                    if (type != "in") button.Enabled = true;
                    button.BackColor = Color.Green;
                    if (type == "relay") button.Text = "Вкл";
                    else button.Text = "1";
                    break;
                default: 
                    // TODO ERROR
                    break;
            }
        }

        private void on_btn_out_click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                short pin = short.Parse(button.Name.Split('_')[2]);
                short state = 0;

                if (button.Name.Split('_')[1] == "1")
                {
                    if (controller_1.laurent_out[pin - 1] == 0) state = 1;
                    controller_1.set_output(pin, state);
                }
                else if (button.Name.Split('_')[1] == "1")
                {
                    if (controller_1.laurent_out[pin - 1] == 0) state = 1;
                    controller_1.set_output(pin, state);
                }
                // TODO else error
            }
        }

        private void on_btn_relay_click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                short pin = short.Parse(button.Name.Split('_')[2]);
                short state = 0;

                if (button.Name.Split('_')[1] == "1")
                {
                    if (controller_1.laurent_relay[pin - 1] == 0) state = 1;
                    controller_1.set_relay(pin, state);
                }
                else if (button.Name.Split('_')[1] == "1")
                {
                    if (controller_1.laurent_relay[pin - 1] == 0) state = 1;
                    controller_1.set_relay(pin, state);
                }
                // TODO else error
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            check_1.RequestStop();
            //check_2.RequestStop();
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            //button1.Text = controller_1.check_input();
        }
    }

    class Status_Check
    {
        private volatile LaurentTCP controller;
        private volatile bool _shouldStop;

        public Status_Check(LaurentTCP _controller)
        {
            controller = _controller;
        }
        public void DoWork()
        {
            while (!_shouldStop)
            {
                controller.request_changes();
            }
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }
    }
}
