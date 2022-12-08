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

namespace ThyBilet.Formlar.Personel
{
    public partial class FrmPersonelKarti : Form
    {
        public FrmPersonelKarti()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new ThyBiletEntities();

        Repository<TBL_Personel> repo = new Repository<TBL_Personel>();
        public int id; //formlar arası veri taşıyabilmek için oluşturdum
        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                //Listeleme kısmında çift tıkladığımız zaman açılan personel kartında kullanıcın verileri girili şekilde gelsin diye bu kısmı yaptık
                var personel = repo.Find(x => x.PersonelID == id);
                TxtAdSoyad.Text = personel.AdSoyad;
                TxtTC.Text = personel.TC;
                TxtAdress.Text = personel.Adress;
                TxtTelefon.Text = personel.Telefon;
                TxtMail.Text = personel.Mail;
                dateEditGiris.Text = personel.IseGirisTarih.ToString();
                TxtAciklama.Text = personel.Aciklama;
                TxtSifre.Text = personel.Sifre;
                lookUpEditDepartman.EditValue = personel.Departman;
                lookUpEditGorev.EditValue = personel.Gorev;

            }
                this.Text = id.ToString();

                lookUpEditDepartman.Properties.DataSource = (from x in db.TBL_Departman  //departman ile ilgili verileri göstermek için kullandım
                                                            select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAD
                                                         }).ToList();

            lookUpEditGorev.Properties.DataSource = (from x in db.TBL_Gorev //görev ile ilgili verileri göstermek için kullandım
                                                     select new
                                                     {
                                                         x.GorevID,
                                                         x.GorevAD
                                                     }).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            TBL_Personel t = new TBL_Personel();
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTC.Text;
            t.Adress = TxtAdress.Text;
            t.Telefon = TxtTelefon.Text;
            t.Mail = TxtMail.Text;
            t.IseGirisTarih =DateTime.Parse(dateEditGiris.Text); //dönüşümü yapmak için datetime.parse kullandım
            t.Departman =int.Parse (lookUpEditDepartman.EditValue.ToString()); // dönüşümü yapmak için int.parse kullandım
            t.Gorev =int.Parse (lookUpEditGorev.EditValue.ToString());
            t.Aciklama = TxtAciklama.Text;
            t.Sifre = TxtSifre.Text;
            t.Durum = 1;
            repo.TAdd(t); // bu kısım burda aldığımız bilgileri veri tabanına kaydettmemizi sağlıyor
            XtraMessageBox.Show("Personel Sisteme Kaydedildi!");
                                  
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.PersonelID == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTC.Text;
            deger.Adress = TxtAdress.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Mail = TxtMail.Text;
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString()); 
            deger.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.IseGirisTarih = DateTime.Parse(dateEditGiris.Text); //dönüşümü yapmak için datetime.parse kullandım
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString()); // dönüşümü yapmak için int.parse kullandım
            deger.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.Aciklama = TxtAciklama.Text;
            deger.Sifre = TxtSifre.Text;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Personel Kaydı Güncellendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
