namespace Serial_LEDStrip_Communication
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbox_ports = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbox_control = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbox_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 320);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "255255255";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 389);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "255255255";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 458);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "255255255";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 523);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 26);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "255255255";
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(370, 408);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(153, 35);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Setze Farben";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 582);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 20);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "COM Port";
            // 
            // cbox_ports
            // 
            this.cbox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ports.FormattingEnabled = true;
            this.cbox_ports.Location = new System.Drawing.Point(108, 577);
            this.cbox_ports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbox_ports.Name = "cbox_ports";
            this.cbox_ports.Size = new System.Drawing.Size(180, 28);
            this.cbox_ports.TabIndex = 6;
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(420, 574);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 35);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Trennen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_init
            // 
            this.btn_init.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_init.Location = new System.Drawing.Point(298, 574);
            this.btn_init.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(112, 35);
            this.btn_init.TabIndex = 8;
            this.btn_init.Text = "Verbinden";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wähle den Stripe zur Konfiguration aus:";
            // 
            // gbox_control
            // 
            this.gbox_control.Controls.Add(this.label3);
            this.gbox_control.Controls.Add(this.textBox5);
            this.gbox_control.Controls.Add(this.comboBox1);
            this.gbox_control.Controls.Add(this.label2);
            this.gbox_control.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_control.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.gbox_control.Location = new System.Drawing.Point(12, 12);
            this.gbox_control.Name = "gbox_control";
            this.gbox_control.Size = new System.Drawing.Size(798, 288);
            this.gbox_control.TabIndex = 11;
            this.gbox_control.TabStop = false;
            this.gbox_control.Text = "Kontrollcenter";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(559, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 40);
            this.comboBox1.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox5.Location = new System.Drawing.Point(559, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 39);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "255255255";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gib die Farbe als RGB Farbcode an:";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 631);
            this.Controls.Add(this.gbox_control);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbox_ports);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_main";
            this.Text = "LED Stripes Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_control.ResumeLayout(false);
            this.gbox_control.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_send;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbox_ports;
        private System.IO.Ports.SerialPort serialPort1;
        internal System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbox_control;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

