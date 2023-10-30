using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entity
{
    public class Kisi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmatarihi { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }

        public Kisi()
        {
            
        }

        public Kisi(int id, string isim, string soyisim, DateTime olusturmatarihi, string kullaniciadi, string sifre, string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmatarihi = olusturmatarihi;
            this.kullaniciadi = kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }
        public string getIsim()
        {
            return isim;
        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }
        public string getSoyisim()
        {
            return soyisim;
        }
        public void setSoyisim(string soyisim)
        {
            this.soyisim= soyisim;
        }
        public DateTime getOlusturmatarihi()
        {
            return olusturmatarihi;
        }
        public void setOlusturmatarihi(DateTime olusturmatarihi)
        {
            this.olusturmatarihi = olusturmatarihi;
        }
        public string getKullaniciadi()
        {
            return kullaniciadi;
        }
        public void setKullaniciadi(string kullaniciadi)
        {
            this.kullaniciadi = kullaniciadi;
        }
        public string getSifre()
        {
            return sifre; 
        }
        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string getYetki()
        {
            return yetki;
        }
        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }
    }
}
