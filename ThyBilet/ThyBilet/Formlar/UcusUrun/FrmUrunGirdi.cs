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

namespace ThyBilet.Formlar.UcusUrun
{
    public partial class FrmUrunGirdi : Form
    {
        public FrmUrunGirdi()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new ThyBiletEntities();
        private void FrmUrunGirdi_Load(object sender, EventArgs e)
        {

            gridControl1.DataSource = (from x in db.TBL_UrunGirdiCikti
                                       select new
                                       {
                                           x.HareketID,
                                           x.TBL_UcusUrun.UrunAd,
                                           x.Adet,
                                           x.Tarih,
                                           x.GirdiCikti
                                       }).Where(y => y.GirdiCikti == "Girdi").ToList();  //oluşturduğum tabloda GirdiCikti sütünundaki ifade "Giriş" olanları listelemesi için bu komutu kullandım                        
        
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmUrunGirdiCikti fr = new FrmUrunGirdiCikti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("HareketID").ToString());
            fr.Show();
                        
        }

      
    }
}
