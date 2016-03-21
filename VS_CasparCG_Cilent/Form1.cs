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
        //variabler som måste existera imellan metoder
        TcpClient client; 
        StreamReader reader;
        StreamWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void connecta_MouseClick(object sender, MouseEventArgs e)
        {
            string ip = ipadress.Text; //hämta ip-adress från input-ruta
            int ports = Int32.Parse(port.Text); //hämta portnummer från input-ruta

            client = new TcpClient(ip, ports); //skapa connectionen med servern
            reader = new StreamReader(client.GetStream());
            writer = new StreamWriter(client.GetStream());
            serverstatus.Text = "Connectad till " + ip; //skriv ut statusmeddelande
            connecta.Enabled = false;
            disconnect.Enabled = true;
            skicka.Enabled = true;
        }

        private void skicka_MouseClick(object sender, MouseEventArgs e)
        {
            writer.WriteLine(kommando.Text); //skicka kommando från input-ruta till servern
            writer.Flush();
            string reply = reader.ReadLine(); //lyssna på svar från servern
            servermessage.Text = reply;
            kommando.Clear(); //rensa kommando-rutan

            //ifall servern skickar många rader text tillbaka (tror jag)
            if (reply.Contains("201"))
            {
                reply = reader.ReadLine();
                servermessage.Text += "\n" + reply;
            }
            else if (reply.Contains("200"))
            {
                while (reply.Length > 0)
                {
                    reply = reader.ReadLine();
                    servermessage.Text += "\n" + reply;
                }
            }
        }

        private void amcpwiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://casparcg.com/wiki/CasparCG_2.0_AMCP_Protocol"); //öppna hemsida
        }

        private void disconnect_MouseClick(object sender, MouseEventArgs e)
        {
            //koppla ner ordentligt från servern
            client.GetStream().Close();
            client.Close();
            connecta.Enabled = true;
            disconnect.Enabled = false;
            skicka.Enabled = false;
            serverstatus.Text = "";
            servermessage.Text = "";
        }
    }
}
