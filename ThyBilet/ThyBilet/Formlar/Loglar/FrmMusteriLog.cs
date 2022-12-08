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

namespace ThyBilet.Formlar.Loglar
{
    public partial class FrmMusteriLog : Form
    {
        public FrmMusteriLog()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new ThyBiletEntities();
        private void FrmMusteriLog_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBL_MusteriLogları
                                       select new
                                       {
                                           x.Tarih,
                                           x.Rapor
                                       }).ToList();
        }
    }
}
