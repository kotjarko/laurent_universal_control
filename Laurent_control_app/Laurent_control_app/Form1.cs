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

namespace Laurent_control_app
{
    public partial class Form1 : Form
    {
        private Connection laurent1;
        private Telnet.TelnetClient client1 = new Telnet.TelnetClient();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            laurent1 = new Connection("192.168.0.101", 2424);
            if (laurent1.connect())
            {
                laurent1.send("$KE\r\n");
                label1.Text += laurent1.read();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (laurent1.connect())
            {
                label1.Text += laurent1.read();
            }
        }
    }

    public class Connection
    {
        private int port;
        private string address;

        private TcpClient client;
        private NetworkStream stream;
        private BinaryReader reader;
        private BinaryWriter writer;

        public bool is_connected = false;

        public Connection(string _address, int _port)
        {
            address = _address;
            port = _port;
        }

        public bool connect()
        {
            client = new TcpClient(address, port);
            is_connected = client.Connected;
            if (!is_connected) return false;
            stream = client.GetStream();
            reader = new BinaryReader(stream);
            writer = new BinaryWriter(stream);
            return true;
        }

        public void send(string str)
        {
            if (!is_connected) return;
            writer.Write(str);
        }

        public string read()
        {
            if (!is_connected) return "";
            return reader.ReadString();
        }
    }
}
