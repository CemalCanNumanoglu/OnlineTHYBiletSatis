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
    public partial class Musterigiris : Form
    {
        public Musterigiris()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=CANNUMAN;Initial Catalog=ThyBilet;Integrated Security=True");
        private void Musterigiris_Load(object sender, EventArgs e)
        {
            
        }

        private void btnmusterigiris_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(); //cmd adlı komutumuzu oluşturduk
                cmd.Connection = conn; // cmd komutunun bağlantısını sağladık
                cmd.CommandType = CommandType.StoredProcedure; // komut türünü SP olarak atadık
                cmd.CommandText = "up_MusteriGiris"; // komut textini SP mizin adını yazarak tanımladık
                cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 60);//@mail değişkeni ve veri tipi tanımlamaları yapıldı
                cmd.Parameters["@mail"].Value = girismail.Text; //girismail.text kısmındaki veri @mail değişkenine atandı
                cmd.Parameters.Add("@sifre", SqlDbType.NVarChar, 20); // @sifre değişkeni ve veri tipi tanımlamaları yapıldı
                cmd.Parameters["@sifre"].Value = girissifre.Text;//girissifre.text kısmındaki veri @sifre değişkenine atandı
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0) //satırlar doğruysa alttaki işlemleri yapmaya devam edecek
                {
                    MessageBox.Show("Başarıyla giriş yaptınız. İyi Uçuşlar Dileriz :) ", "Giriş Başarılı!");
                    Formlar.Musteriekrani fr = new Musteriekrani();
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

                MessageBox.Show("Hatalı giriş yaptınız.Bilgilerinizi kontrol edip tekrar deneyin!!");

            }
            conn.Close();
        }

        private void btnsifrehatirla_Click(object sender, EventArgs e)
        {
            Formlar.sifremiunuttum fr = new Formlar.sifremiunuttum();
            fr.Show();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            Formlar.musterikayit fr = new Formlar.musterikayit();
            fr.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //şifreyi gösterip gizleyebilmek adına checkbox oluşturdum
        {
            if(checkBox1.CheckState==CheckState.Checked) //eğer checkbox üzerine tıklanmışsa systempasswordchar özelliğini deaktif eder
            {
                girissifre.UseSystemPasswordChar = false;
            }
            else if(checkBox1.CheckState==CheckState.Unchecked) // eğer tıklanmamış ise systempasswordchar özelliğini aktif eder
            {
                girissifre.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formlar.SifreDegistir fr = new Formlar.SifreDegistir();
            fr.Show();
            this.Hide();
        }
    }
}
