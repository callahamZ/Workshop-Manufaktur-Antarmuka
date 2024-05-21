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
    }
}
