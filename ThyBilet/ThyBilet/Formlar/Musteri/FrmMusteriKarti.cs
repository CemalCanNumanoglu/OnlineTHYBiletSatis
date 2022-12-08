using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThyBilet.Entity;
using ThyBilet.Repositories;

namespace ThyBilet.Formlar.Musteri
{
    public partial class FrmMusteriKarti : Form
    {
        public FrmMusteriKarti()
        {
            InitializeComponent();
        }
        public int id;
        Repository<TBL_Musteri> repo = new Repository<TBL_Musteri>();
        TBL_Musteri t = new TBL_Musteri();
        ThyBiletEntities db = new ThyBiletEntities();
        private void FrmMusteriKarti_Load(object sender, EventArgs e)
        {

            if (id != 0)
            {
                var musteri = repo.Find(x => x.MusteriID == id);
                TxtAdSoyad.Text = musteri.AdSoyad;
                TxtTC.Text = musteri.TC;
                TxtAdress.Text = musteri.Adress;
                TxtTelefon.Text = musteri.Telefon;
                TxtMail.Text = musteri.Mail;                
                lookUpEditSehir.EditValue = musteri.Sehir;
                lookUpEditİlce.EditValue = musteri.ilce;
                lookUpEditUlke.EditValue = musteri.Ulke;
                lookUpEditUcus.EditValue = musteri.Ucus;

            }



            //Ülke Listesi
            lookUpEditUlke.Properties.DataSource = (from x in db.TBL_Ulke 
                                                         select new
                                                         {
                                                             x.UlkeID,
                                                             x.UlkeAd
                                                         }).ToList();

            //Şehir Listesi
            lookUpEditSehir.Properties.DataSource = (from x in db.iller
                                                    select new
                                                    {
                                                        x.id,
                                                        x.sehir
                                                    }).ToList();

            //Koltuk Listesi
            lookUpEditkoltuk.Properties.DataSource = (from x in db.TBL_Koltuk
                                                      select new
                                                      {
                                                          x.KoltukID,
                                                          x.KoltukNO,
                                                          x.TBL_Durum.DurumAD
                                                      }).ToList();

            


            
         

        }

        private void lookUpEditSehir_EditValueChanged(object sender, EventArgs e)
        {
            //bu kısmı seçilen Şehire göre ilçelerin gelmesi için yaptım
            int secilen;
            secilen = int.Parse(lookUpEditSehir.EditValue.ToString());
            lookUpEditİlce.Properties.DataSource = (from x in db.ilceler
                                                    select new
                                                    {
                                                        x.id,
                                                        x.ilce,
                                                        x.sehir

                                                    }).Where(y => y.sehir == secilen).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
           
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTC.Text;
            t.Telefon = TxtTelefon.Text;
            t.Mail = TxtMail.Text;
            t.Adress = TxtAdress.Text;
            t.Sehir =int.Parse (lookUpEditSehir.EditValue.ToString());
            t.ilce =int.Parse (lookUpEditİlce.EditValue.ToString());
            t.Ulke =int.Parse (lookUpEditUlke.EditValue.ToString());
            t.Durum = 1;
            repo.TAdd(t);
            XtraMessageBox.Show("Müşteri başarılı bir şekilde sisteme kayıt edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.MusteriID == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTC.Text;
            deger.Adress = TxtAdress.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Mail = TxtMail.Text;
            deger.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString()); // dönüşümü yapmak için int.parse kullandım
            deger.Sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
            deger.ilce = int.Parse(lookUpEditİlce.EditValue.ToString());
            deger.Koltuk = int.Parse(lookUpEditkoltuk.EditValue.ToString());
            repo.TUpdate(deger);
            XtraMessageBox.Show("Müşteri Kaydı Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lookUpEditUlke_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEditkoltuk_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
