using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThyBilet.Formlar
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void personelgiris_Click(object sender, EventArgs e)
        {
            Formlar.personelgiris fr = new Formlar.personelgiris();
            fr.Show();
            
            
        }

        private void müsterigiris_Click(object sender, EventArgs e)
        {
            Formlar.Musterigiris fr = new Formlar.Musterigiris();
            fr.Show();
        }
    }
}
