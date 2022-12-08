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
    public partial class FrmUrunGirdiCikti : Form
    {
        public FrmUrunGirdiCikti()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new ThyBiletEntities();
        Repository<TBL_UrunGirdiCikti> repo = new Repository<TBL_UrunGirdiCikti>();
        TBL_UrunGirdiCikti t = new TBL_UrunGirdiCikti();
        public int id;
        private void FrmUrunGirdiCikti_Load(object sender, EventArgs e)
        {

            //id değeri göstermesi için
            TxtID.Text = id.ToString();
            TxtID.Enabled = false; // dışarıdan textboxa müdahale edilememesi için

            //Ürünleri Girdi Çıktı formunda listelemek için
            lookUpEditUrun.Properties.DataSource = (from x in db.TBL_UcusUrun
                                                        select new
                                                        {
                                                            x.UrunID,
                                                            x.UrunAd
                                                        }).ToList();

            //seçtiğimiz ürünlerin bilgilerinin direk açılan formda gelmesi
            if(id!=0)
            {
                var urun = repo.Find(x => x.HareketID == id);
                lookUpEditUrun.EditValue = urun.UcusUrun;
                TxtAdet.Text = urun.Adet.ToString();
                dateEdit1.Text = urun.Tarih.ToString();
                comboBox1.Text = urun.GirdiCikti;
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.UcusUrun = int.Parse(lookUpEditUrun.EditValue.ToString());
            t.Tarih = DateTime.Parse(dateEdit1.Text);
            t.GirdiCikti = comboBox1.Text;
            t.Adet = decimal.Parse(TxtAdet.Text);
            repo.TAdd(t);
            XtraMessageBox.Show("Ürün işlemleri sisteme kaydedildi!!!");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var urun = repo.Find(x => x.HareketID == id);
            urun.UcusUrun = int.Parse(lookUpEditUrun.EditValue.ToString());
            urun.Tarih = DateTime.Parse(dateEdit1.Text);
            urun.GirdiCikti = comboBox1.Text;
            urun.Adet = decimal.Parse(TxtAdet.Text);
            repo.TAdd(t);
            XtraMessageBox.Show("Ürün güncelleme işlemleri başarılı!!!");
            repo.TUpdate(urun);
        }
    }
}
