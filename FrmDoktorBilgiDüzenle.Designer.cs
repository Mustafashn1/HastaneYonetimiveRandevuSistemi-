namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.BtnBilgiDuzenle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label331 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnBilgiDuzenle
            // 
            this.BtnBilgiDuzenle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnBilgiDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBilgiDuzenle.Location = new System.Drawing.Point(192, 270);
            this.BtnBilgiDuzenle.Name = "BtnBilgiDuzenle";
            this.BtnBilgiDuzenle.Size = new System.Drawing.Size(167, 53);
            this.BtnBilgiDuzenle.TabIndex = 6;
            this.BtnBilgiDuzenle.Text = "Güncelle";
            this.BtnBilgiDuzenle.UseVisualStyleBackColor = false;
            this.BtnBilgiDuzenle.Click += new System.EventHandler(this.BtnBilgiDuzenle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Şifre :";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSoyad.Location = new System.Drawing.Point(192, 99);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(167, 29);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Soyad :";
            // 
            // TxtAd
            // 
            this.TxtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAd.Location = new System.Drawing.Point(192, 64);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(167, 29);
            this.TxtAd.TabIndex = 1;
            // 
            // MskTC
            // 
            this.MskTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTC.Location = new System.Drawing.Point(192, 136);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(167, 29);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "TC Kimlik No :";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(192, 171);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(167, 32);
            this.CmbBrans.TabIndex = 4;
            // 
            // label331
            // 
            this.label331.AutoSize = true;
            this.label331.Location = new System.Drawing.Point(118, 174);
            this.label331.Name = "label331";
            this.label331.Size = new System.Drawing.Size(68, 24);
            this.label331.TabIndex = 46;
            this.label331.Text = "Branş :";
            // 
            // TxtSifre
            // 
            this.TxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSifre.Location = new System.Drawing.Point(192, 212);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(167, 29);
            this.TxtSifre.TabIndex = 5;
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AcceptButton = this.BtnBilgiDuzenle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(493, 453);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label331);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.BtnBilgiDuzenle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBilgiDuzenle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label331;
        private System.Windows.Forms.TextBox TxtSifre;
    }
}