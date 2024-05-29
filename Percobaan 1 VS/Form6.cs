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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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
                //serialPort1.NewLine = "#setop#";
                serialPort1.NewLine = "\r\n";

                serialPort1.Open();
                comboBox1.ForeColor = Color.Green;
                MessageBox.Show(serialPort1.PortName + " tersambung!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = true;

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
            comboBox1.ForeColor = Color.Black;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portList)
                comboBox1.Items.Add(portName);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Tampilkan(serialPort1.ReadExisting());
            Tampilkan(serialPort1.ReadLine());
        }

        private delegate void TampilkanDelegate(string item);
        private void Tampilkan(string item)
        {
            if (InvokeRequired)
            {
                // This is a worker thread so delegate the task. 
                listView1.Invoke(new TampilkanDelegate(Tampilkan), item);
            }
            else
            {
                // This is the UI thread so perform the task. 
                listView1.Items.Add(item);
                listView1.Items[listView1.Items.Count - 1].ForeColor = Color.Blue;
            }
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
