using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_LEDStrip_Communication
{
    public partial class frm_main : Form
    {

        public static SerialPort serialPort1 = new SerialPort();
        private string[] startArgs;
        private bool whileBoot = true;
        private bool secureClose = false;

        public frm_main()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                // Verhindere das Starten einer neuen Instanz des Programms
                MessageBox.Show("Es läuft bereits eine andere Instanz der Anwendung: Serial_LEDStrip_Communication");
                // "NOTAUS"
                this.Close();
            }
            else
            {
                // Starte die Anwendung
                startArgs = Environment.GetCommandLineArgs();

                // Initialisieren der Form
                InitializeComponent();

                // Start Parameter "/startintray" bewirkt den Start des Programms im System Tray
                if (startArgs.Length > 1)
                {
                    if (startArgs[1].Equals("startintray"))
                    {
                        this.WindowState = FormWindowState.Minimized;
                        tray_icon.Visible = true;
                        this.ShowInTaskbar = false;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //colorDialog1.ShowDialog();
            // Neuladen der Form
            loadFormFill();

            whileBoot = false;
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
                    btn_setCur.Enabled = true;
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
                        btn_setCur.Enabled = true;
                        btn_setAll.Enabled = true;

                        if (Properties.Settings.Default.loadOnBoot)
                        {
                            wait_endOfBoot.Start();
                        }
                    } catch
                    {
                        lbl_statusCon.Text = "nicht verbunden";
                        Properties.Settings.Default.COMsaved = false;
                        Properties.Settings.Default.lastCom = "";

                        btn_setCur.Enabled = false;
                        btn_setAll.Enabled = false;
                    }
                    
                }
            }
            else
            {
                lbl_statusCon.Text = "nicht verbunden";
                btn_setCur.Enabled = false;
                btn_setCur.Enabled = false;
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

        private void btn_setCur_Click(object sender, EventArgs e)
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

                    //Speichern der Farbe für den Stripe
                    int indx = cbox_numStripes.SelectedIndex;
                    string nameStp;
                    if (indx <= 9)
                    {
                        nameStp = "ledColor0" + (cbox_numStripes.SelectedIndex + 1).ToString();
                    }
                    else
                    {
                        nameStp = "ledColor" + (cbox_numStripes.SelectedIndex + 1).ToString();
                    }

                    Properties.Settings.Default[nameStp] = txt_lecColor.Text;
                } catch
                {
                    MessageBox.Show("Die Farbe konnte nicht übernommen werden. Es ist eine Überprüfung der Einstellungen nötig." + '\n' + "Ist der COM Port verbunden?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    serialPort1.Close();
                    lbl_statusCon.Text = "nicht verbunden";
                    Properties.Settings.Default.COMsaved = false;
                    Properties.Settings.Default.lastCom = "";

                    btn_setCur.Enabled = false;
                    btn_setAll.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("Es wurde kein Strip ausgewählt. Übernehmen der Farbe fehlgeschlagen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Schließen (oder Minimieren) des Programms
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (secureClose)
                {
                    // Sicheres/Bewusstes Schließen
                    // Verbindung abbauen
                    serialPort1.Close();
                    // Einstellungen speichern
                    Properties.Settings.Default.Save();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Soll das Programm in den Systemtray minimiert werden, anstatt es zu beenden?", "Minimieren oder Beenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Schließen des Programms in den System Tray
                        this.WindowState = FormWindowState.Minimized;
                        tray_icon.Visible = true;
                        tray_icon.ShowBalloonTip(1000);
                        this.ShowInTaskbar = false;

                        e.Cancel = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        // Verbindung abbauen
                        serialPort1.Close();
                        // Einstellungen speichern
                        Properties.Settings.Default.Save();
                    }
                }
                
                
            }
            else if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                // Verbindung abbauen
                serialPort1.Close();
                // Einstellungen speichern
                Properties.Settings.Default.Save();
            }
        }

        private void frm_main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                // Schließen des Programms in den System Tray
                tray_icon.Visible = true;
                if (!whileBoot)
                {
                    tray_icon.ShowBalloonTip(1000);
                }
                this.ShowInTaskbar = false;
            }
        }

        private void öffneKontrollcenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Öffnen des Programms aux dem System Tray
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            tray_icon.Visible = false;
        }

        private void tray_icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Öffnen des Programms aux dem System Tray
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            tray_icon.Visible = false;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Schließen des Programms
            secureClose = true;
            this.Close();
        }

        private void cbox_numStripes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Laden der gespeicherten Farbe für den Stripe
            int indx = cbox_numStripes.SelectedIndex;
            string nameStp;
            if (indx < 9)
            {
                nameStp = "ledColor0" + (cbox_numStripes.SelectedIndex + 1).ToString();
            }
            else
            {
                nameStp = "ledColor" + (cbox_numStripes.SelectedIndex + 1).ToString();
            }

            txt_lecColor.Text = (String) Properties.Settings.Default[nameStp];
        }

        private void btn_setAll_Click(object sender, EventArgs e)
        {
            setAll_Colors();
        }

        private void setAll_Colors()
        {
            try
            {
                int anzStp = Properties.Settings.Default.numStripes;
                for (int i = 1; i <= anzStp; i++)
                {
                    string nameStp;
                    string color;
                    if (i <= 9)
                    {
                        nameStp = "ledColor0" + i.ToString();
                    }
                    else
                    {
                        nameStp = "ledColor" + i.ToString();
                    }

                    color = (String)Properties.Settings.Default[nameStp];

                    string indexID;
                    if (i <= 9)
                    {
                        indexID = "00" + i.ToString();
                    }
                    else
                    {
                        indexID = "0" + i.ToString();
                    }


                    // Senden des jeweiligen kompletten Wertes
                    serialPort1.Write(indexID + color + '\n');
                }
            }
            catch
            {
                MessageBox.Show("Die Farben konnten nicht übernommen werden. Es ist eine Überprüfung der Einstellungen nötig." + '\n' + "Ist der COM Port verbunden?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                serialPort1.Close();
                lbl_statusCon.Text = "nicht verbunden";
                Properties.Settings.Default.COMsaved = false;
                Properties.Settings.Default.lastCom = "";

                btn_setCur.Enabled = false;
                btn_setAll.Enabled = false;
            }
        }

        private void wait_endOfBoot_Tick(object sender, EventArgs e)
        {
            setAll_Colors();
            wait_endOfBoot.Stop();
        }
    }
}
