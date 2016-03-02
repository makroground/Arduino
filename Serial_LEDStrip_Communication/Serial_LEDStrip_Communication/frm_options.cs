using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            cbox_numStripes.SelectedIndex = Properties.Settings.Default.numStripes - 1;
            tbar_brightness.Value = Properties.Settings.Default.ledBrightness;
        }

        private void cbox_numStripes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.numStripes = cbox_numStripes.SelectedIndex + 1;
        }

        private void tbar_brightness_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ledBrightness = tbar_brightness.Value;
        }
    }
}
