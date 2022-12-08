using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThyBilet.Entity;

namespace ThyBilet.Formlar.Tanımlamalar
{
    public partial class FrmBirim : Form
    {
        public FrmBirim()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new ThyBiletEntities();
        private void FrmBirim_Load(object sender, EventArgs e)
        {
            db.TBL_Birim.Load();
            bindingSource1.DataSource = db.TBL_Birim.Local;

            repositoryItemLookUpDurum.DataSource = (from x in db.TBL_Durum
                                                    select new
                                                    {
                                                        x.DurumID,
                                                        x.DurumAD
                                                    }).ToList();        
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen değerleri kontrol edip tekrar giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
