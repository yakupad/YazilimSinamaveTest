namespace YazilimSinamaveTest
{
    partial class frmYazilimci
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGorevler = new System.Windows.Forms.DataGridView();
            this.gorevID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projeadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangictarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitistarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamamlanmaorani = new Sample.DataGridViewProgressColumn();
            this.oncelik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamalar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProgressColumn1 = new Sample.DataGridViewProgressColumn();
            this.groupBoxGörev = new System.Windows.Forms.GroupBox();
            this.lblYuzde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAciklamalar = new System.Windows.Forms.Label();
            this.lblNotlar = new System.Windows.Forms.Label();
            this.richTextBoxNotlar = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.lblOncelik = new System.Windows.Forms.Label();
            this.lblToplamSure = new System.Windows.Forms.Label();
            this.lblProjeAdi = new System.Windows.Forms.Label();
            this.lblGorevAdi = new System.Windows.Forms.Label();
            this.progressBarTorani = new System.Windows.Forms.ProgressBar();
            this.trackBarTorani = new System.Windows.Forms.TrackBar();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGorevler)).BeginInit();
            this.groupBoxGörev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTorani)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGorevler
            // 
            this.dataGridViewGorevler.AllowUserToAddRows = false;
            this.dataGridViewGorevler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewGorevler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGorevler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewGorevler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridViewGorevler.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridViewGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGorevler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gorevID,
            this.gorevadi,
            this.projeadi,
            this.baslangictarihi,
            this.bitistarihi,
            this.sure,
            this.tamamlanmaorani,
            this.oncelik,
            this.notes,
            this.aciklamalar,
            this.müsteri});
            this.dataGridViewGorevler.Location = new System.Drawing.Point(12, 168);
            this.dataGridViewGorevler.Name = "dataGridViewGorevler";
            this.dataGridViewGorevler.ReadOnly = true;
            this.dataGridViewGorevler.Size = new System.Drawing.Size(907, 290);
            this.dataGridViewGorevler.TabIndex = 1;
            this.dataGridViewGorevler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGorevler_CellClick);
            this.dataGridViewGorevler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGorevler_CellContentClick);
            // 
            // gorevID
            // 
            this.gorevID.HeaderText = "Görev ID";
            this.gorevID.Name = "gorevID";
            this.gorevID.ReadOnly = true;
            this.gorevID.Width = 69;
            // 
            // gorevadi
            // 
            this.gorevadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gorevadi.HeaderText = "Görev Adı";
            this.gorevadi.Name = "gorevadi";
            this.gorevadi.ReadOnly = true;
            this.gorevadi.Width = 73;
            // 
            // projeadi
            // 
            this.projeadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.projeadi.HeaderText = "Proje Adı";
            this.projeadi.Name = "projeadi";
            this.projeadi.ReadOnly = true;
            this.projeadi.Width = 69;
            // 
            // baslangictarihi
            // 
            this.baslangictarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.baslangictarihi.HeaderText = "Başlangıç Tarihi";
            this.baslangictarihi.Name = "baslangictarihi";
            this.baslangictarihi.ReadOnly = true;
            this.baslangictarihi.Width = 98;
            // 
            // bitistarihi
            // 
            this.bitistarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bitistarihi.HeaderText = "Bitiş Tarihi";
            this.bitistarihi.Name = "bitistarihi";
            this.bitistarihi.ReadOnly = true;
            this.bitistarihi.Width = 74;
            // 
            // sure
            // 
            this.sure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sure.HeaderText = "Toplam Süre";
            this.sure.Name = "sure";
            this.sure.ReadOnly = true;
            this.sure.Width = 85;
            // 
            // tamamlanmaorani
            // 
            this.tamamlanmaorani.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tamamlanmaorani.HeaderText = "Tamamlanma Oranı";
            this.tamamlanmaorani.Image = global::YazilimSinamaveTest.Properties.Resources.bck;
            this.tamamlanmaorani.Name = "tamamlanmaorani";
            this.tamamlanmaorani.ProgressBarColor = System.Drawing.Color.Lime;
            this.tamamlanmaorani.ReadOnly = true;
            this.tamamlanmaorani.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tamamlanmaorani.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // oncelik
            // 
            this.oncelik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.oncelik.HeaderText = "Öncelik";
            this.oncelik.Name = "oncelik";
            this.oncelik.ReadOnly = true;
            this.oncelik.Width = 68;
            // 
            // notes
            // 
            this.notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.notes.HeaderText = "Notlar";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Width = 60;
            // 
            // aciklamalar
            // 
            this.aciklamalar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aciklamalar.HeaderText = "Açıklamalar";
            this.aciklamalar.Name = "aciklamalar";
            this.aciklamalar.ReadOnly = true;
            this.aciklamalar.Width = 86;
            // 
            // müsteri
            // 
            this.müsteri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.müsteri.HeaderText = "Müşteri Adı";
            this.müsteri.Name = "müsteri";
            this.müsteri.ReadOnly = true;
            this.müsteri.Width = 78;
            // 
            // dataGridViewProgressColumn1
            // 
            this.dataGridViewProgressColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewProgressColumn1.HeaderText = "Tamamlanma Oranı";
            this.dataGridViewProgressColumn1.Name = "dataGridViewProgressColumn1";
            this.dataGridViewProgressColumn1.ProgressBarColor = System.Drawing.Color.Lime;
            this.dataGridViewProgressColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProgressColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBoxGörev
            // 
            this.groupBoxGörev.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGörev.Controls.Add(this.lblYuzde);
            this.groupBoxGörev.Controls.Add(this.label1);
            this.groupBoxGörev.Controls.Add(this.lblAciklamalar);
            this.groupBoxGörev.Controls.Add(this.lblNotlar);
            this.groupBoxGörev.Controls.Add(this.richTextBoxNotlar);
            this.groupBoxGörev.Controls.Add(this.richTextBoxAciklama);
            this.groupBoxGörev.Controls.Add(this.lblMusteriAdi);
            this.groupBoxGörev.Controls.Add(this.lblOncelik);
            this.groupBoxGörev.Controls.Add(this.lblToplamSure);
            this.groupBoxGörev.Controls.Add(this.lblProjeAdi);
            this.groupBoxGörev.Controls.Add(this.lblGorevAdi);
            this.groupBoxGörev.Controls.Add(this.progressBarTorani);
            this.groupBoxGörev.Controls.Add(this.trackBarTorani);
            this.groupBoxGörev.Enabled = false;
            this.groupBoxGörev.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGörev.Name = "groupBoxGörev";
            this.groupBoxGörev.Size = new System.Drawing.Size(907, 150);
            this.groupBoxGörev.TabIndex = 2;
            this.groupBoxGörev.TabStop = false;
            this.groupBoxGörev.Text = "Görev Görüntüle";
            // 
            // lblYuzde
            // 
            this.lblYuzde.AutoSize = true;
            this.lblYuzde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblYuzde.ForeColor = System.Drawing.Color.White;
            this.lblYuzde.Location = new System.Drawing.Point(302, 118);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(15, 13);
            this.lblYuzde.TabIndex = 13;
            this.lblYuzde.Text = "%";
            this.lblYuzde.Click += new System.EventHandler(this.lblYuzde_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(252, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Toplam İlerleme";
            // 
            // lblAciklamalar
            // 
            this.lblAciklamalar.AutoSize = true;
            this.lblAciklamalar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklamalar.Location = new System.Drawing.Point(390, 16);
            this.lblAciklamalar.Name = "lblAciklamalar";
            this.lblAciklamalar.Size = new System.Drawing.Size(90, 19);
            this.lblAciklamalar.TabIndex = 12;
            this.lblAciklamalar.Text = "Açıklamalar";
            // 
            // lblNotlar
            // 
            this.lblNotlar.AutoSize = true;
            this.lblNotlar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotlar.Location = new System.Drawing.Point(653, 16);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(52, 19);
            this.lblNotlar.TabIndex = 11;
            this.lblNotlar.Text = "Notlar";
            // 
            // richTextBoxNotlar
            // 
            this.richTextBoxNotlar.Location = new System.Drawing.Point(649, 39);
            this.richTextBoxNotlar.Name = "richTextBoxNotlar";
            this.richTextBoxNotlar.ReadOnly = true;
            this.richTextBoxNotlar.Size = new System.Drawing.Size(245, 98);
            this.richTextBoxNotlar.TabIndex = 8;
            this.richTextBoxNotlar.Text = "";
            // 
            // richTextBoxAciklama
            // 
            this.richTextBoxAciklama.Location = new System.Drawing.Point(385, 39);
            this.richTextBoxAciklama.Name = "richTextBoxAciklama";
            this.richTextBoxAciklama.ReadOnly = true;
            this.richTextBoxAciklama.Size = new System.Drawing.Size(244, 98);
            this.richTextBoxAciklama.TabIndex = 7;
            this.richTextBoxAciklama.Text = "";
            this.richTextBoxAciklama.TextChanged += new System.EventHandler(this.richTextBoxAciklama_TextChanged);
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAdi.Location = new System.Drawing.Point(6, 118);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(89, 19);
            this.lblMusteriAdi.TabIndex = 6;
            this.lblMusteriAdi.Text = "Müşteri Adı";
            // 
            // lblOncelik
            // 
            this.lblOncelik.AutoSize = true;
            this.lblOncelik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOncelik.Location = new System.Drawing.Point(6, 90);
            this.lblOncelik.Name = "lblOncelik";
            this.lblOncelik.Size = new System.Drawing.Size(61, 19);
            this.lblOncelik.TabIndex = 4;
            this.lblOncelik.Text = "Öncelik";
            // 
            // lblToplamSure
            // 
            this.lblToplamSure.AutoSize = true;
            this.lblToplamSure.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSure.Location = new System.Drawing.Point(6, 65);
            this.lblToplamSure.Name = "lblToplamSure";
            this.lblToplamSure.Size = new System.Drawing.Size(93, 19);
            this.lblToplamSure.TabIndex = 3;
            this.lblToplamSure.Text = "Toplam Süre";
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.AutoSize = true;
            this.lblProjeAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjeAdi.Location = new System.Drawing.Point(6, 39);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(70, 19);
            this.lblProjeAdi.TabIndex = 2;
            this.lblProjeAdi.Text = "Proje Adı";
            this.lblProjeAdi.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblGorevAdi
            // 
            this.lblGorevAdi.AutoSize = true;
            this.lblGorevAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorevAdi.Location = new System.Drawing.Point(6, 16);
            this.lblGorevAdi.Name = "lblGorevAdi";
            this.lblGorevAdi.Size = new System.Drawing.Size(77, 19);
            this.lblGorevAdi.TabIndex = 1;
            this.lblGorevAdi.Text = "Görev Adı";
            // 
            // progressBarTorani
            // 
            this.progressBarTorani.Location = new System.Drawing.Point(252, 114);
            this.progressBarTorani.Name = "progressBarTorani";
            this.progressBarTorani.Size = new System.Drawing.Size(115, 23);
            this.progressBarTorani.TabIndex = 5;
            // 
            // trackBarTorani
            // 
            this.trackBarTorani.Location = new System.Drawing.Point(253, 64);
            this.trackBarTorani.Maximum = 100;
            this.trackBarTorani.Name = "trackBarTorani";
            this.trackBarTorani.Size = new System.Drawing.Size(115, 45);
            this.trackBarTorani.TabIndex = 0;
            this.trackBarTorani.Scroll += new System.EventHandler(this.trackBarTorani_Scroll);
            this.trackBarTorani.ValueChanged += new System.EventHandler(this.trackBarTorani_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::YazilimSinamaveTest.Properties.Resources.Back_icon;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(10, 462);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 24);
            this.btnBack.TabIndex = 23;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmYazilimci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::YazilimSinamaveTest.Properties.Resources.bck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 488);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxGörev);
            this.Controls.Add(this.dataGridViewGorevler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmYazilimci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazılımcı";
            this.Load += new System.EventHandler(this.frmYazilimci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGorevler)).EndInit();
            this.groupBoxGörev.ResumeLayout(false);
            this.groupBoxGörev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTorani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGorevler;
        private Sample.DataGridViewProgressColumn dataGridViewProgressColumn1;
        private System.Windows.Forms.GroupBox groupBoxGörev;
        private System.Windows.Forms.RichTextBox richTextBoxNotlar;
        private System.Windows.Forms.RichTextBox richTextBoxAciklama;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.ProgressBar progressBarTorani;
        private System.Windows.Forms.Label lblOncelik;
        private System.Windows.Forms.Label lblToplamSure;
        private System.Windows.Forms.Label lblProjeAdi;
        private System.Windows.Forms.Label lblGorevAdi;
        private System.Windows.Forms.TrackBar trackBarTorani;
        private System.Windows.Forms.Label lblAciklamalar;
        private System.Windows.Forms.Label lblNotlar;
        private System.Windows.Forms.Label lblYuzde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn projeadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangictarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitistarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sure;
        private Sample.DataGridViewProgressColumn tamamlanmaorani;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncelik;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteri;
        private System.Windows.Forms.Button btnBack;
    }
}