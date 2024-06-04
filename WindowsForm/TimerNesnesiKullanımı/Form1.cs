using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerNesnesiKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi>=0)
            {
                sayi--;
                label2.Text = sayi.ToString();
            }
            else
            {
                timer1.Enabled = false;
            }

        }
        int sayi = 20;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // zamanlamayı aktif yap.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;

            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer2.Enabled=false;
            }
        }
    }
}
