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

namespace ThyBilet.Formlar.UcusUrun
{
    public partial class FrmUrunKartı : Form
    {
        public FrmUrunKartı()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new ThyBiletEntities();
        Repository<TBL_UcusUrun> repo = new Repository<TBL_UcusUrun>();
        TBL_UcusUrun t = new TBL_UcusUrun();
        public int id;
        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

            
            //ÜRÜN GRUP Listesi
            lookUpEditUrunGrup.Properties.DataSource = (from x in db.TBL_UcusUrunGrup
                                                    select new
                                                    {
                                                        x.UrunGrupId,
                                                        x.UrunGrupAd
                                                    }).ToList();

            //BİRİM Listesi
            lookUpEditBirim.Properties.DataSource = (from x in db.TBL_Birim
                                                    select new
                                                    {
                                                        x.BirimID,
                                                        x.BirimAD
                                                    }).ToList();

            //Durum Listesi
            lookUpEditDurum.Properties.DataSource = (from x in db.TBL_Durum
                                                    select new
                                                    {
                                                        x.DurumID,
                                                        x.DurumAD
                                                    }).ToList();
            
            //Ürün Güncelleme Alanı
            if(id!=0)
            {
                var urun = repo.Find(x => x.UrunID == id);
                TxtUrunAd.Text = urun.UrunAd;
                lookUpEditUrunGrup.EditValue = urun.UrunGrupAd;
                TxtFiyat.Text = urun.Fiyat.ToString();
                TxtKdv.Text = urun.Kdv.ToString();
                TxtAdet.Text = urun.Adet.ToString();
                lookUpEditBirim.EditValue = urun.Birim;
            }
            
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            t.UrunAd = TxtUrunAd.Text;
            t.UrunGrupAd = int.Parse(lookUpEditUrunGrup.EditValue.ToString());
            t.Fiyat = decimal.Parse(TxtFiyat.Text);
            t.Kdv = byte.Parse(TxtKdv.Text);
            t.Adet = decimal.Parse(TxtAdet.Text);
            t.Birim = int.Parse(lookUpEditBirim.EditValue.ToString());
            t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            repo.TAdd(t);
            XtraMessageBox.Show("Ürün başarılı bir şekilde kaydedildi!!!");

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var urundeger = repo.Find(x => x.UrunID == id);
            urundeger.UrunAd = TxtUrunAd.Text;
            urundeger.UrunGrupAd = int.Parse(lookUpEditUrunGrup.EditValue.ToString());
            urundeger.Fiyat = decimal.Parse(TxtFiyat.Text);
            urundeger.Kdv = byte.Parse(TxtKdv.Text);
            urundeger.Adet = decimal.Parse(TxtAdet.Text);
            urundeger.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            urundeger.Birim = int.Parse(lookUpEditBirim.EditValue.ToString());
            repo.TUpdate(urundeger);
            XtraMessageBox.Show("Ürün başarıyla güncellendi!!!");
        }

        private void FrmUrunKartı_Load(object sender, EventArgs e)
        {

        }

      
    }
}
