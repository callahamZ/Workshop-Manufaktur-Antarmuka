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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Percobaan_1_VS
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portList)
                comboBox1.Items.Add(portName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Pilihan Port Serial tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            serialPort1.PortName = comboBox1.Text;

            try
            {
               

                serialPort1.Open();
                comboBox1.ForeColor = Color.Green;
                MessageBox.Show(serialPort1.PortName + " tersambung!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            MessageBox.Show(serialPort1.PortName + " terputus!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            comboBox1.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox1.Text);
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                serialPort1.NewLine = "#setop#";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                serialPort1.NewLine = "\r\n";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                serialPort1.NewLine = "\r\n";
            }
        }
    }
}
