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
using static System.Net.Mime.MediaTypeNames;

namespace Percobaan_1_VS
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            InitializeComponent();
        }

        private int imageX = 0;
        private int panelPintuY = 0;
        private int truckStopPoint = 160;
        private bool truckContinue = false;
        private bool modeNaik = true;

        private void button1_Click(object sender, EventArgs e)
        {
            imageX = gambarTruk.Left;
            if (truckContinue)
            {
                truckStopPoint = 500;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imageX++;
            gambarTruk.Left = imageX;

            checkUltra();
            checkProx();

            // Pintu turun kembali
            if (gambarTruk.Left == 360)
            {
                modeNaik = false;
                timer2.Start();
            }

            if (imageX >= truckStopPoint)
            {
                timer1.Stop();
                if (truckContinue == true)
                {
                    truckStopPoint = 160;
                    truckContinue = false;
                    return;
                }
                bukaPintu();
                truckContinue = true;
            }
        }

        void bukaPintu ()
        {
            panelPintuY = rollingDoor.Top;

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (modeNaik)
            {
                panelPintuY--;
            }
            else if (!modeNaik)
            {
                panelPintuY++;
            }

            rollingDoor.Top = panelPintuY;

            rollingDoorIndikator.BackColor = Color.Green;

            limitSwitchCheck();

            if (modeNaik && panelPintuY <= -120)
            {
                timer2.Stop();
                rollingDoorIndikator.BackColor= Color.Red;
                modeNaik = false;
            }
            else if (!modeNaik && panelPintuY >= 24)
            {
                timer2.Stop();
                rollingDoorIndikator.BackColor = Color.Red;
                modeNaik = true;
            }
        }

        void checkUltra()
        {
            if (gambarTruk.Left > 140 && gambarTruk.Left < 340)
            {
                sensorUltra.BackColor = Color.Green;
                sensorUltraIndikator.BackColor = Color.Green;
            }
            else
            {
                sensorUltra.BackColor = Color.Red;
                sensorUltraIndikator.BackColor = Color.Red;
            }
        }

        void checkProx()
        {
            if (gambarTruk.Left > 180 && gambarTruk.Left < 360)
            {
                sensorProx.BackColor = Color.Green;
                sensorProxIndikator.BackColor = Color.Green;
            }
            else
            {
                sensorProx.BackColor = Color.Red;
                sensorProxIndikator.BackColor = Color.Red;
            }
        }

        void limitSwitchCheck()
        {
            if (rollingDoor.Top < 28)
            {
                limitSwitch2.BackColor = Color.Red;
                limitSwitch2Indikator.BackColor = Color.Red;
            }

            if (rollingDoor.Top <= -120)
            {
                limitSwitch1.BackColor = Color.Green;
                limitSwitch1Indikator.BackColor = Color.Green;
            }
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel1.Text = "ERROR: " + ex.Message.ToString();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            toolStripStatusLabel1.Text = serialPort1.PortName + " terputus.";
            MessageBox.Show(serialPort1.PortName + " terputus!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button3.Enabled = true;
            button2.Enabled = false;
            comboBox1.ForeColor = Color.Black;
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portList)
                comboBox1.Items.Add(portName);

            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 3;
            comboBox5.SelectedIndex = 0;
        }
    }
}
