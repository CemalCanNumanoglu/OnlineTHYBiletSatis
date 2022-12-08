
namespace ThyBilet.Formlar
{
    partial class sifremiunuttum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.telNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eposta = new System.Windows.Forms.TextBox();
            this.btnmailgonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifremi Unuttum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon No :";
            // 
            // telNo
            // 
            this.telNo.BackColor = System.Drawing.Color.LemonChiffon;
            this.telNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNo.Location = new System.Drawing.Point(169, 120);
            this.telNo.Name = "telNo";
            this.telNo.Size = new System.Drawing.Size(193, 30);
            this.telNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-Posta :";
            // 
            // eposta
            // 
            this.eposta.BackColor = System.Drawing.Color.LemonChiffon;
            this.eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eposta.Location = new System.Drawing.Point(169, 179);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(193, 30);
            this.eposta.TabIndex = 4;
            // 
            // btnmailgonder
            // 
            this.btnmailgonder.BackColor = System.Drawing.Color.MintCream;
            this.btnmailgonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmailgonder.Location = new System.Drawing.Point(211, 232);
            this.btnmailgonder.Name = "btnmailgonder";
            this.btnmailgonder.Size = new System.Drawing.Size(151, 54);
            this.btnmailgonder.TabIndex = 5;
            this.btnmailgonder.Text = "Gönder";
            this.btnmailgonder.UseVisualStyleBackColor = false;
            this.btnmailgonder.Click += new System.EventHandler(this.btnmailgonder_Click);
            // 
            // sifremiunuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(435, 410);
            this.Controls.Add(this.btnmailgonder);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sifremiunuttum";
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.sifremiunuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.Button btnmailgonder;
    }
}