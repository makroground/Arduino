namespace Serial_LEDStrip_Communication
{
    partial class frm_options
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
            this.label2 = new System.Windows.Forms.Label();
            this.gbox_stripes = new System.Windows.Forms.GroupBox();
            this.lbl_comport = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_ports = new System.Windows.Forms.ComboBox();
            this.cbox_numStripes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbar_brightness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbox_stripes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_brightness)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anzahl der verbundenen Stripes:";
            // 
            // gbox_stripes
            // 
            this.gbox_stripes.Controls.Add(this.lbl_comport);
            this.gbox_stripes.Controls.Add(this.btn_close);
            this.gbox_stripes.Controls.Add(this.btn_init);
            this.gbox_stripes.Controls.Add(this.label7);
            this.gbox_stripes.Controls.Add(this.cbox_ports);
            this.gbox_stripes.Controls.Add(this.cbox_numStripes);
            this.gbox_stripes.Controls.Add(this.label6);
            this.gbox_stripes.Controls.Add(this.label5);
            this.gbox_stripes.Controls.Add(this.label4);
            this.gbox_stripes.Controls.Add(this.tbar_brightness);
            this.gbox_stripes.Controls.Add(this.label1);
            this.gbox_stripes.Controls.Add(this.label2);
            this.gbox_stripes.Controls.Add(this.label3);
            this.gbox_stripes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_stripes.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.gbox_stripes.Location = new System.Drawing.Point(12, 12);
            this.gbox_stripes.Name = "gbox_stripes";
            this.gbox_stripes.Size = new System.Drawing.Size(713, 363);
            this.gbox_stripes.TabIndex = 2;
            this.gbox_stripes.TabStop = false;
            this.gbox_stripes.Text = "Einstellungen";
            // 
            // lbl_comport
            // 
            this.lbl_comport.AutoSize = true;
            this.lbl_comport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comport.Location = new System.Drawing.Point(205, 287);
            this.lbl_comport.Name = "lbl_comport";
            this.lbl_comport.Size = new System.Drawing.Size(133, 32);
            this.lbl_comport.TabIndex = 14;
            this.lbl_comport.Text = "NoPortSet";
            this.lbl_comport.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(565, 282);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 45);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "Trennen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_init
            // 
            this.btn_init.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_init.Location = new System.Drawing.Point(430, 282);
            this.btn_init.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(127, 45);
            this.btn_init.TabIndex = 12;
            this.btn_init.Text = "Verbinden";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "COM Port";
            // 
            // cbox_ports
            // 
            this.cbox_ports.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_ports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_ports.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_ports.FormattingEnabled = true;
            this.cbox_ports.Location = new System.Drawing.Point(194, 284);
            this.cbox_ports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbox_ports.Name = "cbox_ports";
            this.cbox_ports.Size = new System.Drawing.Size(163, 40);
            this.cbox_ports.TabIndex = 10;
            // 
            // cbox_numStripes
            // 
            this.cbox_numStripes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbox_numStripes.DisplayMember = "1";
            this.cbox_numStripes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_numStripes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_numStripes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_numStripes.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_numStripes.FormattingEnabled = true;
            this.cbox_numStripes.Location = new System.Drawing.Point(490, 103);
            this.cbox_numStripes.Name = "cbox_numStripes";
            this.cbox_numStripes.Size = new System.Drawing.Size(121, 40);
            this.cbox_numStripes.TabIndex = 2;
            this.cbox_numStripes.SelectedIndexChanged += new System.EventHandler(this.cbox_numStripes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "50%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "75%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "100%";
            // 
            // tbar_brightness
            // 
            this.tbar_brightness.Location = new System.Drawing.Point(385, 169);
            this.tbar_brightness.Maximum = 100;
            this.tbar_brightness.Minimum = 20;
            this.tbar_brightness.Name = "tbar_brightness";
            this.tbar_brightness.Size = new System.Drawing.Size(244, 69);
            this.tbar_brightness.TabIndex = 4;
            this.tbar_brightness.Value = 75;
            this.tbar_brightness.ValueChanged += new System.EventHandler(this.tbar_brightness_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Helligkeit der Stripes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "20%";
            // 
            // frm_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 387);
            this.Controls.Add(this.gbox_stripes);
            this.Name = "frm_options";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_options_FormClosed);
            this.Load += new System.EventHandler(this.frm_options_Load);
            this.gbox_stripes.ResumeLayout(false);
            this.gbox_stripes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_brightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbox_stripes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbar_brightness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_numStripes;
        internal System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Button btn_init;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cbox_ports;
        private System.Windows.Forms.Label lbl_comport;
    }
}