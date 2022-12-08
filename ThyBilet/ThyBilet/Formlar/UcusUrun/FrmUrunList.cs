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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new ThyBiletEntities();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            

            gridControl1.DataSource = (from x in db.TBL_UcusUrun
                                       select new
                                       {
                                           x.UrunID,
                                           x.TBL_UcusUrunGrup.UrunGrupAd,
                                           x.UrunAd,
                                           x.Fiyat,
                                           x.Birim,
                                           x.Adet,
                                           x.TBL_Durum.DurumAD
                                       }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmUrunKartı fr = new FrmUrunKartı();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("UrunID").ToString());
            fr.Show();
        }

        
    }
}
