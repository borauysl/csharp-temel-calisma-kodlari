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
    public partial class UserSayfasi : Form
    {
        List<Kitap> kitaplarim;

        public UserSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void UserSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getkitapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayinevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfasayisi(), kitap.getbasimyili());
            }
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
