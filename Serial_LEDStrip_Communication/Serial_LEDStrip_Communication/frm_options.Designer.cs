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
            this.label1 = new System.Windows.Forms.Label();
            this.tbar_brightness = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_numStripes = new System.Windows.Forms.ComboBox();
            this.gbox_stripes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_brightness)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anzahl der verbundenen Stripes:";
            // 
            // gbox_stripes
            // 
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
            this.gbox_stripes.Size = new System.Drawing.Size(713, 309);
            this.gbox_stripes.TabIndex = 2;
            this.gbox_stripes.TabStop = false;
            this.gbox_stripes.Text = "Einstellungen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Helligkeit der Stripes:";
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
            // cbox_numStripes
            // 
            this.cbox_numStripes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbox_numStripes.DisplayMember = "1";
            this.cbox_numStripes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_numStripes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_numStripes.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_numStripes.FormattingEnabled = true;
            this.cbox_numStripes.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "12",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbox_numStripes.Location = new System.Drawing.Point(490, 103);
            this.cbox_numStripes.Name = "cbox_numStripes";
            this.cbox_numStripes.Size = new System.Drawing.Size(121, 40);
            this.cbox_numStripes.TabIndex = 2;
            this.cbox_numStripes.SelectedIndexChanged += new System.EventHandler(this.cbox_numStripes_SelectedIndexChanged);
            // 
            // frm_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 333);
            this.Controls.Add(this.gbox_stripes);
            this.Name = "frm_options";
            this.Text = "Options";
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
    }
}