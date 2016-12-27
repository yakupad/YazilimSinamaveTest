namespace YazilimSinamaveTest
{
    partial class frmKullaniciIslemleri
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
            this.comboBoxUyeler = new System.Windows.Forms.ComboBox();
            this.checkBoxMusteri = new System.Windows.Forms.CheckBox();
            this.checkBoxYonetici = new System.Windows.Forms.CheckBox();
            this.checkBoxYazilimci = new System.Windows.Forms.CheckBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxKullanıcıAd = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKulAdi = new System.Windows.Forms.Label();
            this.lblKulSoyadi = new System.Windows.Forms.Label();
            this.lblKulNickName = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblKayıtTarihi = new System.Windows.Forms.Label();
            this.dateTimePickerKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBoxUyeler
            // 
            this.comboBoxUyeler.FormattingEnabled = true;
            this.comboBoxUyeler.Location = new System.Drawing.Point(12, 27);
            this.comboBoxUyeler.Name = "comboBoxUyeler";
            this.comboBoxUyeler.Size = new System.Drawing.Size(202, 21);
            this.comboBoxUyeler.TabIndex = 0;
            this.comboBoxUyeler.SelectedIndexChanged += new System.EventHandler(this.comboBoxUyeler_SelectedIndexChanged);
            // 
            // checkBoxMusteri
            // 
            this.checkBoxMusteri.AutoSize = true;
            this.checkBoxMusteri.Location = new System.Drawing.Point(12, 58);
            this.checkBoxMusteri.Name = "checkBoxMusteri";
            this.checkBoxMusteri.Size = new System.Drawing.Size(60, 17);
            this.checkBoxMusteri.TabIndex = 1;
            this.checkBoxMusteri.Text = "Müşteri";
            this.checkBoxMusteri.UseVisualStyleBackColor = true;
            this.checkBoxMusteri.CheckedChanged += new System.EventHandler(this.checkBoxMusteri_CheckedChanged);
            // 
            // checkBoxYonetici
            // 
            this.checkBoxYonetici.AutoSize = true;
            this.checkBoxYonetici.Location = new System.Drawing.Point(150, 58);
            this.checkBoxYonetici.Name = "checkBoxYonetici";
            this.checkBoxYonetici.Size = new System.Drawing.Size(64, 17);
            this.checkBoxYonetici.TabIndex = 2;
            this.checkBoxYonetici.Text = "Yönetici";
            this.checkBoxYonetici.UseVisualStyleBackColor = true;
            this.checkBoxYonetici.CheckedChanged += new System.EventHandler(this.checkBoxYonetici_CheckedChanged);
            // 
            // checkBoxYazilimci
            // 
            this.checkBoxYazilimci.AutoSize = true;
            this.checkBoxYazilimci.Location = new System.Drawing.Point(78, 58);
            this.checkBoxYazilimci.Name = "checkBoxYazilimci";
            this.checkBoxYazilimci.Size = new System.Drawing.Size(66, 17);
            this.checkBoxYazilimci.TabIndex = 3;
            this.checkBoxYazilimci.Text = "Yazılımcı";
            this.checkBoxYazilimci.UseVisualStyleBackColor = true;
            this.checkBoxYazilimci.CheckedChanged += new System.EventHandler(this.checkBoxYazilimci_CheckedChanged);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(90, 83);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(124, 20);
            this.textBoxAd.TabIndex = 4;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(90, 109);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(124, 20);
            this.textBoxSoyad.TabIndex = 5;
            // 
            // textBoxKullanıcıAd
            // 
            this.textBoxKullanıcıAd.Location = new System.Drawing.Point(90, 135);
            this.textBoxKullanıcıAd.Name = "textBoxKullanıcıAd";
            this.textBoxKullanıcıAd.Size = new System.Drawing.Size(124, 20);
            this.textBoxKullanıcıAd.TabIndex = 6;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(90, 161);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(124, 20);
            this.textBoxParola.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı İsmi Seçiniz";
            // 
            // lblKulAdi
            // 
            this.lblKulAdi.AutoSize = true;
            this.lblKulAdi.Location = new System.Drawing.Point(12, 86);
            this.lblKulAdi.Name = "lblKulAdi";
            this.lblKulAdi.Size = new System.Drawing.Size(22, 13);
            this.lblKulAdi.TabIndex = 10;
            this.lblKulAdi.Text = "Adı";
            // 
            // lblKulSoyadi
            // 
            this.lblKulSoyadi.AutoSize = true;
            this.lblKulSoyadi.Location = new System.Drawing.Point(12, 112);
            this.lblKulSoyadi.Name = "lblKulSoyadi";
            this.lblKulSoyadi.Size = new System.Drawing.Size(39, 13);
            this.lblKulSoyadi.TabIndex = 11;
            this.lblKulSoyadi.Text = "Soyadı";
            // 
            // lblKulNickName
            // 
            this.lblKulNickName.AutoSize = true;
            this.lblKulNickName.Location = new System.Drawing.Point(12, 138);
            this.lblKulNickName.Name = "lblKulNickName";
            this.lblKulNickName.Size = new System.Drawing.Size(64, 13);
            this.lblKulNickName.TabIndex = 12;
            this.lblKulNickName.Text = "Kullanıcı Adı";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(12, 164);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(37, 13);
            this.lblParola.TabIndex = 13;
            this.lblParola.Text = "Parola";
            // 
            // lblKayıtTarihi
            // 
            this.lblKayıtTarihi.AutoSize = true;
            this.lblKayıtTarihi.Location = new System.Drawing.Point(12, 190);
            this.lblKayıtTarihi.Name = "lblKayıtTarihi";
            this.lblKayıtTarihi.Size = new System.Drawing.Size(59, 13);
            this.lblKayıtTarihi.TabIndex = 14;
            this.lblKayıtTarihi.Text = "Kayıt Tarihi";
            // 
            // dateTimePickerKayitTarihi
            // 
            this.dateTimePickerKayitTarihi.Enabled = false;
            this.dateTimePickerKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerKayitTarihi.Location = new System.Drawing.Point(90, 190);
            this.dateTimePickerKayitTarihi.Name = "dateTimePickerKayitTarihi";
            this.dateTimePickerKayitTarihi.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerKayitTarihi.TabIndex = 0;
            // 
            // frmKullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 226);
            this.Controls.Add(this.dateTimePickerKayitTarihi);
            this.Controls.Add(this.lblKayıtTarihi);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKulNickName);
            this.Controls.Add(this.lblKulSoyadi);
            this.Controls.Add(this.lblKulAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxKullanıcıAd);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.checkBoxYazilimci);
            this.Controls.Add(this.checkBoxYonetici);
            this.Controls.Add(this.checkBoxMusteri);
            this.Controls.Add(this.comboBoxUyeler);
            this.Name = "frmKullaniciIslemleri";
            this.Text = "frmKullaniciIslemleri";
            this.Load += new System.EventHandler(this.frmKullaniciIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUyeler;
        private System.Windows.Forms.CheckBox checkBoxMusteri;
        private System.Windows.Forms.CheckBox checkBoxYonetici;
        private System.Windows.Forms.CheckBox checkBoxYazilimci;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxKullanıcıAd;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKulAdi;
        private System.Windows.Forms.Label lblKulSoyadi;
        private System.Windows.Forms.Label lblKulNickName;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblKayıtTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerKayitTarihi;
    }
}