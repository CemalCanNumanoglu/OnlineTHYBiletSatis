using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThyBilet.Formlar
{
    public partial class Biletlistesi : Form
    {
        public Biletlistesi()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=CANNUMAN;Initial Catalog=ThyBilet;Integrated Security=True");
        private void Biletlistesi_Load(object sender, EventArgs e)
        {
            conn.Open();
            string biletfiyat = "exec up_BiletFiyatSınıfListesi"; //sorgumuzu sp şeklinde oluşturduğumuz string değişkenine atadık
            SqlCommand cmd = new SqlCommand(biletfiyat, conn); //cmd komutunu oluşturup buna oluşturduğumuz string değişkenini ve bağlantı yolumuzu gösterdik
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        

        

        
    }
}
