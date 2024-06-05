using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private int deltaX = 1;
        private int deltaY = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            imageX = pictureBox1.Left;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imageX += deltaX;
            pictureBox1.Left = imageX;

            if (imageX >= 160)
            {
                bukaPintu();
                timer1.Stop();
            }
        }

        void bukaPintu ()
        {
            panelPintuY = panel6.Top;

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panelPintuY -= deltaY;
            panel6.Top = panelPintuY;

            if (panelPintuY <= -100)
            {
                timer2.Stop();
            }
        }
    }
}
