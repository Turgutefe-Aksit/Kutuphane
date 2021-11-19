
namespace Kutuphane
{
    partial class frmQuiz
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
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.txtIade = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblAlis = new System.Windows.Forms.Label();
            this.lblIade = new System.Windows.Forms.Label();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.txtListele = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(294, 37);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(103, 22);
            this.txtISBN.TabIndex = 0;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(294, 77);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(103, 22);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(294, 114);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(103, 22);
            this.txtYazar.TabIndex = 2;
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(294, 153);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(103, 22);
            this.txtAlis.TabIndex = 3;
            // 
            // txtIade
            // 
            this.txtIade.Location = new System.Drawing.Point(294, 190);
            this.txtIade.Name = "txtIade";
            this.txtIade.Size = new System.Drawing.Size(103, 22);
            this.txtIade.TabIndex = 4;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(165, 42);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(65, 17);
            this.lblISBN.TabIndex = 5;
            this.lblISBN.Text = "ISBN No:";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(165, 80);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(68, 17);
            this.lblKitapAdi.TabIndex = 6;
            this.lblKitapAdi.Text = "Kitap Adi:";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(165, 117);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(49, 17);
            this.lblYazar.TabIndex = 7;
            this.lblYazar.Text = "Yazar:";
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Location = new System.Drawing.Point(165, 156);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(74, 17);
            this.lblAlis.TabIndex = 8;
            this.lblAlis.Text = "Alis Tarihi:";
            // 
            // lblIade
            // 
            this.lblIade.AutoSize = true;
            this.lblIade.Location = new System.Drawing.Point(165, 193);
            this.lblIade.Name = "lblIade";
            this.lblIade.Size = new System.Drawing.Size(78, 17);
            this.lblIade.TabIndex = 9;
            this.lblIade.Text = "Iade Tatihi:";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(130, 288);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(153, 38);
            this.btnKitapListele.TabIndex = 10;
            this.btnKitapListele.Text = "Kitapları Listele";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(338, 232);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(112, 38);
            this.btnKitapEkle.TabIndex = 11;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(322, 288);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(140, 38);
            this.btnKitapSil.TabIndex = 12;
            this.btnKitapSil.Text = "Kitapları Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // txtListele
            // 
            this.txtListele.Location = new System.Drawing.Point(130, 332);
            this.txtListele.Multiline = true;
            this.txtListele.Name = "txtListele";
            this.txtListele.Size = new System.Drawing.Size(332, 106);
            this.txtListele.TabIndex = 13;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtListele);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnKitapListele);
            this.Controls.Add(this.lblIade);
            this.Controls.Add(this.lblAlis);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtIade);
            this.Controls.Add(this.txtAlis);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtISBN);
            this.Name = "frmQuiz";
            this.Text = "QuizExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.TextBox txtIade;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.Label lblIade;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.TextBox txtListele;
    }
}

