
namespace ThyBilet.Formlar
{
    partial class Musterigiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnkapat = new System.Windows.Forms.Button();
            this.btnsifrehatirla = new System.Windows.Forms.Button();
            this.btnmusterigiris = new System.Windows.Forms.Button();
            this.girissifre = new System.Windows.Forms.TextBox();
            this.girismail = new System.Windows.Forms.TextBox();
            this.musterisifre = new System.Windows.Forms.Label();
            this.musterimail = new System.Windows.Forms.Label();
            this.btnkayitol = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnkapat.Location = new System.Drawing.Point(43, 261);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(125, 51);
            this.btnkapat.TabIndex = 13;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnsifrehatirla
            // 
            this.btnsifrehatirla.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnsifrehatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsifrehatirla.Location = new System.Drawing.Point(270, 177);
            this.btnsifrehatirla.Name = "btnsifrehatirla";
            this.btnsifrehatirla.Size = new System.Drawing.Size(125, 51);
            this.btnsifrehatirla.TabIndex = 12;
            this.btnsifrehatirla.Text = "Şifremi Unuttum";
            this.btnsifrehatirla.UseVisualStyleBackColor = false;
            this.btnsifrehatirla.Click += new System.EventHandler(this.btnsifrehatirla_Click);
            // 
            // btnmusterigiris
            // 
            this.btnmusterigiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnmusterigiris.Location = new System.Drawing.Point(43, 177);
            this.btnmusterigiris.Name = "btnmusterigiris";
            this.btnmusterigiris.Size = new System.Drawing.Size(125, 51);
            this.btnmusterigiris.TabIndex = 11;
            this.btnmusterigiris.Text = "Giriş";
            this.btnmusterigiris.UseVisualStyleBackColor = false;
            this.btnmusterigiris.Click += new System.EventHandler(this.btnmusterigiris_Click);
            // 
            // girissifre
            // 
            this.girissifre.BackColor = System.Drawing.Color.NavajoWhite;
            this.girissifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girissifre.Location = new System.Drawing.Point(137, 104);
            this.girissifre.MaxLength = 20;
            this.girissifre.Name = "girissifre";
            this.girissifre.Size = new System.Drawing.Size(161, 27);
            this.girissifre.TabIndex = 10;
            this.girissifre.UseSystemPasswordChar = true;
            // 
            // girismail
            // 
            this.girismail.BackColor = System.Drawing.Color.NavajoWhite;
            this.girismail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girismail.Location = new System.Drawing.Point(137, 48);
            this.girismail.Name = "girismail";
            this.girismail.Size = new System.Drawing.Size(258, 27);
            this.girismail.TabIndex = 9;
            // 
            // musterisifre
            // 
            this.musterisifre.AutoSize = true;
            this.musterisifre.Location = new System.Drawing.Point(40, 105);
            this.musterisifre.Name = "musterisifre";
            this.musterisifre.Size = new System.Drawing.Size(45, 17);
            this.musterisifre.TabIndex = 8;
            this.musterisifre.Text = "Şifre :";
            // 
            // musterimail
            // 
            this.musterimail.AutoSize = true;
            this.musterimail.Location = new System.Drawing.Point(40, 48);
            this.musterimail.Name = "musterimail";
            this.musterimail.Size = new System.Drawing.Size(85, 17);
            this.musterimail.TabIndex = 7;
            this.musterimail.Text = "Mail Adresi :";
            // 
            // btnkayitol
            // 
            this.btnkayitol.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnkayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayitol.Location = new System.Drawing.Point(270, 261);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(125, 51);
            this.btnkayitol.TabIndex = 14;
            this.btnkayitol.Text = "Kayıt Ol";
            this.btnkayitol.UseVisualStyleBackColor = false;
            this.btnkayitol.Click += new System.EventHandler(this.btnkayitol_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(304, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(153, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 17);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Güncelle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Musterigiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(435, 360);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnkayitol);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btnsifrehatirla);
            this.Controls.Add(this.btnmusterigiris);
            this.Controls.Add(this.girissifre);
            this.Controls.Add(this.girismail);
            this.Controls.Add(this.musterisifre);
            this.Controls.Add(this.musterimail);
            this.Name = "Musterigiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musterigiris";
            this.Load += new System.EventHandler(this.Musterigiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button btnsifrehatirla;
        private System.Windows.Forms.Button btnmusterigiris;
        private System.Windows.Forms.TextBox girissifre;
        private System.Windows.Forms.TextBox girismail;
        private System.Windows.Forms.Label musterisifre;
        private System.Windows.Forms.Label musterimail;
        private System.Windows.Forms.Button btnkayitol;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}