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
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
           

            string sifre = txt_sifre.Text;
            string kullaniciadi = txt_kullaniciadi.Text;

            //Buradan bilgiler değiştirilebilinir
            kisilerim.Add(new Kisi(1,"admin","admin",DateTime.Now,"admin","123","admin"));
            kisilerim.Add(new Kisi(2,"Halil Can","Ciğer",DateTime.Now,"halil can","123","uye"));
            kisilerim.Add(new Kisi(4,"Kamil","Yeşiltaş",DateTime.Now,"kamil","123","uye"));
            kisilerim.Add(new Kisi(5, "Mehmet Ali", "Alakurt", DateTime.Now, "mehmet ali", "123", "uye"));
            kisilerim.Add(new Kisi(6, "Ali", "Sert", DateTime.Now, "ali", "123", "uye"));

            bool kontrol = false;

            foreach(Kisi kisi in kisilerim)
            {
                if (kullaniciadi.ToLower() == kisi.getKullaniciadi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "admin")
                {
                    // admin paneline gönder
                    Adminsayfasi adminsayfasi = new Adminsayfasi(kisilerim,kitaplarim);
                    adminsayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;

                }
                else if(kullaniciadi.ToLower() == kisi.getKullaniciadi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    Uyesayfasi uyesayfasi = new Uyesayfasi(kitaplarim);
                    uyesayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
               
            }
            if(!kontrol)
            {
                MessageBox.Show("Bir hata oluştu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            kitaplarim.Add(new Kitap (1, "İçimizdeki şeytan", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları","Roman", 100, 250, 2016));
            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 350, 760, 2015));
            kitaplarim.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled Hossing", "İngilizce", "Evrensel Yayıncılık", "Roman", 100, 250, 2010));
            kitaplarim.Add(new Kitap(4, "Küçük Prens", "Antoine de Saint-Exupery", "İngilizce", "Can Çocuk Yayınları","Roman", 50, 60, 2018));
            kitaplarim.Add(new Kitap(5, "Kürk Mantolu Madonna", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 650, 220, 2015));

        }
    }
}
