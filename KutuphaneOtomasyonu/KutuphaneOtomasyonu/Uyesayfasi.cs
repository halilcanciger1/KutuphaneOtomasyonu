using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Entity;

namespace KutuphaneOtomasyonu
{
    public partial class Uyesayfasi : Form
    {
        List<Kitap> kitaplarim;
        public Uyesayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_cıkısyap_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Uyesayfasi_Load(object sender, EventArgs e)
        {
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView3.Rows.Add(kitap.getkitapId(), kitap.getkitapİsim(), kitap.getkitapYazar(), kitap.getyayinEvi(), kitap.getkitapDili(), kitap.getkitapTuru(), kitap.getadet(), kitap.getsayfasayisi(), kitap.getbasimYil());
            }
        }

        private void btn_uyeara_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;
            int secilenid = Convert.ToInt32(txt_uyeara.Text);

            foreach(Kitap kitap in kitaplarim)
            {
                if(kitap.getkitapId() == secilenid)
                {
                    hedefkitap = kitap;
                    break;
                }
            }
            dataGridView3.Rows.Clear();
            dataGridView3.Rows.Add(hedefkitap.getkitapId(), hedefkitap.getkitapİsim(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayinEvi(), hedefkitap.getkitapTuru(), hedefkitap.getadet(), hedefkitap.getsayfasayisi(), hedefkitap.getbasimYil());
        }

        private void btn_uyeyenile_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
            foreach(Kitap hedefkitap in kitaplarim)
            {
                dataGridView3.Rows.Add(hedefkitap.getkitapId(), hedefkitap.getkitapİsim(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayinEvi(), hedefkitap.getkitapTuru(), hedefkitap.getadet(), hedefkitap.getsayfasayisi(), hedefkitap.getbasimYil());
            }
        }
    }
}
