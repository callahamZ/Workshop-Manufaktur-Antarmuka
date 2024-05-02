using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Percobaan_1_VS
{
    public partial class Form2 : Form
    {
        private double time = 0.0;
        private double amplitude = 50.0;
        private double frequency = 2.0;
        public Form2()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chart1.Series[0].Name = "SIN"; // Membuat series baru dengan nama tsb
            chart1.Series[0].ChartType =
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // Mengatur tipe chart menjadi line chart

            chart1.Series[0].BorderWidth = 5; // Mengatur tebal garis menjadi 5px
            chart1.Series[0].Color = Color.Red; // Mengatur warna menjadi merah
            chart1.Legends[0].Docking =
            System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            if (timer1.Enabled == true)
                button1.Text = "STOP";
            else
                button1.Text = "START";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double y = amplitude * Math.Sin(2 * Math.PI * frequency * time);
            chart1.Series[0].Points.AddXY(time, y);
            time += 0.01;
            if (chart1.Series[0].Points.Count > 40)
            {
                chart1.ChartAreas[0].AxisX.Minimum = time - (0.01 * 40);
                chart1.ChartAreas[0].AxisX.Maximum = time;
            }
        }
    }
}
