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
    public partial class Form1 : Form
    {
        private double frekuensi1;
        private double frekuensi2;
        private double frekuensi3;

        private double amplitudo1;
        private double amplitudo2;
        private double amplitudo3;

        private double time = 0.0;
        private double timeInterval = 100;

        private double amplitudoMax;
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].Name = "Gelombang 1"; // Membuat series baru dengan nama tsb
            chart1.Series[0].ChartType =
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // Mengatur tipe chart menjadi line chart

            chart1.Series[0].BorderWidth = 5; // Mengatur tebal garis menjadi 5px
            chart1.Series[0].Color = Color.Red; // Mengatur warna menjadi merah
            chart1.Legends[0].Docking =
            System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            // Mengatur posisi dock dari chart di bawah


            chart1.Series[1].Name = "Gelombang 2"; // Membuat series baru dengan nama tsb
            chart1.Series[1].ChartType =
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // Mengatur tipe chart menjadi line chart 2

            chart1.Series[1].BorderWidth = 5; // Mengatur tebal garis menjadi 5px
            chart1.Series[1].Color = Color.Blue; // Mengatur warna menjadi merah

            
            chart1.Series[2].Name = "Gelombang 3"; // Membuat series baru dengan nama tsb
            chart1.Series[2].ChartType =
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // Mengatur tipe chart menjadi line chart

            chart1.Series[2].BorderWidth = 5; // Mengatur tebal garis menjadi 5px
            chart1.Series[2].Color = Color.Yellow; // Mengatur warna menjadi merah
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled); // Membalik status timer dari aktif menjadi tidak aktif atau sebaliknya
            if (timer1.Enabled == true) // Melakukan cek apakah timer aktif
                button1.Text = "STOP"; // Mengubah text pada tombol
            else
                button1.Text = "START"; // Mengubah text pada tombol
        }

        // Membuat variable-variable untuk membuat gelombang
        private void timer1_Tick(object sender, EventArgs e)
        {
            amplitudoMax = Math.Max(amplitudo1, Math.Max(amplitudo2, amplitudo3));
            chart1.ChartAreas[0].AxisY.Maximum = amplitudoMax;
            chart1.ChartAreas[0].AxisY.Minimum = amplitudoMax * -1;

            double y1 = amplitudo1 * Math.Sin(2 * Math.PI * frekuensi1 * time);
            if (chart1.Series[0].Points.Count > 40)
                chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.AddY(y1);

            double y2 = amplitudo2 * Math.Sin(2 * Math.PI * frekuensi2 * time);
            if (chart1.Series[1].Points.Count > 40)
                chart1.Series[1].Points.RemoveAt(0);
            chart1.Series[1].Points.AddY(y2);

            double y3 = amplitudo3 * Math.Sin(2 * Math.PI * frekuensi3 * time);
            if (chart1.Series[2].Points.Count > 40)
                chart1.Series[2].Points.RemoveAt(0);
            chart1.Series[2].Points.AddY(y3);

            time += 0.01;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            frekuensi1 = Convert.ToDouble(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            amplitudo1 = Convert.ToDouble(numericUpDown2.Value);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            frekuensi2 = Convert.ToDouble(numericUpDown4.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            amplitudo2 = Convert.ToDouble(numericUpDown3.Value);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            frekuensi3 = Convert.ToDouble(numericUpDown6.Value);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            amplitudo3 = Convert.ToDouble(numericUpDown5.Value);
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDown7.Value);
        }
    }
}
