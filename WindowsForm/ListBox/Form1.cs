using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gun = txt_deger.Text;
            listBox1.Items.Add(gun);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string silinecekgun = listBox1.Items[listBox1.SelectedIndex].ToString();

            listBox1.Items.Remove(silinecekgun);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ListBox count değeri : " + listBox1.Items.Count.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("ListBox temizlendi...");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
