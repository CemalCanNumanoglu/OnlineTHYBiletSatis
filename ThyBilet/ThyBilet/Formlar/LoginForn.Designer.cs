
namespace ThyBilet.Formlar
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.müsterigiris = new System.Windows.Forms.Button();
            this.personelgiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // müsterigiris
            // 
            this.müsterigiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.müsterigiris.ForeColor = System.Drawing.Color.Black;
            this.müsterigiris.Location = new System.Drawing.Point(272, 374);
            this.müsterigiris.Name = "müsterigiris";
            this.müsterigiris.Size = new System.Drawing.Size(186, 79);
            this.müsterigiris.TabIndex = 0;
            this.müsterigiris.Text = "Müşteri Giriş";
            this.müsterigiris.UseVisualStyleBackColor = false;
            this.müsterigiris.Click += new System.EventHandler(this.müsterigiris_Click);
            // 
            // personelgiris
            // 
            this.personelgiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.personelgiris.Location = new System.Drawing.Point(635, 374);
            this.personelgiris.Name = "personelgiris";
            this.personelgiris.Size = new System.Drawing.Size(186, 79);
            this.personelgiris.TabIndex = 1;
            this.personelgiris.Text = "Personel Giriş";
            this.personelgiris.UseVisualStyleBackColor = false;
            this.personelgiris.Click += new System.EventHandler(this.personelgiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(333, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÜRK HAVA YOLLARI";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelgiris);
            this.Controls.Add(this.müsterigiris);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button müsterigiris;
        private System.Windows.Forms.Button personelgiris;
        private System.Windows.Forms.Label label1;
    }
}