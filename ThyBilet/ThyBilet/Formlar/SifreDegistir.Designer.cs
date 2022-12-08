
namespace ThyBilet.Formlar
{
    partial class SifreDegistir
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.eskisifre = new System.Windows.Forms.TextBox();
            this.btnsifredegis = new System.Windows.Forms.Button();
            this.virtualServerModeSource1 = new DevExpress.Data.VirtualServerModeSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yenisifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eski Şifre :";
            // 
            // eskisifre
            // 
            this.eskisifre.BackColor = System.Drawing.Color.LemonChiffon;
            this.eskisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eskisifre.Location = new System.Drawing.Point(181, 86);
            this.eskisifre.MaxLength = 20;
            this.eskisifre.Name = "eskisifre";
            this.eskisifre.Size = new System.Drawing.Size(198, 27);
            this.eskisifre.TabIndex = 1;
            this.eskisifre.UseSystemPasswordChar = true;
            // 
            // btnsifredegis
            // 
            this.btnsifredegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsifredegis.Location = new System.Drawing.Point(209, 181);
            this.btnsifredegis.Name = "btnsifredegis";
            this.btnsifredegis.Size = new System.Drawing.Size(170, 43);
            this.btnsifredegis.TabIndex = 3;
            this.btnsifredegis.Text = "Şifreyi Değiştir";
            this.btnsifredegis.UseVisualStyleBackColor = true;
            this.btnsifredegis.Click += new System.EventHandler(this.btnsifredegis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail Adresi :";
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Location = new System.Drawing.Point(181, 44);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(198, 27);
            this.txtmail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yeni Şifre :";
            // 
            // yenisifre
            // 
            this.yenisifre.BackColor = System.Drawing.Color.LemonChiffon;
            this.yenisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenisifre.Location = new System.Drawing.Point(181, 132);
            this.yenisifre.MaxLength = 20;
            this.yenisifre.Name = "yenisifre";
            this.yenisifre.Size = new System.Drawing.Size(198, 27);
            this.yenisifre.TabIndex = 2;
            this.yenisifre.UseSystemPasswordChar = true;
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(427, 256);
            this.Controls.Add(this.yenisifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsifredegis);
            this.Controls.Add(this.eskisifre);
            this.Controls.Add(this.label1);
            this.Name = "SifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eskisifre;
        private System.Windows.Forms.Button btnsifredegis;
        private DevExpress.Data.VirtualServerModeSource virtualServerModeSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yenisifre;
    }
}