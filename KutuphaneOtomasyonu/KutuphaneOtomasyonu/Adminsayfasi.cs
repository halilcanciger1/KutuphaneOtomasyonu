using KutuphaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Adminsayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;

        public Adminsayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void Adminsayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmatarihi(), kisi.getKullaniciadi(), kisi.getSifre(), kisi.getYetki());
            }
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getkitapId(), kitap.getkitapİsim(), kitap.getkitapYazar(), kitap.getyayinEvi(), kitap.getkitapDili(), kitap.getkitapTuru(), kitap.getadet(), kitap.getsayfasayisi(), kitap.getbasimYil());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txt_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_id.Text,txt_isim.Text,txt_soyisim.Text,maskedTextBox1.Text,txt_soyisim,txt_kullaniciadi.Text,txt_sifre.Text,txt_yetki.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void kullanicidondur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kullanicidondur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string olusturmatarihi = maskedTextBox1.Text;
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim,soyisim,olusturmatarihi,kullaniciadi,sifre,yetki);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBox2.Controls.Count;  i++)
            {
                if (groupBox2.Controls[i] is TextBox || groupBox2.Controls[i] is MaskedTextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text, txt_kitapisim.Text, txt_yazar.Text, txt_kitapdili.Text, txt_yayinevi.Text, txt_kitapturu.Text, txt_adet.Text, txt_sayfasayisi.Text, txt_basimyili.Text);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        public void kitapdondur()
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_yazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_kitapdili.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_kitapturu.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfasayisi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimyili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapid.Text;
            string kitapisim = txt_kitapisim.Text;
            string yazar = txt_yazar.Text;
            string kitapdili = txt_kitapdili.Text;
            string yayinevi = txt_yayinevi.Text;
            string kitapturu = txt_kitapturu.Text;
            string adet = txt_adet.Text;
            string sayfasayisi = txt_sayfasayisi.Text;
            string basimyili = txt_basimyili.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapisim, yazar, kitapdili, yayinevi, kitapturu, adet, sayfasayisi, basimyili);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapdondur();
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupbox_kitap.Controls.Count; i++)
            {
                if (groupbox_kitap.Controls[i] is TextBox)
                {
                    groupbox_kitap.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            Kisi hedefkisi = null;
            int secilenkisiid = Convert.ToInt32(txt_ara.Text);

            foreach(Kisi kisi in kisilerim)
            {
                if(kisi.getId() == secilenkisiid)
                {
                    hedefkisi = kisi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsim(), hedefkisi.getSoyisim(), hedefkisi.getOlusturmatarihi(), hedefkisi.getKullaniciadi(), hedefkisi.getSifre(), hedefkisi.getYetki());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach(Kisi hedefkisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsim(), hedefkisi.getSoyisim(), hedefkisi.getOlusturmatarihi(), hedefkisi.getKullaniciadi(), hedefkisi.getSifre(), hedefkisi.getYetki());
            }
        }

        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;

            int secilenkitapid = Convert.ToInt32(txt_kitapara.Text);

            foreach(Kitap kitap in kitaplarim)
            {
                if(kitap.getkitapId() == secilenkitapid)
                {
                    hedefkitap = kitap;
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitapId(), hedefkitap.getkitapİsim(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayinEvi(), hedefkitap.getkitapTuru(), hedefkitap.getadet(), hedefkitap.getsayfasayisi(), hedefkitap.getbasimYil());
        }

        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach(Kitap hedefkitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefkitap.getkitapId(), hedefkitap.getkitapİsim(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayinEvi(), hedefkitap.getkitapTuru(), hedefkitap.getadet(), hedefkitap.getsayfasayisi(), hedefkitap.getbasimYil());
            }
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
