using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThyBilet.Formlar
{
    public partial class personelgiris : Form
    {
        public personelgiris()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=CANNUMAN;Initial Catalog=ThyBilet;Integrated Security=True");
        private void personelgiris_Load(object sender, EventArgs e)
        {

        }

        private void btnpersonelgiris_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(); //cmd komutu oluşturduk
                cmd.Connection = conn; //cmd komutunun baglantısını sağladık
                cmd.CommandType = CommandType.StoredProcedure; //cmd komut türünü stored procedure olarak atadık
                cmd.CommandText = "up_PersonelGiris"; // SP adımızı command text olarak cmd komutumuza atadık
                cmd.Parameters.Add("@id", SqlDbType.Int); // @id değişkeni ve veri tipi parametreleri tanımlandı
                cmd.Parameters["@id"].Value = girisid.Text;//girisid.text kısmındaki veri @id değişkenine atandı
                cmd.Parameters.Add("@sifre", SqlDbType.Char, 4); //@sifre değişkeni ve veri tipi parametreleri tanımlandı
                cmd.Parameters["@sifre"].Value = girissifre.Text;//girissifre.text kısmındaki veri @sifre degiskenine atandı
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count>0 ) //satırların doğruluğunu kontrol eden if bloğu
                {
                    Form1 fr = new Form1();
                    fr.Show();
                    this.Hide();
                    
                }
                else if(girisid.Text == "0" && girissifre.Text == "0000") // admin girişi için
                {
                    Form1 fr = new Form1();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız.Bilgilerinizi kontrol edip tekrar deneyin!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                    
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız.Bilgilerinizi kontrol edip tekrar deneyin!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsifrehatirla_Click(object sender, EventArgs e)
        {
            Formlar.sifremiunuttum fr = new Formlar.sifremiunuttum();
            fr.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                girissifre.UseSystemPasswordChar = false;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                girissifre.UseSystemPasswordChar = true;
            }
        }
    }
}
