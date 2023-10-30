using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entity
{
    public class Kitap
    {
        public int kitapId { get; set; }
        public string kitapİsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string kitapTuru { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int basimYil { get; set; }

        public Kitap()
        {
            
        }
        public Kitap(int kitapId, string kitapİsim, string kitapYazar, string kitapDili, string yayinEvi, string kitapTuru, int adet, int sayfaSayisi, int basimYil)
        {
            this.kitapId = kitapId;
            this.kitapİsim = kitapİsim;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.kitapTuru = kitapTuru;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimYil = basimYil;
        }
        public int getkitapId()
        {
            return this.kitapId;
        }
        public string getkitapİsim()
        {
            return this.kitapİsim;
        }
        public string getkitapYazar()
        {
            return this.kitapYazar;
        }
        public string getkitapDili()
        {
            return this.kitapDili;
        }
        public string getyayinEvi()
        {
            return this.yayinEvi;
        }
        public string getkitapTuru()
        {
            return this.kitapTuru;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfasayisi()
        {
            return this.sayfaSayisi;
        }
        public int getbasimYil()
        {
            return this.basimYil;
        }
    }
}
