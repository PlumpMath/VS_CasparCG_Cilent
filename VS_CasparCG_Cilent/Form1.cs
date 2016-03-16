using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace VS_CasparCG_Cilent
{
    public partial class Form1 : Form
    {
        Socket s;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

            string ip = ipadress.Text;
            int ports = Int32.Parse(port.Text);

            IPAddress[] IPs = Dns.GetHostAddresses(ip);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(IPs[0], ports);
            serverstatus.Text = "Connected to server\n" + ip + "\n" + ports;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
             byte[] command = Encoding.ASCII.GetBytes(kommando.Text);
             s.Send(command);
            kommando.Clear();
             byte[] buffer = new byte[50];
             s.Receive(buffer);
             servermessage.Text = (Encoding.ASCII.GetString(buffer));
        }

        private void servermessage_Click(object sender, EventArgs e)
        {

        }
    }
}
