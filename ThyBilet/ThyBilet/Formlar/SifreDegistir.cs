using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ThyBilet.Formlar
{
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection("Data Source=CANNUMAN;Initial Catalog=ThyBilet;Integrated Security=True");
        private void btnsifredegis_Click(object sender, EventArgs e)
        {

            conn.Open();
            string guncel = "Select * from TBL_Musteri where Mail = @mail and Sifre = @eski"; //sql sorgumuzu tanımladık
            SqlParameter prm1 = new SqlParameter("mail", txtmail.Text); //prm1 değişkenine(mail) txtmail.text kutusundan verimizi atadık
            SqlParameter prm2 = new SqlParameter("eski", eskisifre.Text); //prm2 değişkenine(eski) eskisifre.text kutusundan verimizi tanımladık
            SqlCommand komut = new SqlCommand(guncel, conn);           
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            conn.Close();

            if(dt.Rows.Count>0) //üsteki girilen mail ve eski şifre kısmı doğru olduğu sürece if bloğunun altındaki kodlar çalışır.
            {               
                string degis = "Update Tbl_Musteri Set Sifre = @yeni where Mail = @mail"; //mail'in olduğu  satıra şifre atmasını yapar
                SqlCommand komut1 = new SqlCommand(degis, conn);
                komut1.Parameters.AddWithValue("@mail", txtmail.Text);
                komut1.Parameters.AddWithValue("@yeni", yenisifre.Text);
                
                if(eskisifre.Text != yenisifre.Text)
                {
                    conn.Open();
                    komut1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Şifreniz Başarıyla Değişti. İyi Günler Dileriz.", "Bilgi");
                    Formlar.Musterigiris fr = new Formlar.Musterigiris();
                    fr.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Yeni şifreniz eski şifreniz ile aynı olamaz lütfen farklı bir şifre giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            else
            {
                MessageBox.Show("Girdğiniz Mail Adresi veya Şifreniz Sistemle Uyuşmuyor.Lütfen Kontrol Edip Tekrar Deneyiniz.", "Hata");
            }




        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {

        }
    }
}
