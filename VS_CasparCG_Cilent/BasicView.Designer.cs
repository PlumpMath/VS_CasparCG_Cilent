namespace VS_CasparCG_Cilent
{
    partial class BasicView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicView));
            this.ipadress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connecta = new System.Windows.Forms.Button();
            this.serverstatus = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.disconnect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kommandoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rullandetextknapp = new System.Windows.Forms.Button();
            this.rullandetext = new System.Windows.Forms.RichTextBox();
            this.bakgrund = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rullandetextknappstop = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.FolderBrowserDialog();
            this.bakgrundslista = new System.Windows.Forms.ListBox();
            this.file = new System.Windows.Forms.Button();
            this.avanceratLägeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipadress
            // 
            this.ipadress.Location = new System.Drawing.Point(63, 72);
            this.ipadress.Name = "ipadress";
            this.ipadress.Size = new System.Drawing.Size(100, 20);
            this.ipadress.TabIndex = 2;
            this.ipadress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP-Adress";
            // 
            // connecta
            // 
            this.connecta.Location = new System.Drawing.Point(37, 141);
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
            this.serverstatus.Location = new System.Drawing.Point(262, 75);
            this.serverstatus.Name = "serverstatus";
            this.serverstatus.Size = new System.Drawing.Size(73, 13);
            this.serverstatus.TabIndex = 7;
            this.serverstatus.Text = "Disconnectad";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(64, 115);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 20);
            this.port.TabIndex = 8;
            this.port.Text = "5250";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Anslutnings Status";
            // 
            // disconnect
            // 
            this.disconnect.Enabled = false;
            this.disconnect.Location = new System.Drawing.Point(118, 141);
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
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kommandoToolStripMenuItem
            // 
            this.kommandoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avanceratLägeToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.kommandoToolStripMenuItem.Name = "kommandoToolStripMenuItem";
            this.kommandoToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.kommandoToolStripMenuItem.Text = "Arkiv";
            // 
            // rullandetextknapp
            // 
            this.rullandetextknapp.Enabled = false;
            this.rullandetextknapp.Location = new System.Drawing.Point(238, 313);
            this.rullandetextknapp.Name = "rullandetextknapp";
            this.rullandetextknapp.Size = new System.Drawing.Size(60, 23);
            this.rullandetextknapp.TabIndex = 17;
            this.rullandetextknapp.Text = "Starta";
            this.rullandetextknapp.UseVisualStyleBackColor = true;
            this.rullandetextknapp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rullandetextknapp_MouseClick);
            // 
            // rullandetext
            // 
            this.rullandetext.Location = new System.Drawing.Point(227, 250);
            this.rullandetext.Name = "rullandetext";
            this.rullandetext.Size = new System.Drawing.Size(167, 57);
            this.rullandetext.TabIndex = 18;
            this.rullandetext.Text = "";
            // 
            // bakgrund
            // 
            this.bakgrund.Enabled = false;
            this.bakgrund.Location = new System.Drawing.Point(62, 313);
            this.bakgrund.Name = "bakgrund";
            this.bakgrund.Size = new System.Drawing.Size(103, 23);
            this.bakgrund.TabIndex = 19;
            this.bakgrund.Text = "välj bakgrundbild";
            this.bakgrund.UseVisualStyleBackColor = true;
            this.bakgrund.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bakgrund_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rullande textmeddelande";
            // 
            // rullandetextknappstop
            // 
            this.rullandetextknappstop.Enabled = false;
            this.rullandetextknappstop.Location = new System.Drawing.Point(304, 313);
            this.rullandetextknappstop.Name = "rullandetextknappstop";
            this.rullandetextknappstop.Size = new System.Drawing.Size(75, 23);
            this.rullandetextknappstop.TabIndex = 21;
            this.rullandetextknappstop.Text = "Stoppa";
            this.rullandetextknappstop.UseVisualStyleBackColor = true;
            this.rullandetextknappstop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rullandetextknappstop_MouseClick);
            // 
            // bakgrundslista
            // 
            this.bakgrundslista.FormattingEnabled = true;
            this.bakgrundslista.Location = new System.Drawing.Point(54, 251);
            this.bakgrundslista.Name = "bakgrundslista";
            this.bakgrundslista.Size = new System.Drawing.Size(126, 56);
            this.bakgrundslista.TabIndex = 22;
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(71, 219);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(75, 23);
            this.file.TabIndex = 23;
            this.file.Text = "File";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // avanceratLägeToolStripMenuItem
            // 
            this.avanceratLägeToolStripMenuItem.Name = "avanceratLägeToolStripMenuItem";
            this.avanceratLägeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.avanceratLägeToolStripMenuItem.Text = "Avancerat läge";
            this.avanceratLägeToolStripMenuItem.Click += new System.EventHandler(this.avanceratLägeToolStripMenuItem_Click);
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hjälpToolStripMenuItem.Text = "Hjälp";
            this.hjälpToolStripMenuItem.Click += new System.EventHandler(this.hjälpToolStripMenuItem_Click);
            // 
            // BasicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 377);
            this.Controls.Add(this.file);
            this.Controls.Add(this.bakgrundslista);
            this.Controls.Add(this.rullandetextknappstop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bakgrund);
            this.Controls.Add(this.rullandetext);
            this.Controls.Add(this.rullandetextknapp);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.port);
            this.Controls.Add(this.serverstatus);
            this.Controls.Add(this.connecta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipadress);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BasicView";
            this.Text = "Viskastrand CasparCG Client v1.0";
            this.Load += new System.EventHandler(this.BasicView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ipadress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connecta;
        private System.Windows.Forms.Label serverstatus;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kommandoToolStripMenuItem;
        private System.Windows.Forms.Button rullandetextknapp;
        private System.Windows.Forms.RichTextBox rullandetext;
        private System.Windows.Forms.Button bakgrund;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rullandetextknappstop;
        private System.Windows.Forms.FolderBrowserDialog openFD;
        private System.Windows.Forms.ListBox bakgrundslista;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.ToolStripMenuItem avanceratLägeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
    }
}

