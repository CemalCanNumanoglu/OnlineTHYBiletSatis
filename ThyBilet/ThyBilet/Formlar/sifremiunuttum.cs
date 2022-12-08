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
using System.Data.Sql;
using System.Net;
using System.Net.Mail; //system.net ve system.mail kütüphanelerini kullanıcıya mail gönderebilmek için ekledim.

namespace ThyBilet.Formlar
{
    //BU FORMU NORMALDE ŞİFRE UNUTULDUĞU ZAMAN ŞİFRESİNİ MAİL ADRESİNE GÖNDERMEK İÇİN YAZDIM.
    //FAKAT GOOGLE 30 MAYIS 2022 DE GÜVENLİK ÖNLEMLERİ ADINA BUNU ENGELLEMİŞ BU YÜZDEN MAALESEF GÖNDER BUTONU ÇALIŞMIYOR.
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }

        private void btnmailgonder_Click(object sender, EventArgs e)
        {
            sqlbaglanti baglan = new sqlbaglanti();
            SqlCommand komut = new SqlCommand("select * from TBL_Personel where Telefon='" + telNo.Text.ToString() +
                "'and Mail ='" + eposta.Text.ToString() + "'", baglan.baglanti());

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if (baglan.baglanti().State == ConnectionState.Closed)
                    {
                        baglan.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string mailadresim = ("ataunicemalcan@outlook.com"); //mesajı gönderecek e posta adresi
                    string sifre = ("123456atauniCan"); //mesajı gönderecek e posta adresinin şifresi
                    string smtpsrvr = ("smpt.outlook.com"); //gmail,outlook,hotmail vb gibi hangi servis üzerinden çalışıyorsanız onu yazınız
                    string kime = (oku["Mail"].ToString());//mailin kime gönderileceği
                    string konu = ("Şifremi Hatırlamıyorum");//mailin konusunun ne olduğu
                    string yazi = ("Sayın," + oku["AdSoyad"].ToString() + "\n" + "Bizden" + tarih + "Tarihinde şifre hatırlatma talebinde bulundunuz" + "\n" +
                        "parolanız :" + oku["Sifre"].ToString() + "\nİyi günler dileriz"); // mailin içeriği
                    SmtpClient server = new SmtpClient("outlook.com");
                    smtpserver.Credentials = new NetworkCredential(mailadresim, sifre); //mail adresine giriş yapmak için gerekli
                    smtpserver.Port = 587; // gerekli port numarasını giriniz
                    smtpserver.Host = smtpsrvr; 
                    smtpserver.EnableSsl = true; //Güvenlik durumunda sıkıntı yaşamamak için true yapıyoruz
                    mail.From = new MailAddress(mailadresim); //mailin hangi adrestenn gideceği
                    mail.To.Add(kime);//kime gideceği
                    mail.Subject = konu;//konusu
                    mail.Body = yazi;//içeriği
                    smtpserver.Send(mail);// üstteki verilen bilgiler doğrultusunda maili gönderen komut
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Girmiş olduğunuz bilgiler doğru.Şifreniz mail adresinize gönderilmiştir.");
                    this.Hide();
                }
                catch (Exception Hata)
                {

                    MessageBox.Show("Mail gönderme hatası!!", Hata.Message);
                }
                
            }
        }

        private void sifremiunuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
