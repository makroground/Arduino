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
    public partial class frm_options : Form
    {

        public frm_options()
        {
            InitializeComponent();
        }

        private void frm_options_Load(object sender, EventArgs e)
        {
            // Neuladen der Form
            // Maximal 12 Stripes auswählbar machen
            for (int i = 1; i <= 12; i++)
            {
                cbox_numStripes.Items.Add(i);
            }

            // Gespeicherte Anzahl und Helligkeit auswählen
            cbox_numStripes.SelectedIndex = Properties.Settings.Default.numStripes - 1;
            tbar_brightness.Value = Properties.Settings.Default.ledBrightness;

            if (Properties.Settings.Default.COMsaved)
            {
                // COM Port war gespeichert und konnte wiederverbunden werden
                cbox_ports.Visible = false;
                lbl_comport.Visible = true;
                lbl_comport.Text = Properties.Settings.Default.lastCom;
                btn_init.Enabled = false;
                btn_close.Enabled = true;
            }
            else
            {
                // Kein Com Port war gespeichert und es muss eine neue Verbindung aufgebaut werden
                cbox_ports.Visible = true;
                cbox_ports.Items.AddRange(SerialPort.GetPortNames());
                lbl_comport.Visible = false;
                btn_init.Enabled = true;
                btn_close.Enabled = false;
            }
        }

        private void cbox_numStripes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Anzahl speichern
            Properties.Settings.Default.numStripes = cbox_numStripes.SelectedIndex + 1;
        }

        private void tbar_brightness_ValueChanged(object sender, EventArgs e)
        {
            // Helligkeit speichern
            Properties.Settings.Default.ledBrightness = tbar_brightness.Value;
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            // Verbindung aufbauen, sofern vorher keine bestand und aktuellen COM Port speichern
            if (!cbox_ports.Text.Equals(""))
            {
                try
                {
                    frm_main.serialPort1.PortName = cbox_ports.Text;
                    frm_main.serialPort1.BaudRate = 115200;
                    frm_main.serialPort1.Open();

                    Properties.Settings.Default.lastCom = cbox_ports.Text;
                    lbl_comport.Text = Properties.Settings.Default.lastCom;
                    Properties.Settings.Default.COMsaved = true;

                    cbox_ports.Visible = false;
                    lbl_comport.Visible = true;
                    btn_init.Enabled = false;
                    btn_close.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Die Verbindung konnte nicht aufgebaut werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            // Bestehende Verbindung trennen und löschen
            frm_main.serialPort1.Close();
            Properties.Settings.Default.lastCom = "";
            cbox_ports.Items.Clear();
            Properties.Settings.Default.COMsaved = false;

            cbox_ports.Visible = true;
            cbox_ports.Items.AddRange(SerialPort.GetPortNames());
            lbl_comport.Visible = false;
            btn_init.Enabled = true;
            btn_close.Enabled = false;
        }

        private void frm_options_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Einstellungen speichern
            Properties.Settings.Default.Save();
        }
    }
}
