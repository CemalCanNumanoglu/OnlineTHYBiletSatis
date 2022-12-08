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

namespace ThyBilet.Formlar.Musteri
{
    public partial class FrmMusteriListesi : Form
    {
        public FrmMusteriListesi()
        {
            InitializeComponent();
        }
        
        ThyBiletEntities db = new ThyBiletEntities();
        private void FrmMusteriListesi_Load(object sender, EventArgs e)
        {

          
            gridControl1.DataSource = (from x in db.TBL_Musteri
                                       select new
                                       {
                                           x.MusteriID,
                                           x.AdSoyad,
                                           x.TC,
                                           x.Telefon,
                                           x.Mail,
                                           x.iller.sehir,
                                           x.ilceler.ilce,
                                           x.TBL_Ucus.UcusNo, //uçuş id ye göre uçuş numarasını listelemesi için
                                           x.TBL_Koltuk.KoltukNO //koltuk id ye göre koltuk numarasını listelemesi için
                                       }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMusteriKarti fr = new FrmMusteriKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("MusteriID").ToString());
            fr.Show();                                    
            
        }
    }
}
