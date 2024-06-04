using KütüphaneOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon
{
    public partial class Form1 : Form
    {
        List<kisi> kisilerim = new List<kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
               
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";

           kullaniciadi = txt_kullaniciadi.Text;
            sifre = txt_sifre.Text;

            bool kontrol = false;

            foreach(kisi kisi in kisilerim)
            {
                if(kullaniciadi.ToLower()==kisi.getkullaniciadi()&& sifre.ToLower()==kisi.getsifre()&& kisi.getyetki()== "admin")
                {
                    // Admin sayfasına yönlendir.
                    AdminSayfasi adminsayfasi = new AdminSayfasi(kisilerim,kitaplarim);
                    adminsayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre.ToLower() == kisi.getsifre() && kisi.getyetki() == "user")
                {
                    // User sayfasına yönlendir.
                    UserSayfasi usersayfasi = new UserSayfasi(kitaplarim);
                    usersayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }              
                
            }

            if(!kontrol)
            {
                MessageBox.Show("Hatalı Giriş...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new kisi(1, "Bora", "Uysal", DateTime.Now, "borauysl", "123", "admin"));
            kisilerim.Add(new kisi(2, "Gamze", "Karakurt", DateTime.Now, "gamo", "123", "admin"));
            kisilerim.Add(new kisi(3, "Yakup", "Reçber", DateTime.Now, "yakup", "3", "user"));
            kisilerim.Add(new kisi(4, "Enes", "Bayram", DateTime.Now, "enes", "2", "user"));
            kisilerim.Add(new kisi(5, "Sevgi", "Uysal", DateTime.Now, "sevgiuysal", "domates", "admin"));


            kitaplarim.Add(new Kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayınevi", "Roman", 200, 750, 2015));
            kitaplarim.Add(new Kitap(3, "Little Prince", "Antoine de Saint-Expuery", "İngilizce", "Can Çocuk Yayınları", "Roman", 300, 200, 2014));
            kitaplarim.Add(new Kitap(4, "Böyle Söyledi Zerdüşt", "Friedrich Nietzsche", "Türkçe", "İş Bankası Yayınları", "Felsefe", 275, 570, 2013));
        }

        private void txt_kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
