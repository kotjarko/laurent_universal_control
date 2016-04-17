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

        public void request_changes()
        {
            alive = check_controller();
            check_output();
            check_input();
            check_relay(1);
            check_relay(2);
            check_relay(3);
            check_relay(4);
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
        public bool set_output(short pin, short state)
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

            string reply = tc.Read();
            if ((pin == 0) && (reply.Trim() == "#WR,ALL,OK"))
            {
                for(int i = 0; i<laurent_out.Length; i++)
                {
                    laurent_out[i] = state;
                }
                return true;
            }
            else if ((pin != 0) && (reply.Trim() == "#WR,OK"))
            {
                laurent_out[pin - 1] = state;
                return true;
            }
            return false;
        }
        // TODO or REMOVE
        public bool set_output_array()
        {
            // $KE,WRA,<ArrayOfValues>
            //
            // return true if OK
            return true;
        }
        // return true if OK
        public bool check_output()
        {
            // запрос: $KE,RID,ALL 
            // ответ: #RID,011001000000 
            tc.WriteLine("$KE,RID,ALL");
            string reply = tc.Read();
            reply = reply.Trim();
            if (reply.Substring(0, 5) == "#RID,")
            {
                reply = reply.Substring(5, 12);
                for(int i = 0; i<12; i++)
                {
                    if (reply[i] == '0') laurent_out[i] = 0;
                    else if (reply[i] == '1') laurent_out[i] = 1;
                    // TODO else error
                }
                return true;
            }
            return false;
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
        public bool check_relay(int num)
        {
            tc.WriteLine("$KE,RDR," + num.ToString());
            // запрос: Синтаксис:  $KE,RDR,<ReleNumber>
            // #RDR,<ReleNumber>,<State> 

            string reply = tc.Read();
            reply = reply.Trim();
            string check_str = "#RDR," + num.ToString();
            if (reply.Substring(0, 6) == check_str.Trim())
            {
                if(reply.Substring(7, 1) == "1")
                {
                    laurent_relay[num - 1] = 1;
                    return true;
                }
                else if (reply.Substring(7, 1) == "0")
                {
                    laurent_relay[num - 1] = 0;
                    return true;
                }
            }
            return false;
        }
        //-----------------------------------//
        //              INPUTS
        //-----------------------------------//
        public bool check_input()
        {
            // запрос: $KE,RD,ALL 
            // ответ: #RD,011001000000 
            tc.WriteLine("$KE,RD,ALL");
            string reply = tc.Read();
            reply = reply.Trim();
            if (reply.Substring(0, 4) == "#RD,")
            {
                reply = reply.Substring(4, 6);
                for (int i = 0; i < 6; i++)
                {
                    if (reply[i] == '0') laurent_in[i] = 0;
                    else if (reply[i] == '1') laurent_in[i] = 1;
                    // TODO else error
                }
                return true;
            }
            return false;
        }
    }
}
