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
    public partial class FrmUcus : Form
    {
        public FrmUcus()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new Entity.ThyBiletEntities();

        private void FrmUcus_Load(object sender, EventArgs e)
        {
            db.TBL_Ucus.Load();
            bindingSource1.DataSource = db.TBL_Ucus.Local;

            repositoryItemLookUpEditKoltuk.DataSource = (from x in db.TBL_Koltuk
                                                    select new
                                                    {
                                                        x.KoltukID,
                                                        x.KoltukNO
                                                    }).ToList();

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

                XtraMessageBox.Show("Bilgiler kaydedilirken hata oluştu,kontrol edip tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void koltukSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void vazgeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
