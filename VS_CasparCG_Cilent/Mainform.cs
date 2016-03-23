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
    public partial class Mainform : Form
    {
        //variabler som måste existera i mellan metoder
        TcpClient client = null; 
        StreamReader reader;
        StreamWriter writer;

        public Mainform()
        {
            InitializeComponent();
        }

        private void connecta_MouseClick(object sender, MouseEventArgs e)
        {
            string ip = ipadress.Text; //hämta ip-adress från input-ruta
            int ports = Int32.Parse(port.Text); //hämta portnummer från input-ruta

            try { client = new TcpClient(ip, ports); } //skapa connectionen med servern
            catch (Exception ee) { serverstatus.Text = "Kan inte ansluta till " + ip; } //programmet krashar om inte exception:et från misslyckad anslutning hanteras (med catch-block)
            if (client != null) //gör inte detta om den inte lyckades connecta
            {
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());
                serverstatus.Text = "Connectad till " + ip; //skriv ut statusmeddelande
                connecta.Enabled = false;
                disconnect.Enabled = true;
                skicka.Enabled = true;
                bakgrund.Enabled = true;
                rullandetextknapp.Enabled = true;
                rullandetextknappstop.Enabled = true;
            }
        }

        private void skicka_MouseClick(object sender, MouseEventArgs e)
        {
            try { 
                writer.WriteLine(kommando.Text); //skicka kommando från input-ruta till servern
                writer.Flush();
                string reply = reader.ReadLine(); //lyssna på svar från servern
                servermessage.Text = reply;
                kommando.Clear(); //rensa kommando-rutan

                //ifall servern skickar många rader text tillbaka (tror jag, olika returnkoder, taget från färdigt exempel)
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
            catch (Exception ee) { //servern har stängts ner eller tappat connection?
                kommando.Clear();
                client = null;
                connecta.Enabled = true;
                disconnect.Enabled = false;
                skicka.Enabled = false;
                bakgrund.Enabled = false;
                rullandetextknapp.Enabled = false;
                rullandetextknappstop.Enabled = false;
                serverstatus.Text = "Tappade anslutningen till servern";
                servermessage.Text = "";
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
            client = null;
            connecta.Enabled = true;
            disconnect.Enabled = false;
            skicka.Enabled = false;
            bakgrund.Enabled = false;
            rullandetextknapp.Enabled = false;
            rullandetextknappstop.Enabled = false;
            serverstatus.Text = "Disconnectad";
            servermessage.Text = "";
        }

        private void basicCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicCommands form2 = new BasicCommands(); // öppnar "Basick commands form in menu bar"
            form2.Show();


        }

        private void allCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("http://casparcg.com/wiki/CasparCG_2.0_AMCP_Protocol"); // öppnar sida med "all commands"!
        }

        private void howToConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            How_to_connect form3 = new How_to_connect();
            form3.Show();
        }

        private void bakgrund_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                writer.WriteLine("PLAY 1-10 \"VS_BAKGRUND\" CUT 1 Linear RIGHT\r\n"); //skicka kommando från input-ruta till servern
                writer.Flush();
                string reply = reader.ReadLine(); //lyssna på svar från servern
                servermessage.Text = reply;

                //ifall servern skickar många rader text tillbaka (tror jag, olika returnkoder, taget från färdigt exempel)
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
            catch (Exception ee)
            { //servern har stängts ner eller tappat connection?
                client = null;
                connecta.Enabled = true;
                disconnect.Enabled = false;
                skicka.Enabled = false;
                bakgrund.Enabled = false;
                rullandetextknapp.Enabled = false;
                rullandetextknappstop.Enabled = false;
                serverstatus.Text = "Tappade anslutningen till servern";
                servermessage.Text = "";
            }
        }

        private void rullandetextknapp_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                writer.WriteLine("CG 1-20 ADD 1 \"RULLANDETEXT\" 1 \"<templateData><componentData id=\\\"f0\\\"><data id=\\\"text\\\" value=\\\"" + rullandetext.Text + "\\\"/></componentData></templateData>\"\r\n"); //skicka kommando från input-ruta till servern
                writer.Flush();
                string reply = reader.ReadLine(); //lyssna på svar från servern
                servermessage.Text = reply;

                //ifall servern skickar många rader text tillbaka (tror jag, olika returnkoder, taget från färdigt exempel)
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
            catch (Exception ee)
            { //servern har stängts ner eller tappat connection?
                client = null;
                connecta.Enabled = true;
                disconnect.Enabled = false;
                skicka.Enabled = false;
                bakgrund.Enabled = false;
                rullandetextknapp.Enabled = false;
                rullandetextknappstop.Enabled = false;
                serverstatus.Text = "Tappade anslutningen till servern";
                servermessage.Text = "";
            }
        }

        private void rullandetextknappstop_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                writer.WriteLine("CG 1-20 STOP 1\r\n"); //skicka kommando från input-ruta till servern
                writer.Flush();
                string reply = reader.ReadLine(); //lyssna på svar från servern
                servermessage.Text = reply;

                //ifall servern skickar många rader text tillbaka (tror jag, olika returnkoder, taget från färdigt exempel)
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
            catch (Exception ee)
            { //servern har stängts ner eller tappat connection?
                client = null;
                connecta.Enabled = true;
                disconnect.Enabled = false;
                skicka.Enabled = false;
                bakgrund.Enabled = false;
                rullandetextknapp.Enabled = false;
                rullandetextknappstop.Enabled = false;
                serverstatus.Text = "Tappade anslutningen till servern";
                servermessage.Text = "";
            }
        }
    }
}
