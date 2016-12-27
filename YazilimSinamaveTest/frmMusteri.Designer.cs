namespace YazilimSinamaveTest
{
    partial class frmMusteri
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
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.lblProjeAdi = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.lblButce = new System.Windows.Forms.Label();
            this.cmbProjeYöneticisi = new System.Windows.Forms.ComboBox();
            this.lblProjeYoneticisi = new System.Windows.Forms.Label();
            this.txtProjeAciklamasi = new System.Windows.Forms.RichTextBox();
            this.lblProjeAciklamasi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProjeEkle = new System.Windows.Forms.Button();
            this.chbAktif = new System.Windows.Forms.CheckBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtButce2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.progressBarTamamlanmaOrani = new System.Windows.Forms.ProgressBar();
            this.btnProjeSil = new System.Windows.Forms.Button();
            this.lblOran = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtButce2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(12, 28);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(292, 20);
            this.txtProjeAdi.TabIndex = 0;
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.AutoSize = true;
            this.lblProjeAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeAdi.Location = new System.Drawing.Point(12, 12);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(49, 13);
            this.lblProjeAdi.TabIndex = 1;
            this.lblProjeAdi.Text = "Proje Adı";
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(90, 170);
            this.dtpBaslangicTarihi.MinDate = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(125, 20);
            this.dtpBaslangicTarihi.TabIndex = 2;
            this.dtpBaslangicTarihi.ValueChanged += new System.EventHandler(this.dtpBaslangicTarihi_ValueChanged);
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitisTarihi.Location = new System.Drawing.Point(90, 197);
            this.dtpBitisTarihi.MinDate = new System.DateTime(2016, 12, 26, 0, 0, 0, 0);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(125, 20);
            this.dtpBitisTarihi.TabIndex = 3;
            this.dtpBitisTarihi.ValueChanged += new System.EventHandler(this.dtpBitisTarihi_ValueChanged);
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(9, 168);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(76, 13);
            this.lblBaslangicTarihi.TabIndex = 4;
            this.lblBaslangicTarihi.Text = "Başlama Tarihi";
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblBitisTarihi.Location = new System.Drawing.Point(9, 197);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(55, 13);
            this.lblBitisTarihi.TabIndex = 5;
            this.lblBitisTarihi.Text = "Bitiş Tarihi";
            // 
            // lblButce
            // 
            this.lblButce.AutoSize = true;
            this.lblButce.BackColor = System.Drawing.Color.Transparent;
            this.lblButce.Location = new System.Drawing.Point(9, 249);
            this.lblButce.Name = "lblButce";
            this.lblButce.Size = new System.Drawing.Size(35, 13);
            this.lblButce.TabIndex = 6;
            this.lblButce.Text = "Bütçe";
            // 
            // cmbProjeYöneticisi
            // 
            this.cmbProjeYöneticisi.FormattingEnabled = true;
            this.cmbProjeYöneticisi.Location = new System.Drawing.Point(90, 143);
            this.cmbProjeYöneticisi.Name = "cmbProjeYöneticisi";
            this.cmbProjeYöneticisi.Size = new System.Drawing.Size(125, 21);
            this.cmbProjeYöneticisi.TabIndex = 8;
            // 
            // lblProjeYoneticisi
            // 
            this.lblProjeYoneticisi.AutoSize = true;
            this.lblProjeYoneticisi.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeYoneticisi.Location = new System.Drawing.Point(9, 143);
            this.lblProjeYoneticisi.Name = "lblProjeYoneticisi";
            this.lblProjeYoneticisi.Size = new System.Drawing.Size(79, 13);
            this.lblProjeYoneticisi.TabIndex = 9;
            this.lblProjeYoneticisi.Text = "Proje Yöneticisi";
            // 
            // txtProjeAciklamasi
            // 
            this.txtProjeAciklamasi.Location = new System.Drawing.Point(12, 67);
            this.txtProjeAciklamasi.Name = "txtProjeAciklamasi";
            this.txtProjeAciklamasi.Size = new System.Drawing.Size(292, 73);
            this.txtProjeAciklamasi.TabIndex = 10;
            this.txtProjeAciklamasi.Text = "";
            // 
            // lblProjeAciklamasi
            // 
            this.lblProjeAciklamasi.AutoSize = true;
            this.lblProjeAciklamasi.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeAciklamasi.Location = new System.Drawing.Point(9, 51);
            this.lblProjeAciklamasi.Name = "lblProjeAciklamasi";
            this.lblProjeAciklamasi.Size = new System.Drawing.Size(84, 13);
            this.lblProjeAciklamasi.TabIndex = 11;
            this.lblProjeAciklamasi.Text = "Proje Açıklaması";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIDDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.finishDateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.budgetDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.createUserNameDataGridViewTextBoxColumn,
            this.projectUserNameDataGridViewTextBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(327, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(870, 241);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjeID";
            this.projectIDDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIDDataGridViewTextBoxColumn.ToolTipText = "Projenin Veritabanındaki Sıra Numarası";
            this.projectIDDataGridViewTextBoxColumn.Width = 67;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectNameDataGridViewTextBoxColumn.Width = 93;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 77;
            // 
            // finishDateDataGridViewTextBoxColumn
            // 
            this.finishDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.finishDateDataGridViewTextBoxColumn.DataPropertyName = "FinishDate";
            this.finishDateDataGridViewTextBoxColumn.HeaderText = "FinishDate";
            this.finishDateDataGridViewTextBoxColumn.Name = "finishDateDataGridViewTextBoxColumn";
            this.finishDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.finishDateDataGridViewTextBoxColumn.Width = 82;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 50;
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "Budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "Budget";
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            this.budgetDataGridViewTextBoxColumn.ReadOnly = true;
            this.budgetDataGridViewTextBoxColumn.Width = 66;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Width = 86;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // createUserNameDataGridViewTextBoxColumn
            // 
            this.createUserNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.createUserNameDataGridViewTextBoxColumn.DataPropertyName = "CreateUserName";
            this.createUserNameDataGridViewTextBoxColumn.HeaderText = "CreateUserName";
            this.createUserNameDataGridViewTextBoxColumn.Name = "createUserNameDataGridViewTextBoxColumn";
            this.createUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.createUserNameDataGridViewTextBoxColumn.Width = 113;
            // 
            // projectUserNameDataGridViewTextBoxColumn
            // 
            this.projectUserNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.projectUserNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectUserName";
            this.projectUserNameDataGridViewTextBoxColumn.HeaderText = "ProjectUserName";
            this.projectUserNameDataGridViewTextBoxColumn.Name = "projectUserNameDataGridViewTextBoxColumn";
            this.projectUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectUserNameDataGridViewTextBoxColumn.Width = 115;
            // 
            // btnProjeEkle
            // 
            this.btnProjeEkle.Location = new System.Drawing.Point(224, 217);
            this.btnProjeEkle.Name = "btnProjeEkle";
            this.btnProjeEkle.Size = new System.Drawing.Size(85, 24);
            this.btnProjeEkle.TabIndex = 13;
            this.btnProjeEkle.Text = "Proje Ekle";
            this.btnProjeEkle.UseVisualStyleBackColor = true;
            this.btnProjeEkle.Click += new System.EventHandler(this.btnProjeEkle_Click);
            // 
            // chbAktif
            // 
            this.chbAktif.AutoSize = true;
            this.chbAktif.BackColor = System.Drawing.Color.Transparent;
            this.chbAktif.Location = new System.Drawing.Point(141, 226);
            this.chbAktif.Name = "chbAktif";
            this.chbAktif.Size = new System.Drawing.Size(74, 17);
            this.chbAktif.TabIndex = 14;
            this.chbAktif.Text = "Proje Aktif";
            this.chbAktif.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(224, 243);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Proje Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtButce2
            // 
            this.txtButce2.Location = new System.Drawing.Point(90, 249);
            this.txtButce2.Name = "txtButce2";
            this.txtButce2.Size = new System.Drawing.Size(125, 20);
            this.txtButce2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Süre(Gün)";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(90, 223);
            this.txtSure.Name = "txtSure";
            this.txtSure.ReadOnly = true;
            this.txtSure.Size = new System.Drawing.Size(30, 20);
            this.txtSure.TabIndex = 18;
            // 
            // progressBarTamamlanmaOrani
            // 
            this.progressBarTamamlanmaOrani.Location = new System.Drawing.Point(224, 140);
            this.progressBarTamamlanmaOrani.Name = "progressBarTamamlanmaOrani";
            this.progressBarTamamlanmaOrani.Size = new System.Drawing.Size(85, 21);
            this.progressBarTamamlanmaOrani.TabIndex = 19;
            // 
            // btnProjeSil
            // 
            this.btnProjeSil.Location = new System.Drawing.Point(224, 192);
            this.btnProjeSil.Name = "btnProjeSil";
            this.btnProjeSil.Size = new System.Drawing.Size(85, 24);
            this.btnProjeSil.TabIndex = 20;
            this.btnProjeSil.Text = "Proje Sil";
            this.btnProjeSil.UseVisualStyleBackColor = true;
            this.btnProjeSil.Click += new System.EventHandler(this.btnProjeSil_Click);
            // 
            // lblOran
            // 
            this.lblOran.AutoSize = true;
            this.lblOran.Location = new System.Drawing.Point(260, 176);
            this.lblOran.Name = "lblOran";
            this.lblOran.Size = new System.Drawing.Size(10, 13);
            this.lblOran.TabIndex = 21;
            this.lblOran.Text = "-";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::YazilimSinamaveTest.Properties.Resources.Back_icon;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(10, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 24);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YazilimSinamaveTest.Properties.Resources.bck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 294);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblOran);
            this.Controls.Add(this.btnProjeSil);
            this.Controls.Add(this.progressBarTamamlanmaOrani);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtButce2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.chbAktif);
            this.Controls.Add(this.btnProjeEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProjeAciklamasi);
            this.Controls.Add(this.txtProjeAciklamasi);
            this.Controls.Add(this.lblProjeYoneticisi);
            this.Controls.Add(this.cmbProjeYöneticisi);
            this.Controls.Add(this.lblButce);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.lblProjeAdi);
            this.Controls.Add(this.txtProjeAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteri";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtButce2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjeAdi;
        private System.Windows.Forms.Label lblProjeAdi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblButce;
        private System.Windows.Forms.ComboBox cmbProjeYöneticisi;
        private System.Windows.Forms.Label lblProjeYoneticisi;
        private System.Windows.Forms.RichTextBox txtProjeAciklamasi;
        private System.Windows.Forms.Label lblProjeAciklamasi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProjeEkle;
        private System.Windows.Forms.CheckBox chbAktif;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.NumericUpDown txtButce2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ProgressBar progressBarTamamlanmaOrani;
        private System.Windows.Forms.Button btnProjeSil;
        private System.Windows.Forms.Label lblOran;
        private System.Windows.Forms.Button btnBack;
    }
}