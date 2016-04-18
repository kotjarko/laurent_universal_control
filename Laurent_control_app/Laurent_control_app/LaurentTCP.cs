using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laurent_control_app
{
    class LaurentTCP
    {
        private TelnetConnection tc;

        public bool connected = false;
        public bool alive = false;
        // -1 неизвестно
        // 1 высокий\включено
        // 0 низкий\выключено
        public short[] laurent_relay = { -1, -1, -1, -1 };
        public short[] laurent_out = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        public short[] laurent_in = { -1, -1, -1, -1, -1, -1 };
        public float[] laurent_adc = { -1, -1 };
        public LaurentTCP()
        {
            // TODO construct
        }

        public bool connect(string host, int port)
        {
            tc = new TelnetConnection(host, port);
            if (tc.IsConnected)
            {
                connected = true;
                alive = check_controller();
                return true;
            }
            return false;
        }

        private void check_read()
        {
            string str_in = tc.Read();
            str_in = str_in.Trim();

            string[] replies = str_in.Split('\n');
            foreach (string reply_item in replies)
            {
                string reply = "";
                reply_item.Trim();
                // outputs
                if ((reply_item.Length > 3) && (reply_item.Substring(0, 4) == "#RD,"))
                {
                    reply = reply_item.Substring(4, 6);
                    for (int i = 0; i < 6; i++)
                    {
                        if (reply[i] == '0') laurent_in[i] = 0;
                        else if (reply[i] == '1') laurent_in[i] = 1;
                    }
                    return;
                }
                // inputs
                else if ((reply_item.Length > 4) && (reply_item.Substring(0, 5) == "#RID,"))
                {
                    reply = reply_item.Substring(5, 12);
                    for (int i = 0; i < 12; i++)
                    {
                        if (reply[i] == '0') laurent_out[i] = 0;
                        else if (reply[i] == '1') laurent_out[i] = 1;
                    }
                }
                // relay
                if ((reply_item.Length > 4) && (reply_item.Substring(0, 5) == "#RDR,"))
                {
                    int num = int.Parse(reply_item.Substring(5, 1));

                    if (reply_item.Substring(7, 1) == "1")
                    {
                        laurent_relay[num - 1] = 1;
                    }
                    else if (reply_item.Substring(7, 1) == "0")
                    {
                        laurent_relay[num - 1] = 0;
                    }
                }
                // adc
                if ((reply_item.Length > 4) && (reply_item.Substring(0, 5) == "#ADC,"))
                {
                    int num = int.Parse(reply_item.Substring(5, 1));
                    string str_val = reply_item.Substring(7, 5);
                    str_val = str_val.Replace('.', ',');
                    float val = float.Parse(str_val);
                    laurent_adc[num - 1] = val;
                }
                /////////////////
            }
        }

        public void check_relay() {
            check_relay(1);
            check_read();
            check_relay(2);
            check_read();
            check_relay(3);
            check_read();
            check_relay(4);
        }

        public void request_changes()
        {
            if (!alive) alive = check_controller();
            else
            {
                check_output();
                check_read();
                check_input();
                check_read();
                check_adc(1);
                check_adc(2);
                check_relay();
            }
        }
        // return true if OK
        private bool check_controller()
        {
            tc.WriteLine("$KE");
            string reply = tc.Read();
            if (reply.Trim() == "#OK") return true;
            return false;
        }

        //-----------------------------------//
        //              OUTPUTS
        //-----------------------------------//
        // pin==0 - to all pins, 1..12 - to pin
        // value = 0 | 1
        // return true if OK
        public void set_output(short pin, short state)
        {
            // $KE,WR,<OutLine>,<Value>
            string pin_str = "";
            string state_str = "";

            if (pin == 0)
            {
                pin_str = "ALL";
                if (state == 1) state_str = "ON";
                else state_str = "OFF";
            }
            else
            {
                pin_str = pin.ToString();
                state_str = state.ToString();
            }

            tc.WriteLine("$KE,WR," + pin_str + "," + state_str);
        }
        // return true if OK
        public void check_output()
        {
            // запрос: $KE,RID,ALL 
            // ответ: #RID,011001000000 
            tc.WriteLine("$KE,RID,ALL");
        }

        //-----------------------------------//
        //              RELAYS
        //-----------------------------------//
        public void set_relay(short relay, short state)
        {
            //  $KE,REL,<ReleNumber>,<Value> 
            //  #REL,OK  –  значение успешно установлено.
            tc.WriteLine("$KE,REL," + relay.ToString() + "," + state.ToString());
        }
        public void check_relay(int num)
        {
            tc.WriteLine("$KE,RDR," + num.ToString());
            // запрос: Синтаксис:  $KE,RDR,<ReleNumber>
            // #RDR,<ReleNumber>,<State> 
        }
        //-----------------------------------//
        //              INPUTS
        //-----------------------------------//
        public void check_input()
        {
            // запрос: $KE,RD,ALL 
            // ответ: #RD,011001000000 
            tc.WriteLine("$KE,RD,ALL");
        }
        //-----------------------------------//
        //              ADCs
        //-----------------------------------//
        public void check_adc(int num)
        {
            //запрос: $KE,ADC,1
            //ответ: #ADC,3,7.418
            tc.WriteLine("$KE,ADC,"+num.ToString());
        }
    }
}
