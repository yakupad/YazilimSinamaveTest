namespace YazilimSinamaveTest
{
    partial class frmYonetici
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tüm Görevler");
            this.treeViewGorevler = new System.Windows.Forms.TreeView();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.groupBoxIslemler = new System.Windows.Forms.GroupBox();
            this.lblTOrani = new System.Windows.Forms.Label();
            this.btnSurecAkisiGoruntule = new System.Windows.Forms.Button();
            this.lblNotlar = new System.Windows.Forms.Label();
            this.lblAciklamalar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurecSahibi = new System.Windows.Forms.TextBox();
            this.lblOlusturulmaTarihi = new System.Windows.Forms.Label();
            this.dateTimePickerOlusturulma = new System.Windows.Forms.DateTimePicker();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblOncelik = new System.Windows.Forms.Label();
            this.lblTamamlanmaOrani = new System.Windows.Forms.Label();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblYazılımcıAta = new System.Windows.Forms.Label();
            this.lblGorevAdi = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtGorevAdi = new System.Windows.Forms.TextBox();
            this.btnYazilimciSil = new System.Windows.Forms.Button();
            this.richTextBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.richTextBoxNotlar = new System.Windows.Forms.RichTextBox();
            this.progressBarGorev = new System.Windows.Forms.ProgressBar();
            this.btnYazilimciEkle = new System.Windows.Forms.Button();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.cmbYazilimcilar = new System.Windows.Forms.ComboBox();
            this.listBoxYazilimcilar = new System.Windows.Forms.ListBox();
            this.txtGorevSuresi = new System.Windows.Forms.TextBox();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.txtOncelik = new System.Windows.Forms.TextBox();
            this.lblGunSayisi = new System.Windows.Forms.Label();
            this.lblprocessID = new System.Windows.Forms.Label();
            this.cmbProjeler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKulIslemleri = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewGorevler
            // 
            this.treeViewGorevler.Location = new System.Drawing.Point(12, 53);
            this.treeViewGorevler.Name = "treeViewGorevler";
            treeNode2.Name = "0";
            treeNode2.Text = "Tüm Görevler";
            this.treeViewGorevler.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewGorevler.Size = new System.Drawing.Size(259, 375);
            this.treeViewGorevler.TabIndex = 0;
            this.treeViewGorevler.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewGorevler_NodeMouseClick);
            this.treeViewGorevler.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewGorevler_NodeMouseDoubleClick);
            this.treeViewGorevler.Click += new System.EventHandler(this.treeViewGorevler_Click);
            this.treeViewGorevler.Enter += new System.EventHandler(this.treeViewGorevler_Enter);
            this.treeViewGorevler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewGorevler_KeyDown);
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Location = new System.Drawing.Point(333, 286);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(186, 33);
            this.btnGorevEkle.TabIndex = 2;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // groupBoxIslemler
            // 
            this.groupBoxIslemler.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxIslemler.Controls.Add(this.lblTOrani);
            this.groupBoxIslemler.Controls.Add(this.btnSurecAkisiGoruntule);
            this.groupBoxIslemler.Controls.Add(this.lblNotlar);
            this.groupBoxIslemler.Controls.Add(this.lblAciklamalar);
            this.groupBoxIslemler.Controls.Add(this.label1);
            this.groupBoxIslemler.Controls.Add(this.txtSurecSahibi);
            this.groupBoxIslemler.Controls.Add(this.lblOlusturulmaTarihi);
            this.groupBoxIslemler.Controls.Add(this.dateTimePickerOlusturulma);
            this.groupBoxIslemler.Controls.Add(this.lblGun);
            this.groupBoxIslemler.Controls.Add(this.lblOncelik);
            this.groupBoxIslemler.Controls.Add(this.lblTamamlanmaOrani);
            this.groupBoxIslemler.Controls.Add(this.lblBitisTarihi);
            this.groupBoxIslemler.Controls.Add(this.lblBaslangicTarihi);
            this.groupBoxIslemler.Controls.Add(this.lblYazılımcıAta);
            this.groupBoxIslemler.Controls.Add(this.lblGorevAdi);
            this.groupBoxIslemler.Controls.Add(this.btnGuncelle);
            this.groupBoxIslemler.Controls.Add(this.btnSil);
            this.groupBoxIslemler.Controls.Add(this.btnTemizle);
            this.groupBoxIslemler.Controls.Add(this.btnGorevEkle);
            this.groupBoxIslemler.Controls.Add(this.txtGorevAdi);
            this.groupBoxIslemler.Controls.Add(this.btnYazilimciSil);
            this.groupBoxIslemler.Controls.Add(this.richTextBoxAciklama);
            this.groupBoxIslemler.Controls.Add(this.richTextBoxNotlar);
            this.groupBoxIslemler.Controls.Add(this.progressBarGorev);
            this.groupBoxIslemler.Controls.Add(this.btnYazilimciEkle);
            this.groupBoxIslemler.Controls.Add(this.dateTimePickerBaslangic);
            this.groupBoxIslemler.Controls.Add(this.cmbYazilimcilar);
            this.groupBoxIslemler.Controls.Add(this.listBoxYazilimcilar);
            this.groupBoxIslemler.Controls.Add(this.txtGorevSuresi);
            this.groupBoxIslemler.Controls.Add(this.dateTimePickerBitis);
            this.groupBoxIslemler.Controls.Add(this.txtOncelik);
            this.groupBoxIslemler.Controls.Add(this.lblGunSayisi);
            this.groupBoxIslemler.Controls.Add(this.lblprocessID);
            this.groupBoxIslemler.Location = new System.Drawing.Point(278, 12);
            this.groupBoxIslemler.Name = "groupBoxIslemler";
            this.groupBoxIslemler.Size = new System.Drawing.Size(530, 416);
            this.groupBoxIslemler.TabIndex = 4;
            this.groupBoxIslemler.TabStop = false;
            this.groupBoxIslemler.Text = "groupBoxGorevIslemleri";
            this.groupBoxIslemler.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTOrani
            // 
            this.lblTOrani.AutoSize = true;
            this.lblTOrani.Location = new System.Drawing.Point(47, 130);
            this.lblTOrani.Name = "lblTOrani";
            this.lblTOrani.Size = new System.Drawing.Size(15, 13);
            this.lblTOrani.TabIndex = 35;
            this.lblTOrani.Text = "%";
            // 
            // btnSurecAkisiGoruntule
            // 
            this.btnSurecAkisiGoruntule.Location = new System.Drawing.Point(5, 368);
            this.btnSurecAkisiGoruntule.Name = "btnSurecAkisiGoruntule";
            this.btnSurecAkisiGoruntule.Size = new System.Drawing.Size(322, 32);
            this.btnSurecAkisiGoruntule.TabIndex = 34;
            this.btnSurecAkisiGoruntule.Text = "Süreç İş Akışını Görüntüle";
            this.btnSurecAkisiGoruntule.UseVisualStyleBackColor = true;
            this.btnSurecAkisiGoruntule.Click += new System.EventHandler(this.btnSurecAkisiGoruntule_Click);
            // 
            // lblNotlar
            // 
            this.lblNotlar.AutoSize = true;
            this.lblNotlar.Location = new System.Drawing.Point(9, 250);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(35, 13);
            this.lblNotlar.TabIndex = 33;
            this.lblNotlar.Text = "Notlar";
            // 
            // lblAciklamalar
            // 
            this.lblAciklamalar.AutoSize = true;
            this.lblAciklamalar.Location = new System.Drawing.Point(9, 156);
            this.lblAciklamalar.Name = "lblAciklamalar";
            this.lblAciklamalar.Size = new System.Drawing.Size(61, 13);
            this.lblAciklamalar.TabIndex = 32;
            this.lblAciklamalar.Text = "Açıklamalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Proje Sahibi";
            // 
            // txtSurecSahibi
            // 
            this.txtSurecSahibi.Enabled = false;
            this.txtSurecSahibi.Location = new System.Drawing.Point(216, 127);
            this.txtSurecSahibi.Name = "txtSurecSahibi";
            this.txtSurecSahibi.Size = new System.Drawing.Size(108, 20);
            this.txtSurecSahibi.TabIndex = 30;
            // 
            // lblOlusturulmaTarihi
            // 
            this.lblOlusturulmaTarihi.AutoSize = true;
            this.lblOlusturulmaTarihi.Location = new System.Drawing.Point(333, 25);
            this.lblOlusturulmaTarihi.Name = "lblOlusturulmaTarihi";
            this.lblOlusturulmaTarihi.Size = new System.Drawing.Size(91, 13);
            this.lblOlusturulmaTarihi.TabIndex = 29;
            this.lblOlusturulmaTarihi.Text = "Oluşturulma Tarihi";
            // 
            // dateTimePickerOlusturulma
            // 
            this.dateTimePickerOlusturulma.Enabled = false;
            this.dateTimePickerOlusturulma.Location = new System.Drawing.Point(333, 41);
            this.dateTimePickerOlusturulma.Name = "dateTimePickerOlusturulma";
            this.dateTimePickerOlusturulma.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerOlusturulma.TabIndex = 28;
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(295, 88);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(27, 13);
            this.lblGun.TabIndex = 27;
            this.lblGun.Text = "Gün";
            // 
            // lblOncelik
            // 
            this.lblOncelik.AutoSize = true;
            this.lblOncelik.Location = new System.Drawing.Point(171, 111);
            this.lblOncelik.Name = "lblOncelik";
            this.lblOncelik.Size = new System.Drawing.Size(43, 13);
            this.lblOncelik.TabIndex = 26;
            this.lblOncelik.Text = "Öncelik";
            // 
            // lblTamamlanmaOrani
            // 
            this.lblTamamlanmaOrani.AutoSize = true;
            this.lblTamamlanmaOrani.Location = new System.Drawing.Point(9, 110);
            this.lblTamamlanmaOrani.Name = "lblTamamlanmaOrani";
            this.lblTamamlanmaOrani.Size = new System.Drawing.Size(98, 13);
            this.lblTamamlanmaOrani.TabIndex = 25;
            this.lblTamamlanmaOrani.Text = "Tamamlanma Oranı";
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(140, 68);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(105, 13);
            this.lblBitisTarihi.TabIndex = 24;
            this.lblBitisTarihi.Text = "Planlanan Bitiş Tarihi";
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(2, 68);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(132, 13);
            this.lblBaslangicTarihi.TabIndex = 23;
            this.lblBaslangicTarihi.Text = "Planlanan Başlangıç Tarihi";
            // 
            // lblYazılımcıAta
            // 
            this.lblYazılımcıAta.AutoSize = true;
            this.lblYazılımcıAta.Location = new System.Drawing.Point(330, 69);
            this.lblYazılımcıAta.Name = "lblYazılımcıAta";
            this.lblYazılımcıAta.Size = new System.Drawing.Size(80, 13);
            this.lblYazılımcıAta.TabIndex = 22;
            this.lblYazılımcıAta.Text = "Yazılımcı Atama";
            // 
            // lblGorevAdi
            // 
            this.lblGorevAdi.AutoSize = true;
            this.lblGorevAdi.Location = new System.Drawing.Point(6, 25);
            this.lblGorevAdi.Name = "lblGorevAdi";
            this.lblGorevAdi.Size = new System.Drawing.Size(54, 13);
            this.lblGorevAdi.TabIndex = 21;
            this.lblGorevAdi.Text = "Görev Adı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(333, 325);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(186, 36);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Görev Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(333, 364);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(186, 36);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Görev Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(333, 244);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(186, 36);
            this.btnTemizle.TabIndex = 20;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtGorevAdi
            // 
            this.txtGorevAdi.Location = new System.Drawing.Point(4, 41);
            this.txtGorevAdi.Name = "txtGorevAdi";
            this.txtGorevAdi.Size = new System.Drawing.Size(318, 20);
            this.txtGorevAdi.TabIndex = 5;
            // 
            // btnYazilimciSil
            // 
            this.btnYazilimciSil.Location = new System.Drawing.Point(432, 110);
            this.btnYazilimciSil.Name = "btnYazilimciSil";
            this.btnYazilimciSil.Size = new System.Drawing.Size(87, 36);
            this.btnYazilimciSil.TabIndex = 19;
            this.btnYazilimciSil.Text = "Yazılımcı Kaldır";
            this.btnYazilimciSil.UseVisualStyleBackColor = true;
            this.btnYazilimciSil.Click += new System.EventHandler(this.btnYazilimciSil_Click);
            // 
            // richTextBoxAciklama
            // 
            this.richTextBoxAciklama.Location = new System.Drawing.Point(6, 172);
            this.richTextBoxAciklama.Name = "richTextBoxAciklama";
            this.richTextBoxAciklama.Size = new System.Drawing.Size(318, 68);
            this.richTextBoxAciklama.TabIndex = 10;
            this.richTextBoxAciklama.Text = "";
            this.richTextBoxAciklama.TextChanged += new System.EventHandler(this.richTextBoxAciklama_TextChanged);
            // 
            // richTextBoxNotlar
            // 
            this.richTextBoxNotlar.Location = new System.Drawing.Point(6, 266);
            this.richTextBoxNotlar.Name = "richTextBoxNotlar";
            this.richTextBoxNotlar.Size = new System.Drawing.Size(318, 95);
            this.richTextBoxNotlar.TabIndex = 11;
            this.richTextBoxNotlar.Text = "";
            // 
            // progressBarGorev
            // 
            this.progressBarGorev.Location = new System.Drawing.Point(9, 126);
            this.progressBarGorev.Name = "progressBarGorev";
            this.progressBarGorev.Size = new System.Drawing.Size(164, 23);
            this.progressBarGorev.TabIndex = 8;
            // 
            // btnYazilimciEkle
            // 
            this.btnYazilimciEkle.Location = new System.Drawing.Point(333, 110);
            this.btnYazilimciEkle.Name = "btnYazilimciEkle";
            this.btnYazilimciEkle.Size = new System.Drawing.Size(91, 37);
            this.btnYazilimciEkle.TabIndex = 16;
            this.btnYazilimciEkle.Text = "Yazılımcı Ekle";
            this.btnYazilimciEkle.UseVisualStyleBackColor = true;
            this.btnYazilimciEkle.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(6, 85);
            this.dateTimePickerBaslangic.MinDate = new System.DateTime(2016, 12, 28, 0, 0, 0, 0);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerBaslangic.TabIndex = 6;
            // 
            // cmbYazilimcilar
            // 
            this.cmbYazilimcilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYazilimcilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbYazilimcilar.FormattingEnabled = true;
            this.cmbYazilimcilar.Location = new System.Drawing.Point(333, 85);
            this.cmbYazilimcilar.Name = "cmbYazilimcilar";
            this.cmbYazilimcilar.Size = new System.Drawing.Size(186, 21);
            this.cmbYazilimcilar.TabIndex = 13;
            // 
            // listBoxYazilimcilar
            // 
            this.listBoxYazilimcilar.FormattingEnabled = true;
            this.listBoxYazilimcilar.Location = new System.Drawing.Point(333, 153);
            this.listBoxYazilimcilar.Name = "listBoxYazilimcilar";
            this.listBoxYazilimcilar.Size = new System.Drawing.Size(184, 82);
            this.listBoxYazilimcilar.TabIndex = 15;
            this.listBoxYazilimcilar.SelectedIndexChanged += new System.EventHandler(this.listBoxYazilimcilar_SelectedIndexChanged);
            // 
            // txtGorevSuresi
            // 
            this.txtGorevSuresi.Enabled = false;
            this.txtGorevSuresi.Location = new System.Drawing.Point(259, 85);
            this.txtGorevSuresi.Name = "txtGorevSuresi";
            this.txtGorevSuresi.Size = new System.Drawing.Size(65, 20);
            this.txtGorevSuresi.TabIndex = 13;
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBitis.Location = new System.Drawing.Point(134, 85);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(115, 20);
            this.dateTimePickerBitis.TabIndex = 7;
            this.dateTimePickerBitis.ValueChanged += new System.EventHandler(this.dateTimePickerBitis_ValueChanged);
            // 
            // txtOncelik
            // 
            this.txtOncelik.Location = new System.Drawing.Point(176, 127);
            this.txtOncelik.Name = "txtOncelik";
            this.txtOncelik.Size = new System.Drawing.Size(34, 20);
            this.txtOncelik.TabIndex = 9;
            // 
            // lblGunSayisi
            // 
            this.lblGunSayisi.AutoSize = true;
            this.lblGunSayisi.Location = new System.Drawing.Point(256, 69);
            this.lblGunSayisi.Name = "lblGunSayisi";
            this.lblGunSayisi.Size = new System.Drawing.Size(68, 13);
            this.lblGunSayisi.TabIndex = 12;
            this.lblGunSayisi.Text = "Görev Süresi";
            // 
            // lblprocessID
            // 
            this.lblprocessID.AutoSize = true;
            this.lblprocessID.Location = new System.Drawing.Point(89, 45);
            this.lblprocessID.Name = "lblprocessID";
            this.lblprocessID.Size = new System.Drawing.Size(13, 13);
            this.lblprocessID.TabIndex = 14;
            this.lblprocessID.Text = "0";
            // 
            // cmbProjeler
            // 
            this.cmbProjeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjeler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProjeler.FormattingEnabled = true;
            this.cmbProjeler.Location = new System.Drawing.Point(12, 29);
            this.cmbProjeler.Name = "cmbProjeler";
            this.cmbProjeler.Size = new System.Drawing.Size(259, 21);
            this.cmbProjeler.TabIndex = 4;
            this.cmbProjeler.SelectedIndexChanged += new System.EventHandler(this.cmbProjeler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proje Seçiniz";
            // 
            // btnKulIslemleri
            // 
            this.btnKulIslemleri.Location = new System.Drawing.Point(814, 11);
            this.btnKulIslemleri.Name = "btnKulIslemleri";
            this.btnKulIslemleri.Size = new System.Drawing.Size(27, 319);
            this.btnKulIslemleri.TabIndex = 6;
            this.btnKulIslemleri.Text = "K\r\nU\r\nL\r\nL\r\nA\r\nN\r\nI\r\nC\r\nI\r\n\r\nR\r\nO\r\nL\r\n\r\nİ\r\nŞ\r\nL\r\nE\r\nM\r\nL\r\nE\r\nR\r\nİ\r\n";
            this.btnKulIslemleri.UseVisualStyleBackColor = true;
            this.btnKulIslemleri.Click += new System.EventHandler(this.btnKulIslemleri_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::YazilimSinamaveTest.Properties.Resources.Back_icon;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(12, 428);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 24);
            this.btnBack.TabIndex = 23;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 97);
            this.button1.TabIndex = 36;
            this.button1.Text = "L\r\nO\r\nG\r\nL\r\nA\r\nR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YazilimSinamaveTest.Properties.Resources.bck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnKulIslemleri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProjeler);
            this.Controls.Add(this.groupBoxIslemler);
            this.Controls.Add(this.treeViewGorevler);
            this.Name = "frmYonetici";
            this.Text = "frmYonetici";
            this.Load += new System.EventHandler(this.frmYonetici_Load);
            this.groupBoxIslemler.ResumeLayout(false);
            this.groupBoxIslemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewGorevler;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.GroupBox groupBoxIslemler;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.TextBox txtGorevAdi;
        private System.Windows.Forms.ComboBox cmbProjeler;
        private System.Windows.Forms.Label lblGunSayisi;
        private System.Windows.Forms.RichTextBox richTextBoxNotlar;
        private System.Windows.Forms.RichTextBox richTextBoxAciklama;
        private System.Windows.Forms.TextBox txtOncelik;
        private System.Windows.Forms.ProgressBar progressBarGorev;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.ComboBox cmbYazilimcilar;
        private System.Windows.Forms.ListBox listBoxYazilimcilar;
        private System.Windows.Forms.Button btnYazilimciEkle;
       
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtGorevSuresi;
        private System.Windows.Forms.Button btnYazilimciSil;
        private System.Windows.Forms.Label lblprocessID;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.Label lblYazılımcıAta;
        private System.Windows.Forms.Label lblGorevAdi;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblOncelik;
        private System.Windows.Forms.Label lblTamamlanmaOrani;
        private System.Windows.Forms.Label lblOlusturulmaTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerOlusturulma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurecSahibi;
        private System.Windows.Forms.Button btnSurecAkisiGoruntule;
        private System.Windows.Forms.Label lblNotlar;
        private System.Windows.Forms.Label lblAciklamalar;
        private System.Windows.Forms.Label lblTOrani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKulIslemleri;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}