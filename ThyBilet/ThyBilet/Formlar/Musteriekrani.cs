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
    public partial class Musteriekrani : Form
    {
        public Musteriekrani()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=CANNUMAN;Initial Catalog=ThyBilet;Integrated Security=True");
        private void virtualServerModeSource1_ConfigurationChanged(object sender, DevExpress.Data.VirtualServerModeRowsEventArgs e)
        {

        }

        

        private void btnlistele_Click(object sender, EventArgs e)
        {

           
                conn.Open();
                string listele = "Select * From TBL_Ucus where Durum = 1 and Nereden = @nereden and Nereye = @nereye and Tarih = @tarih order by Saat"; //Durumu 1 olan ve seçilen bölgeden seçilen yere olan saate göre sıralanmış o tarhiteki uçuşlar için kullandığım sql komutu
                SqlParameter prm1 = new SqlParameter("nereden", nereden.Text);
                SqlParameter prm2 = new SqlParameter("nereye", nereye.Text);
                SqlParameter prm3 = new SqlParameter("tarih", DateTime.Parse(dateTimePicker1.Text));
                SqlCommand komut = new SqlCommand(listele, conn);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                komut.Parameters.Add(prm3);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            MessageBox.Show("Uçuşlar Tabloda Listelenmiştir.Eğer Herhangi Bir Uçuş Bilgisi Göremiyorsanız Girdiğiniz Verilere Uygun Uçuş Bulunmamaktadır.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
               
         

                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                MessageBox.Show("TC alanı boş bırakılamaz TC nizi girip tekrar deneyiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTc.Text.Length < 11)
            {
                MessageBox.Show("Geçersiz Kimlik Numarası.Lütfen 11 haneli TC kimlik numaranızı giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn; //cmd komutunun database ile bağlantısını sağladık
                cmd.CommandType = CommandType.StoredProcedure; //komut türünün stored procedür olduğunu belirledik
                cmd.CommandText = "up_UcusGuncelle"; //cmd komutunun hangi sp yi çalıştıracağını atadık
                cmd.Parameters.Add("@ucusid", SqlDbType.Int); //@ucusid değişkeninin veri tipini int olarak atadık
                cmd.Parameters["@ucusid"].Value = txtucusid.Text; // @ucusid değişkenin değerini alacağını textboxı gösterdik
                cmd.Parameters.Add("@tc", SqlDbType.Char, 11); //@tc değişkenin veri tipini char ve maks karakter sayısını 11 olarak atadık
                cmd.Parameters["@tc"].Value = txtTc.Text; //@tc değişkenin değerini alacağı textboxı gösterdik
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Bilet Siparişiniz Oluşturulmuştur. 24 Saat Öncesinde Check-in Yapmayı Unutmayınız İyi Günler Dileriz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Formlar.Biletlistesi fr = new Formlar.Biletlistesi();
            fr.Show();            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtucusno.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); //Uçuş NO yu göstermek için kullandım
            txtucusid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); //Uçuş ID yi göstermek için kullandım,txtucusid görülebilir bir textbox değil bize oraya atanan değer lazım olduğu için görüntü kirliliği yapmaması adına gizledim.
        }

        private void Musteriekrani_Load(object sender, EventArgs e)
        {

        }
    }
}
