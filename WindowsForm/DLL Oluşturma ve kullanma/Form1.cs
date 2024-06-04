using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL__Matematik_; // yazdığımız kütüphane.

namespace DLL_Oluşturma_ve_kullanma
{
    public partial class Form1 : Form
    {

        Matematikİslemleri matematikislemleri = new Matematikİslemleri();




        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_topla_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int toplam = matematikislemleri.topla(sayi1 , sayi2 );

            lbl_sonuc.Text = toplam.ToString();

        }

        private void btn_eksi_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int eksi = matematikislemleri.cikarma(sayi1 , sayi2 );  

            lbl_sonuc.Text = eksi.ToString();
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_sayi1.Text);
            double sayi2 = Convert.ToDouble(txt_sayi2.Text);

            double bolme = matematikislemleri.bolme(sayi1 , sayi2);

            lbl_sonuc.Text = bolme.ToString();
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            int carpma = matematikislemleri.carpma(sayi1, sayi2);

            lbl_sonuc.Text = carpma.ToString(); 
        }
    }
}
