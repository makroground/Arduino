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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            serialPort1.Write("001" + textBox1.Text + '\n');
            serialPort1.Write("002" + textBox2.Text + '\n');
            serialPort1.Write("003" + textBox3.Text + '\n');
            serialPort1.Write("004" + textBox4.Text + '\n');
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbox_ports.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!cbox_ports.Text.Equals(""))
            {
                serialPort1.PortName = cbox_ports.Text;
                serialPort1.BaudRate = 2000000;
                serialPort1.Open();

                btn_init.Enabled = false;
                btn_close.Enabled = true;
                btn_send.Enabled = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

            btn_init.Enabled = true;
            btn_close.Enabled = false;
            btn_send.Enabled = false;
        }
    }
}
