﻿namespace Serial_LEDStrip_Communication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btn_send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbox_control = new System.Windows.Forms.GroupBox();
            this.lbl_statusCon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_setAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lecColor = new System.Windows.Forms.TextBox();
            this.cbox_numStripes = new System.Windows.Forms.ComboBox();
            this.gbox_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(0, 0);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wähle den Stripe zur Konfiguration aus:";
            // 
            // gbox_control
            // 
            this.gbox_control.Controls.Add(this.lbl_statusCon);
            this.gbox_control.Controls.Add(this.label1);
            this.gbox_control.Controls.Add(this.btn_settings);
            this.gbox_control.Controls.Add(this.btn_setAll);
            this.gbox_control.Controls.Add(this.label3);
            this.gbox_control.Controls.Add(this.txt_lecColor);
            this.gbox_control.Controls.Add(this.cbox_numStripes);
            this.gbox_control.Controls.Add(this.label2);
            this.gbox_control.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_control.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.gbox_control.Location = new System.Drawing.Point(12, 12);
            this.gbox_control.Name = "gbox_control";
            this.gbox_control.Size = new System.Drawing.Size(798, 391);
            this.gbox_control.TabIndex = 11;
            this.gbox_control.TabStop = false;
            this.gbox_control.Text = "Kontrollcenter";
            // 
            // lbl_statusCon
            // 
            this.lbl_statusCon.AutoSize = true;
            this.lbl_statusCon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statusCon.Location = new System.Drawing.Point(108, 350);
            this.lbl_statusCon.Name = "lbl_statusCon";
            this.lbl_statusCon.Size = new System.Drawing.Size(167, 28);
            this.lbl_statusCon.TabIndex = 16;
            this.lbl_statusCon.Text = "nicht verbunden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Status: ";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(728, 37);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(50, 50);
            this.btn_settings.TabIndex = 14;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_setAll
            // 
            this.btn_setAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_setAll.FlatAppearance.BorderSize = 0;
            this.btn_setAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setAll.Location = new System.Drawing.Point(620, 324);
            this.btn_setAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_setAll.Name = "btn_setAll";
            this.btn_setAll.Size = new System.Drawing.Size(158, 45);
            this.btn_setAll.TabIndex = 12;
            this.btn_setAll.Text = "Übernehmen";
            this.btn_setAll.UseVisualStyleBackColor = false;
            this.btn_setAll.Click += new System.EventHandler(this.btn_setAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gib die Farbe als RGB Farbcode an:";
            // 
            // txt_lecColor
            // 
            this.txt_lecColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_lecColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lecColor.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_lecColor.Location = new System.Drawing.Point(546, 190);
            this.txt_lecColor.Name = "txt_lecColor";
            this.txt_lecColor.Size = new System.Drawing.Size(168, 39);
            this.txt_lecColor.TabIndex = 12;
            this.txt_lecColor.Text = "255255255";
            this.txt_lecColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbox_numStripes
            // 
            this.cbox_numStripes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbox_numStripes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_numStripes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_numStripes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_numStripes.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_numStripes.FormattingEnabled = true;
            this.cbox_numStripes.Location = new System.Drawing.Point(546, 111);
            this.cbox_numStripes.Name = "cbox_numStripes";
            this.cbox_numStripes.Size = new System.Drawing.Size(168, 40);
            this.cbox_numStripes.TabIndex = 11;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 415);
            this.Controls.Add(this.gbox_control);
            this.Controls.Add(this.btn_send);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_main";
            this.Text = "LED Stripes Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_control.ResumeLayout(false);
            this.gbox_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbox_control;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lecColor;
        private System.Windows.Forms.ComboBox cbox_numStripes;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_setAll;
        private System.Windows.Forms.Label lbl_statusCon;
        private System.Windows.Forms.Label label1;
    }
}

