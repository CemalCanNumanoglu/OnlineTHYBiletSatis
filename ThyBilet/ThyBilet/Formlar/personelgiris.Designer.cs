
namespace ThyBilet.Formlar
{
    partial class personelgiris
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
            this.personelid = new System.Windows.Forms.Label();
            this.personelsifre = new System.Windows.Forms.Label();
            this.girisid = new System.Windows.Forms.TextBox();
            this.girissifre = new System.Windows.Forms.TextBox();
            this.btnpersonelgiris = new System.Windows.Forms.Button();
            this.btnsifrehatirla = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // personelid
            // 
            this.personelid.AutoSize = true;
            this.personelid.Location = new System.Drawing.Point(33, 73);
            this.personelid.Name = "personelid";
            this.personelid.Size = new System.Drawing.Size(89, 17);
            this.personelid.TabIndex = 0;
            this.personelid.Text = "Personel ID :";
            // 
            // personelsifre
            // 
            this.personelsifre.AutoSize = true;
            this.personelsifre.Location = new System.Drawing.Point(33, 130);
            this.personelsifre.Name = "personelsifre";
            this.personelsifre.Size = new System.Drawing.Size(105, 17);
            this.personelsifre.TabIndex = 1;
            this.personelsifre.Text = "Personel Şifre :";
            // 
            // girisid
            // 
            this.girisid.BackColor = System.Drawing.Color.NavajoWhite;
            this.girisid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisid.Location = new System.Drawing.Point(158, 73);
            this.girisid.Name = "girisid";
            this.girisid.Size = new System.Drawing.Size(149, 27);
            this.girisid.TabIndex = 2;
            // 
            // girissifre
            // 
            this.girissifre.BackColor = System.Drawing.Color.NavajoWhite;
            this.girissifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girissifre.Location = new System.Drawing.Point(158, 130);
            this.girissifre.MaxLength = 4;
            this.girissifre.Name = "girissifre";
            this.girissifre.Size = new System.Drawing.Size(149, 27);
            this.girissifre.TabIndex = 3;
            this.girissifre.UseSystemPasswordChar = true;
            // 
            // btnpersonelgiris
            // 
            this.btnpersonelgiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnpersonelgiris.Location = new System.Drawing.Point(36, 202);
            this.btnpersonelgiris.Name = "btnpersonelgiris";
            this.btnpersonelgiris.Size = new System.Drawing.Size(125, 51);
            this.btnpersonelgiris.TabIndex = 4;
            this.btnpersonelgiris.Text = "Giriş";
            this.btnpersonelgiris.UseVisualStyleBackColor = false;
            this.btnpersonelgiris.Click += new System.EventHandler(this.btnpersonelgiris_Click);
            // 
            // btnsifrehatirla
            // 
            this.btnsifrehatirla.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnsifrehatirla.Location = new System.Drawing.Point(263, 202);
            this.btnsifrehatirla.Name = "btnsifrehatirla";
            this.btnsifrehatirla.Size = new System.Drawing.Size(125, 51);
            this.btnsifrehatirla.TabIndex = 5;
            this.btnsifrehatirla.Text = "Şifremi Unuttum";
            this.btnsifrehatirla.UseVisualStyleBackColor = false;
            this.btnsifrehatirla.Click += new System.EventHandler(this.btnsifrehatirla_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnkapat.Location = new System.Drawing.Point(36, 286);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(125, 51);
            this.btnkapat.TabIndex = 6;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(313, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // personelgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(435, 360);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btnsifrehatirla);
            this.Controls.Add(this.btnpersonelgiris);
            this.Controls.Add(this.girissifre);
            this.Controls.Add(this.girisid);
            this.Controls.Add(this.personelsifre);
            this.Controls.Add(this.personelid);
            this.Name = "personelgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş";
            this.Load += new System.EventHandler(this.personelgiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personelid;
        private System.Windows.Forms.Label personelsifre;
        private System.Windows.Forms.TextBox girisid;
        private System.Windows.Forms.TextBox girissifre;
        private System.Windows.Forms.Button btnpersonelgiris;
        private System.Windows.Forms.Button btnsifrehatirla;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}