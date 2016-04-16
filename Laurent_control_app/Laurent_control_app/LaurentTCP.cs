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
                return true;
            }
            return false;
        }

        // $KE
        // return true if OK
        public bool check_controller()
        {
            tc.WriteLine("$KE");
            // TODO check #OK
            return true;
        }

        // $KE,WR,<OutLine>,<Value>
        // pin==0 - to all pins, 1..6 - to pin
        // value = 0 | 1
        // return true if OK
        public bool set_output(short pin, short state)
        {
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
            // TODO check #WR,OK
            return true;
        }

        // $KE,WRA,<ArrayOfValues>
        //
        // return true if OK
        public bool set_output_array()
        {
            tc.WriteLine("$KE");
            // TODO check #OK
            return true;
        }
    }
}
