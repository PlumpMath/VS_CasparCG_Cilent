namespace VS_CasparCG_Cilent
{
    partial class AdvancedView
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
            this.file = new System.Windows.Forms.Button();
            this.bakgrundslista = new System.Windows.Forms.ListBox();
            this.rullandetextknappstop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bakgrund = new System.Windows.Forms.Button();
            this.rullandetext = new System.Windows.Forms.RichTextBox();
            this.rullandetextknapp = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.servermessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.serverstatus = new System.Windows.Forms.Label();
            this.connecta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ipadress = new System.Windows.Forms.TextBox();
            this.kommando = new System.Windows.Forms.TextBox();
            this.skicka = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allaCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanceradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(53, 222);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(75, 23);
            this.file.TabIndex = 43;
            this.file.Text = "File";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // bakgrundslista
            // 
            this.bakgrundslista.FormattingEnabled = true;
            this.bakgrundslista.Location = new System.Drawing.Point(36, 254);
            this.bakgrundslista.Name = "bakgrundslista";
            this.bakgrundslista.Size = new System.Drawing.Size(126, 56);
            this.bakgrundslista.TabIndex = 42;
            // 
            // rullandetextknappstop
            // 
            this.rullandetextknappstop.Enabled = false;
            this.rullandetextknappstop.Location = new System.Drawing.Point(327, 316);
            this.rullandetextknappstop.Name = "rullandetextknappstop";
            this.rullandetextknappstop.Size = new System.Drawing.Size(75, 23);
            this.rullandetextknappstop.TabIndex = 41;
            this.rullandetextknappstop.Text = "Stoppa";
            this.rullandetextknappstop.UseVisualStyleBackColor = true;
            this.rullandetextknappstop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rullandetextknappstop_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Rullande textmeddelande";
            // 
            // bakgrund
            // 
            this.bakgrund.Enabled = false;
            this.bakgrund.Location = new System.Drawing.Point(44, 316);
            this.bakgrund.Name = "bakgrund";
            this.bakgrund.Size = new System.Drawing.Size(103, 23);
            this.bakgrund.TabIndex = 39;
            this.bakgrund.Text = "välj bakgrundbild";
            this.bakgrund.UseVisualStyleBackColor = true;
            this.bakgrund.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bakgrund_MouseClick);
            // 
            // rullandetext
            // 
            this.rullandetext.Location = new System.Drawing.Point(250, 253);
            this.rullandetext.Name = "rullandetext";
            this.rullandetext.Size = new System.Drawing.Size(167, 57);
            this.rullandetext.TabIndex = 38;
            this.rullandetext.Text = "";
            // 
            // rullandetextknapp
            // 
            this.rullandetextknapp.Enabled = false;
            this.rullandetextknapp.Location = new System.Drawing.Point(261, 316);
            this.rullandetextknapp.Name = "rullandetextknapp";
            this.rullandetextknapp.Size = new System.Drawing.Size(60, 23);
            this.rullandetextknapp.TabIndex = 37;
            this.rullandetextknapp.Text = "Starta";
            this.rullandetextknapp.UseVisualStyleBackColor = true;
            this.rullandetextknapp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rullandetextknapp_MouseClick);
            // 
            // disconnect
            // 
            this.disconnect.Enabled = false;
            this.disconnect.Location = new System.Drawing.Point(100, 121);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(75, 23);
            this.disconnect.TabIndex = 36;
            this.disconnect.Text = "Disconnecta";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.disconnect_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Server-svar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Connection status";
            // 
            // servermessage
            // 
            this.servermessage.AutoSize = true;
            this.servermessage.Location = new System.Drawing.Point(247, 123);
            this.servermessage.Name = "servermessage";
            this.servermessage.Size = new System.Drawing.Size(0, 13);
            this.servermessage.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Port";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(46, 95);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 20);
            this.port.TabIndex = 31;
            this.port.Text = "5250";
            // 
            // serverstatus
            // 
            this.serverstatus.AutoSize = true;
            this.serverstatus.Location = new System.Drawing.Point(241, 54);
            this.serverstatus.Name = "serverstatus";
            this.serverstatus.Size = new System.Drawing.Size(73, 13);
            this.serverstatus.TabIndex = 30;
            this.serverstatus.Text = "Disconnectad";
            // 
            // connecta
            // 
            this.connecta.Location = new System.Drawing.Point(19, 121);
            this.connecta.Name = "connecta";
            this.connecta.Size = new System.Drawing.Size(75, 23);
            this.connecta.TabIndex = 29;
            this.connecta.Text = "Connecta";
            this.connecta.UseVisualStyleBackColor = true;
            this.connecta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connecta_MouseClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "AMCP-Commando*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "IP-Adress";
            // 
            // ipadress
            // 
            this.ipadress.Location = new System.Drawing.Point(45, 52);
            this.ipadress.Name = "ipadress";
            this.ipadress.Size = new System.Drawing.Size(100, 20);
            this.ipadress.TabIndex = 26;
            this.ipadress.Text = "127.0.0.1";
            // 
            // kommando
            // 
            this.kommando.Location = new System.Drawing.Point(155, 399);
            this.kommando.Name = "kommando";
            this.kommando.Size = new System.Drawing.Size(100, 20);
            this.kommando.TabIndex = 25;
            // 
            // skicka
            // 
            this.skicka.Enabled = false;
            this.skicka.Location = new System.Drawing.Point(166, 424);
            this.skicka.Name = "skicka";
            this.skicka.Size = new System.Drawing.Size(75, 23);
            this.skicka.TabIndex = 24;
            this.skicka.Text = "Skicka";
            this.skicka.UseVisualStyleBackColor = true;
            this.skicka.MouseClick += new System.Windows.Forms.MouseEventHandler(this.skicka_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arToolStripMenuItem
            // 
            this.arToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basiToolStripMenuItem,
            this.allaCommandsToolStripMenuItem,
            this.avanceradToolStripMenuItem,
            this.hToolStripMenuItem});
            this.arToolStripMenuItem.Name = "arToolStripMenuItem";
            this.arToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arToolStripMenuItem.Text = "Arkiv";
            // 
            // basiToolStripMenuItem
            // 
            this.basiToolStripMenuItem.Name = "basiToolStripMenuItem";
            this.basiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.basiToolStripMenuItem.Text = "Basic Commands";
            // 
            // allaCommandsToolStripMenuItem
            // 
            this.allaCommandsToolStripMenuItem.Name = "allaCommandsToolStripMenuItem";
            this.allaCommandsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.allaCommandsToolStripMenuItem.Text = "Alla Commands";
            // 
            // avanceradToolStripMenuItem
            // 
            this.avanceradToolStripMenuItem.Name = "avanceradToolStripMenuItem";
            this.avanceradToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.avanceradToolStripMenuItem.Text = "Avancerat läge";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hToolStripMenuItem.Text = "Hjälp";
            // 
            // AdvancedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 476);
            this.Controls.Add(this.file);
            this.Controls.Add(this.bakgrundslista);
            this.Controls.Add(this.rullandetextknappstop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bakgrund);
            this.Controls.Add(this.rullandetext);
            this.Controls.Add(this.rullandetextknapp);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.servermessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.port);
            this.Controls.Add(this.serverstatus);
            this.Controls.Add(this.connecta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipadress);
            this.Controls.Add(this.kommando);
            this.Controls.Add(this.skicka);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdvancedView";
            this.Text = "AdvancedView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button file;
        private System.Windows.Forms.ListBox bakgrundslista;
        private System.Windows.Forms.Button rullandetextknappstop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bakgrund;
        private System.Windows.Forms.RichTextBox rullandetext;
        private System.Windows.Forms.Button rullandetextknapp;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label servermessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label serverstatus;
        private System.Windows.Forms.Button connecta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipadress;
        private System.Windows.Forms.TextBox kommando;
        private System.Windows.Forms.Button skicka;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allaCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanceradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
    }
}