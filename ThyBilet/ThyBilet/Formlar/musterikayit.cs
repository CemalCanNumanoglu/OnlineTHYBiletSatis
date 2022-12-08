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
    public partial class musterikayit : Form
    {
        public musterikayit()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=CANNUMAN;Initial Catalog=ThyBilet;Integrated Security=True");
        private void btnkayit_Click(object sender, EventArgs e)
        {

            //yazılı olan if blokları eğer ilgili textbox boş ise hata mesajı verir ve veritabanına kaydetmez
            if(textTc.Text =="")
            {
                MessageBox.Show("TC alanı boş bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (textAdSoyad.Text == "")
            {
                MessageBox.Show("Ad Soyad alanı boş bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textMail.Text == "")
            {
                MessageBox.Show("Mail alanı boş bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (maskedTextTLF.Text== "")
            {
                MessageBox.Show("Telefon alanı boş bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textSifre.Text == "")
            {
                MessageBox.Show("TC alanı boş bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SqlCommand cmd = new SqlCommand();
            conn.Open();

            //up_MusteriEkle SP'sini kullanabilmek için aşağıdaki sıralı komutları kullandım
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "up_MusteriEkle";
            cmd.Parameters.Add("@AdSoyad", SqlDbType.NVarChar);
            cmd.Parameters["@AdSoyad"].Value = textAdSoyad.Text;
            cmd.Parameters.Add("@Tc", SqlDbType.Char,11);
            cmd.Parameters["@Tc"].Value = textTc.Text;
            cmd.Parameters.Add("@Mail", SqlDbType.NVarChar);
            cmd.Parameters["@Mail"].Value = textMail.Text;
            cmd.Parameters.Add("@tel", SqlDbType.NVarChar);
            cmd.Parameters["@tel"].Value = maskedTextTLF.Text;
            cmd.Parameters.Add("@adress", SqlDbType.NVarChar);
            cmd.Parameters["@adress"].Value = textAdress.Text;
            cmd.Parameters.Add("@sifre", SqlDbType.NVarChar);
            cmd.Parameters["@sifre"].Value = textSifre.Text;
            SqlCommand kontrol = new SqlCommand("select count(*) from TBL_Musteri where TC ='" + textTc.Text + "'", conn); //TC ile ilgili olan kutuya girilen verileri alıp veri tabanındaki TC numaraları ile kıyaslar. Eğer sonuç 0 ise veritabanına daha önce girilmemiş bir TC numarasıdır.
            SqlCommand kontrol1 = new SqlCommand("select count(*) from TBL_Musteri where Mail ='" + textMail.Text + "'", conn); //Mail ile ilgili olan kutuya girilen verileri alıp veri tabanındaki Mail adresleri ile kıyaslar. Eğer sonuç 0 ise veritabanına daha önce girilmemiş bir Mail adresidir.
            SqlCommand kontrol2 = new SqlCommand("select count(*) from TBL_Musteri where Telefon ='" + maskedTextTLF.Text + "'", conn);//Telefon numarası ile ilgili olan kutuya girilen verileri alıp veri tabanındaki Telefon numaraları ile kıyaslar.Eper sonuç 0 ise veritabanına daha önce girilmemiş bir telefon numarasıdır.
            int sonuc = (int)kontrol.ExecuteScalar(); //üstteki kontrol komudundaki sayım işlemini sonuc adlı değişkenine atar.
            int sonuc1 = (int)kontrol1.ExecuteScalar();//üsteki kontrol1 komudundaki sayım işlemini sonuc1 adlı int değişkenine atar.
            int sonuc2 = (int)kontrol2.ExecuteScalar();//üsteki kontrol2 komudundaki sayım işlemini sonuc2 adlı int değişkenine atar.
            

            if (sonuc > 0) //eğer sonuc > 0 gelir ise bu TC daha önce veritabanına kaydedilmiş anlamına gelir.
            {
                MessageBox.Show("Girdiğiniz TC numarası üzerinden daha önce kayıt yapılmıştır.Lütfen kontrol edip tekrar deneyiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else if(sonuc1 > 0)// eğer sonuc1 > 0 gelir ise bu Mail adresi daha önce veritabanına kaydedilmiş anlamına gelir.
            {
                MessageBox.Show("Girdiğiniz Mail adresi üzerinden daha önce kayıt yapılmıştır.Lütfen kontrol edip tekrar deneyiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(sonuc2 >0)//eğer sonuc2 > 0 gelir ise bu Telefon numarası daha önce veritabanına kaydedilmiş anlamına gelir
            {
                MessageBox.Show("Girdiğiniz Telefon numarası üzerinden daha önce kayıt yapılmıştır.Lütfen kontrol edip tekrar deneyiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // yukardaki if bloklarından herhangi biri gerçekleşmediyse TC,MAİL ve TELEFON bilgileri daha önce veri tabanına kaydedilmemiştir. Dolayısıyla kayıt başarıyla tamamalanabilir.
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla tamamlandı. Sisteme giriş yapabilirsiniz", "Kayıt Başarılı!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Formlar.Musterigiris fr = new Formlar.Musterigiris();
                fr.Show();
                this.Hide();
            }
            conn.Close();

        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            Formlar.Musterigiris fr = new Formlar.Musterigiris();
            fr.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textSifre.UseSystemPasswordChar = false;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textSifre.UseSystemPasswordChar = true;
            }
        }

        private void musterikayit_Load(object sender, EventArgs e)
        {

        }

        private void textAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //AD SOYAD textbox ına sadece harflerin yazılabilmesi için kullandığım kod parçası.
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TC numarası kısmına sadece sayıların yazılabilmesi için kullandığım kod parçası.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Şifre aldığımız textboxta boşluk karakterleri kullanılmaması için kullandığım kod parçası
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }

        }
    }
}
