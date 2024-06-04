using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox_nesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Perşembe");
            comboBox1.Items.Add("Cuma");

            /*comboBox1.Items.RemoveAt(4);
            comboBox1.Items.Remove("Pazartesi");*/
                

            //MessageBox.Show("Bora Uysal");

        }

        private void btn_gunsec_Click(object sender, EventArgs e)
        {
            // selecteditem - selectedindex

            string secilengun = comboBox1.SelectedItem.ToString();

            int secilenindex = comboBox1.SelectedIndex;

            MessageBox.Show("Seçtiğiniz Gün : " +secilengun +" "+"İndex Değeri : "+ secilenindex);

        }
    }
}
