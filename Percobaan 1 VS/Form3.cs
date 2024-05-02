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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Form1.ActiveForm.Text = "Serial Communication";
            button1.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portList)
                comboBox1.Items.Add(portName);
            serialPort1.DataReceived += serialPort1_DataReceived;
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
                MessageBox.Show("Port " + comboBox1.Text + " tersambung!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form1.ActiveForm.Text = serialPort1.PortName + " tersambung";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox1.Text);
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Tampilkan(serialPort1.ReadExisting());
        }
        
        private delegate void TampilkanDelegate(object item);
        private void Tampilkan(object item)
        {
            if (InvokeRequired)
                // This is a worker thread so delegate the task. 
                listBox1.Invoke(new TampilkanDelegate(Tampilkan), item);
            else
                // This is the UI thread so perform the task. 
                listBox1.Items.Add(item);
        }
    }
}
