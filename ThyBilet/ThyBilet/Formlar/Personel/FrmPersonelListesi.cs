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

namespace ThyBilet.Formlar.Personel
{
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }

        ThyBiletEntities db = new ThyBiletEntities();
        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBL_Personel
                           select new
                           {
                               x.PersonelID,
                               x.AdSoyad,
                               x.TC,
                               x.Telefon,
                               x.Mail,
                               x.TBL_Departman.DepartmanAD,
                               x.TBL_Gorev.GorevAD,
                               x.TBL_Durum.DurumAD

                           }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //bu kısımda çift tıklama yaparak personel kartı formunu açıp o formda güncelleme yapmamızı sağlıyor.
            FrmPersonelKarti fr = new FrmPersonelKarti(); 
            fr.id = int.Parse (gridView1.GetFocusedRowCellValue("PersonelID").ToString()); //formlar arası veri aktarımı için oluşturduğum stringi burada kullandım
            fr.Show();
        }
    }
}
