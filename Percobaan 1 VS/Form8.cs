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
    }
}
