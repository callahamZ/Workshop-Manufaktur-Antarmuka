using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percobaan_1_VS
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FormPerc1 = new Form1();
            FormPerc1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FormPerc2 = new Form2();
            FormPerc2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form FormPerc3 = new Form3();
            FormPerc3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form FormPerc6 = new Form4();
            FormPerc6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form FormPerc7a = new Form5();
            FormPerc7a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form FormPerc7b = new Form6();
            FormPerc7b.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form FormPerc8 = new Form7();
            FormPerc8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form FormPercPLC = new Form8();
            FormPercPLC.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form FormTruk = new Form9();
            FormTruk.Show();
        }
    }
}
