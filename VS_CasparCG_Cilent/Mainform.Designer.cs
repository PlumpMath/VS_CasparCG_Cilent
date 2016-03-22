namespace VS_CasparCG_Cilent
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.skicka = new System.Windows.Forms.Button();
            this.kommando = new System.Windows.Forms.TextBox();
            this.ipadress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connecta = new System.Windows.Forms.Button();
            this.serverstatus = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.servermessage = new System.Windows.Forms.Label();
            this.amcpwiki = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.disconnect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kommandoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skicka
            // 
            this.skicka.Enabled = false;
            this.skicka.Location = new System.Drawing.Point(128, 232);
            this.skicka.Name = "skicka";
            this.skicka.Size = new System.Drawing.Size(75, 23);
            this.skicka.TabIndex = 0;
            this.skicka.Text = "Skicka";
            this.skicka.UseVisualStyleBackColor = true;
            this.skicka.MouseClick += new System.Windows.Forms.MouseEventHandler(this.skicka_MouseClick);
            // 
            // kommando
            // 
            this.kommando.Location = new System.Drawing.Point(117, 207);
            this.kommando.Name = "kommando";
            this.kommando.Size = new System.Drawing.Size(100, 20);
            this.kommando.TabIndex = 1;
            // 
            // ipadress
            // 
            this.ipadress.Location = new System.Drawing.Point(203, 71);
            this.ipadress.Name = "ipadress";
            this.ipadress.Size = new System.Drawing.Size(100, 20);
            this.ipadress.TabIndex = 2;
            this.ipadress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP-Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AMCP-Commando*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Skicka kommandon till en CasparCG-server med TCP";
            // 
            // connecta
            // 
            this.connecta.Location = new System.Drawing.Point(177, 140);
            this.connecta.Name = "connecta";
            this.connecta.Size = new System.Drawing.Size(75, 23);
            this.connecta.TabIndex = 6;
            this.connecta.Text = "Connecta";
            this.connecta.UseVisualStyleBackColor = true;
            this.connecta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connecta_MouseClick);
            // 
            // serverstatus
            // 
            this.serverstatus.AutoSize = true;
            this.serverstatus.Location = new System.Drawing.Point(9, 94);
            this.serverstatus.Name = "serverstatus";
            this.serverstatus.Size = new System.Drawing.Size(73, 13);
            this.serverstatus.TabIndex = 7;
            this.serverstatus.Text = "Disconnectad";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(204, 114);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 20);
            this.port.TabIndex = 8;
            this.port.Text = "5250";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port";
            // 
            // servermessage
            // 
            this.servermessage.AutoSize = true;
            this.servermessage.Location = new System.Drawing.Point(29, 156);
            this.servermessage.Name = "servermessage";
            this.servermessage.Size = new System.Drawing.Size(0, 13);
            this.servermessage.TabIndex = 10;
            // 
            // amcpwiki
            // 
            this.amcpwiki.AutoSize = true;
            this.amcpwiki.Location = new System.Drawing.Point(114, 270);
            this.amcpwiki.Name = "amcpwiki";
            this.amcpwiki.Size = new System.Drawing.Size(109, 13);
            this.amcpwiki.TabIndex = 11;
            this.amcpwiki.TabStop = true;
            this.amcpwiki.Text = "CasparCG AMCP-wiki";
            this.amcpwiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.amcpwiki_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "*Advanced Media Control Protocol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Connection status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Server-svar";
            // 
            // disconnect
            // 
            this.disconnect.Enabled = false;
            this.disconnect.Location = new System.Drawing.Point(258, 140);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(75, 23);
            this.disconnect.TabIndex = 15;
            this.disconnect.Text = "Disconnecta";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.disconnect_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kommandoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kommandoToolStripMenuItem
            // 
            this.kommandoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicCommandsToolStripMenuItem,
            this.allCommandsToolStripMenuItem,
            this.howToConnectToolStripMenuItem});
            this.kommandoToolStripMenuItem.Name = "kommandoToolStripMenuItem";
            this.kommandoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.kommandoToolStripMenuItem.Text = "Commando";
            // 
            // basicCommandsToolStripMenuItem
            // 
            this.basicCommandsToolStripMenuItem.Name = "basicCommandsToolStripMenuItem";
            this.basicCommandsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.basicCommandsToolStripMenuItem.Text = "Basic Commands";
            this.basicCommandsToolStripMenuItem.Click += new System.EventHandler(this.basicCommandsToolStripMenuItem_Click);
            // 
            // allCommandsToolStripMenuItem
            // 
            this.allCommandsToolStripMenuItem.Name = "allCommandsToolStripMenuItem";
            this.allCommandsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.allCommandsToolStripMenuItem.Text = "All Commands";
            this.allCommandsToolStripMenuItem.Click += new System.EventHandler(this.allCommandsToolStripMenuItem_Click);
            // 
            // howToConnectToolStripMenuItem
            // 
            this.howToConnectToolStripMenuItem.Name = "howToConnectToolStripMenuItem";
            this.howToConnectToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.howToConnectToolStripMenuItem.Text = "How to connect";
            this.howToConnectToolStripMenuItem.Click += new System.EventHandler(this.howToConnectToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 481);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amcpwiki);
            this.Controls.Add(this.servermessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.port);
            this.Controls.Add(this.serverstatus);
            this.Controls.Add(this.connecta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipadress);
            this.Controls.Add(this.kommando);
            this.Controls.Add(this.skicka);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Viskastrand CasparCG Client v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button skicka;
        private System.Windows.Forms.TextBox kommando;
        private System.Windows.Forms.TextBox ipadress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connecta;
        private System.Windows.Forms.Label serverstatus;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label servermessage;
        private System.Windows.Forms.LinkLabel amcpwiki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kommandoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToConnectToolStripMenuItem;
    }
}

