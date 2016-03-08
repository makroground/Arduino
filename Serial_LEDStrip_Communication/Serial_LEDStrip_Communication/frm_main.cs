using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_LEDStrip_Communication
{
    public partial class frm_main : Form
    {

        public static SerialPort serialPort1 = new SerialPort();

        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Neuladen der Form
            loadFormFill();
        }

        private void loadFormFill()
        {
            // Anzahl der eingestellten Stripes laden
            cbox_numStripes.Items.Clear();
            for (int i = 0; i < Properties.Settings.Default.numStripes; i++)
            {
                int numStrip = i + 1;
                cbox_numStripes.Items.Add("Strip " + numStrip);
            }

            // Status der Verbindung zum µController feststellen
            if (Properties.Settings.Default.COMsaved)
            {
                if (serialPort1.IsOpen)
                {
                    lbl_statusCon.Text = Properties.Settings.Default.lastCom + " verbunden";
                    btn_setAll.Enabled = true;
                }
                else
                {
                    try
                    {
                        serialPort1.PortName = Properties.Settings.Default.lastCom;
                        serialPort1.BaudRate = 115200;
                        serialPort1.Open();

                        lbl_statusCon.Text = Properties.Settings.Default.lastCom + " verbunden";
                        btn_setAll.Enabled = true;
                    } catch
                    {
                        lbl_statusCon.Text = "nicht verbunden";
                        Properties.Settings.Default.COMsaved = false;
                        Properties.Settings.Default.lastCom = "";

                        btn_setAll.Enabled = false;
                    }
                    
                }
            }
            else
            {
                lbl_statusCon.Text = "nicht verbunden";
                btn_setAll.Enabled = false;
            }
            
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            // Einstellungen anzeigen
            Form frm_opt = new frm_options();
            frm_opt.ShowDialog();

            // Form Main neuladen, um Veränderungen der Einstellungen anzuwenden
            loadFormFill();
        }

        private void btn_setAll_Click(object sender, EventArgs e)
        {
            // Senden der Farbe an den ausgewählten Stripe
            if (!cbox_numStripes.Text.Equals(""))
            {
                int stripNum = cbox_numStripes.SelectedIndex + 1;
                // Korrektur der Stellenanzahl des Indexes (kleiner 9 oder kleiner 99)
                String indexID = "";
                if (stripNum <= 9)
                {
                    indexID = "00" + stripNum.ToString();
                }
                else
                {
                    indexID = "0" + stripNum.ToString();
                }
                try
                {
                    // Senden des kompletten Wertes
                    serialPort1.Write(indexID + txt_lecColor.Text + '\n');
                } catch
                {
                    MessageBox.Show("Die Farbe konnte nicht übernommen werden. Es ist eine Überprüfung der Einstellungen nötig." + '\n' + "Ist der COM Port verbunden?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Es wurde kein Strip ausgewählt. Übernehmen der Farbe fehlgeschlagen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Einstellungen speichern
            Properties.Settings.Default.Save();
        }
    }
}
