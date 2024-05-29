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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Tampilkan(serialPort1.ReadExisting());
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
                splitData(item);
            }
        }

        private void splitData(object item)
        {
            String[] data = item.ToString().Split(',');
            textBox1.Text = data[1];
            textBox2.Text = data[2];
            textBox3.Text = data[3];
            textBox4.Text = data[4];      
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portList)
                comboBox1.Items.Add(portName);
            serialPort1.DataReceived += serialPort1_DataReceived;

            comboBox2.SelectedIndex = 0;
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
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Int32.Parse(comboBox2.Text);
                serialPort1.NewLine = "\r\n";
                serialPort1.Open();
                toolStripStatusLabel1.Text = serialPort1.PortName + " tersambung.";

                comboBox1.ForeColor = Color.Green;
                MessageBox.Show(serialPort1.PortName + " tersambung!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = true;

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
            button1.Enabled = true;
            button2.Enabled = false;
            comboBox1.ForeColor = Color.Black;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
