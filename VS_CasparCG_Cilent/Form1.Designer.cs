namespace VS_CasparCG_Cilent
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.kommando = new System.Windows.Forms.TextBox();
            this.ipadress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.serverstatus = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.servermessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Skicka Telnet-kommando";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // kommando
            // 
            this.kommando.Location = new System.Drawing.Point(117, 248);
            this.kommando.Name = "kommando";
            this.kommando.Size = new System.Drawing.Size(100, 20);
            this.kommando.TabIndex = 1;
            // 
            // ipadress
            // 
            this.ipadress.Location = new System.Drawing.Point(189, 98);
            this.ipadress.Name = "ipadress";
            this.ipadress.Size = new System.Drawing.Size(100, 20);
            this.ipadress.TabIndex = 2;
            this.ipadress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP-Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kommando";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Skicka kommando med Telnet till en CasparCG-server";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // serverstatus
            // 
            this.serverstatus.AutoSize = true;
            this.serverstatus.Location = new System.Drawing.Point(39, 123);
            this.serverstatus.Name = "serverstatus";
            this.serverstatus.Size = new System.Drawing.Size(94, 13);
            this.serverstatus.TabIndex = 7;
            this.serverstatus.Text = " Not disconnected";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(190, 141);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 20);
            this.port.TabIndex = 8;
            this.port.Text = "5250";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port";
            // 
            // servermessage
            // 
            this.servermessage.AutoSize = true;
            this.servermessage.Location = new System.Drawing.Point(51, 186);
            this.servermessage.Name = "servermessage";
            this.servermessage.Size = new System.Drawing.Size(0, 13);
            this.servermessage.TabIndex = 10;
            this.servermessage.Click += new System.EventHandler(this.servermessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 339);
            this.Controls.Add(this.servermessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.port);
            this.Controls.Add(this.serverstatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipadress);
            this.Controls.Add(this.kommando);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "VS CasparCG Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kommando;
        private System.Windows.Forms.TextBox ipadress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label serverstatus;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label servermessage;
    }
}

