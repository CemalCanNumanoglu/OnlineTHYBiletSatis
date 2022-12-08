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
using ThyBilet.Entity; // veri tabanına erişim sağlayabilmek için kullandığım kütüphane

namespace ThyBilet.Formlar.Tanımlamalar
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new ThyBiletEntities(); //veri tabanını c#'a eklemek için kullandım entity adında klasör açıp veriyi ordan ekledim.

        private void FrmDurum_Load(object sender, EventArgs e)
        {
            db.TBL_Durum.Load();
            bindingSource1.DataSource = db.TBL_Durum.Local; //binding source kullanarak veri tabanını rahat bir şekilde kullandğım arayüze aktarabiliyorum
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

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent(); // veri silmek için kullanılır.
            db.SaveChanges(); //verilerdeki değişikliği kaydedip veri tabanına aktarır.
        }

        private void vazgeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
