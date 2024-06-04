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
    public partial class AdminSayfasi : Form
    {
        List<kisi> kisilerim;
        List<Kitap> kitaplarim;

        public AdminSayfasi(List<kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getid(), kisi.getisim(), kisi.getsoyisim(), kisi.getolusturulmatarihi(), kisi.getkullaniciadi(), kisi.getsifre(), kisi.getyetki());
            }

            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getkitapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayinevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfasayisi(), kitap.getbasimyili());
            }

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, maskedTextBox1.Text,txt_kullaniciadi.Text,txt_sifre.Text,txt_yetki.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        public void textleridoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            // hatalı 

            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string olusturmatarih = maskedTextBox1.Text;
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, olusturmatarih, kullaniciadi, sifre, yetki);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();
            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBox1.Controls.Count;i++)
            {
                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_eklekitap_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_idkitap.Text, txt_kitapisim.Text,txt_kitapyazar.Text, txt_dil.Text, txt_yayinevi.Text, txt_tur.Text, txt_adet.Text, txt_sayfa.Text, txt_yil.Text);
        }

        private void btn_silkitap_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_guncellekitap_Click(object sender, EventArgs e)
        {
            string kitapid = txt_idkitap.Text;
            string kitapismi = txt_kitapisim.Text;
            string kitapyazar = txt_kitapyazar.Text;
            string dil = txt_dil.Text;
            string yayinevi = txt_yayinevi.Text;
            string tur = txt_tur.Text;
            string adet = txt_adet.Text;
            string sayfa = txt_sayfa.Text;
            string yil = txt_yil.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapismi, kitapyazar, dil, yayinevi, tur, adet, sayfa, yil);

        }

        private void btn_temizlekitap_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
             if (groupbox2.Controls[i] is TextBox)
                {
                    groupbox2.Controls[i].Text = String.Empty;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idkitap.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_dil.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_tur.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfa.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            groupbox2.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Başarıyla Çıkış Yapıldı...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
