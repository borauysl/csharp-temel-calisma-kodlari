using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int tutar = 0;

            if (checkbox_cay.Checked)
            {
                tutar += 2;
            }
            if(checkbox_kahve.Checked)
            {
                tutar += 4;
            }
            if(checkbox_hamburger.Checked)
            {
                tutar += 10;
            }
            if(checkbox_pizza.Checked)
            {
                tutar += 25;
            }
            lbl_tutar.Text = tutar.ToString();
        }
    }
}
