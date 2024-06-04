using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace message_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinize eminmisiniz ?", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(sonuc==DialogResult.Yes)
            {
                label2.Text = "Kullanıcı Çıkış Yapıyor...";
            }

            else
            {
                label2.Text = "Çıkış Yapılamadı...";
            }
        }
    }
}
