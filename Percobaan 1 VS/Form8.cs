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

namespace Percobaan_1_VS
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = textBox1.Text;
            string fcs = HitungFCS(command);
            textBox2.Text = fcs;
            textBox3.Text = $"{command}{fcs}*";
        }

        private string HitungFCS(string input)
        {
            byte fcs = 0;
            foreach (char c in input)
            {
                fcs ^= (byte)c;
            }
            return fcs.ToString("X2");
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portList)
                comboBox1.Items.Add(portName);

            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 3;
            comboBox5.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Pilihan Port Serial tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            serialPort1.PortName = comboBox1.Text;

            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Int32.Parse(comboBox2.Text);
                serialPort1.DataBits = Int32.Parse(comboBox4.Text);
                dapatkanParity();
                dapatkanStopBit();
                serialPort1.NewLine = "\r";
                serialPort1.Open();

                toolStripStatusLabel1.Text = serialPort1.PortName + " tersambung.";

                comboBox1.ForeColor = Color.Green;
                MessageBox.Show(serialPort1.PortName + " tersambung!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3.Enabled = false;
                button2.Enabled = true;
                button4.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel1.Text = "ERROR: " + ex.Message.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            toolStripStatusLabel1.Text = serialPort1.PortName + " terputus.";
            MessageBox.Show(serialPort1.PortName + " terputus!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button3.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
            comboBox1.ForeColor = Color.Black;
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void dapatkanParity()
        {
            if (comboBox3.SelectedIndex == 0)
            {
                serialPort1.Parity = Parity.None;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                serialPort1.Parity = Parity.Even;
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                serialPort1.Parity = Parity.Odd;
            }
        }

        private void dapatkanStopBit()
        {
            if (comboBox5.SelectedIndex == 0)
            {
                serialPort1.StopBits = StopBits.One;
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                serialPort1.StopBits = StopBits.Two;
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                serialPort1.StopBits = StopBits.OnePointFive;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox4.Text);
        }
    }
}
