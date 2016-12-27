using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimSinamaveTest
{
    public partial class frmMusteri : Form
    {

        public frmMusteri()
        {
            InitializeComponent();
        }
        yazilimsinamaEntities db = new yazilimsinamaEntities();
        int IndexRow;

        private void DataGridDoldur()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (var item in db.tblProjects.Where(x => x.CreateUserID == frmUyeGiris.uyeID))
            {

                int rowIndex = this.dataGridView1.Rows.Add();
                var row = this.dataGridView1.Rows[rowIndex];


                row.Cells[0].Value = item.ProjectID;
                row.Cells[1].Value = item.ProjectName;
                row.Cells[2].Value = item.StartDate;
                row.Cells[3].Value = item.FinishDate;
                row.Cells[4].Value = item.isActive;
                row.Cells[5].Value = item.Budget;
                row.Cells[6].Value = item.CreateDate;
                row.Cells[7].Value = item.Description;
                row.Cells[8].Value = item.CreateUserName;
                row.Cells[9].Value = item.ProjectUserName;


            }
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'yazilimsinamaDataSet2.tblProjects' table. You can move, or remove it, as needed.





            DataGridDoldur();


            foreach (var item in db.tblUserRoles.Where(x => x.tblRoleNames.RoleName.ToString() == "Yönetici"))
            {
                cmbProjeYöneticisi.Items.Add(item.tblUsers.UserNickname);
            }
            dataGridView1.AllowUserToAddRows = false;
            cmbProjeYöneticisi.SelectedIndex = 0;
        }

        private void btnProjeEkle_Click(object sender, EventArgs e)
        {
            if (txtButce2.Value == 0 || txtProjeAdi.Text == "" || txtProjeAciklamasi.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakılan Alanları Doldurunuz!");
            }
            else
            {
                tblProjects proje = new YazilimSinamaveTest.tblProjects();
                proje.Budget = Convert.ToDecimal(txtButce2.Text);
                proje.CreateDate = DateTime.Now;
                proje.CreateUserID = frmUyeGiris.uyeID;
                proje.CreateUserName = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                proje.Description = txtProjeAciklamasi.Text;
                proje.FinishDate = dtpBitisTarihi.Value;
                if (chbAktif.Checked == true)
                    proje.isActive = true;
                else
                    proje.isActive = false;
                proje.ProjectName = txtProjeAdi.Text;
                proje.StartDate = dtpBaslangicTarihi.Value;
                proje.ProjectUserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == cmbProjeYöneticisi.SelectedItem.ToString()).UsersID;
                proje.ProjectUserName = db.tblUsers.FirstOrDefault(x => x.UserNickname == cmbProjeYöneticisi.SelectedItem.ToString()).UserNickname;
                db.tblProjects.Add(proje);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = "Proje Ekledi.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();



                DataGridDoldur();
                MessageBox.Show("Proje Başarıyla Eklendi");
            }


        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int projeID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IndexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[IndexRow];
                projeID = Convert.ToInt32(row.Cells[0].Value);
                txtProjeAdi.Text = row.Cells[1].Value.ToString();
                dtpBaslangicTarihi.Value = Convert.ToDateTime(row.Cells[2].Value);
                dtpBitisTarihi.Value = Convert.ToDateTime(row.Cells[3].Value);
                if (Convert.ToInt32(row.Cells[4].Value) == 1)
                {
                    chbAktif.Checked = true;
                }
                else
                {
                    chbAktif.Checked = false;
                }
                txtButce2.Text = (Convert.ToInt32(row.Cells[5].Value)).ToString();
                txtProjeAciklamasi.Text = row.Cells[7].Value.ToString();
                cmbProjeYöneticisi.SelectedItem = row.Cells[9].Value.ToString();

                int yuzde = 0;
                int sayac = 0;
                int toplamoran = 0;
                if (db.tblProcess.Any(x => x.ProjectID == projeID))
                {
                    foreach (var item in db.tblProcess.Where(x => x.ProjectID == projeID))
                    {
                        sayac++;
                        toplamoran += item.CompleteRate.Value;
                    }
                    yuzde = toplamoran / sayac;

                }
                progressBarTamamlanmaOrani.Value = yuzde;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtButce2.Value == 0 || txtProjeAdi.Text == "" || txtProjeAciklamasi.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakılan Alanları Doldurunuz!");
            }
            else
            {
                var guncellenicekproje = db.tblProjects.Where(x => x.ProjectID == projeID).FirstOrDefault();
                guncellenicekproje.Budget = Convert.ToInt32(txtButce2.Text);
                guncellenicekproje.Description = txtProjeAciklamasi.Text;
                guncellenicekproje.FinishDate = dtpBitisTarihi.Value;
                if (chbAktif.Checked == true)
                    guncellenicekproje.isActive = true;
                else
                    guncellenicekproje.isActive = false;
                guncellenicekproje.ProjectName = txtProjeAdi.Text;
                guncellenicekproje.ProjectUserName = cmbProjeYöneticisi.SelectedItem.ToString();
                guncellenicekproje.StartDate = dtpBitisTarihi.Value;

                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = "Projeyi güncelledi.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
                DataGridDoldur();

                MessageBox.Show("Projeniz Güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dtpBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime bTarih = Convert.ToDateTime(dtpBaslangicTarihi.Text);
            DateTime eTarih = Convert.ToDateTime(dtpBitisTarihi.Text);
            TimeSpan Sonuc = eTarih - bTarih;
            dtpBitisTarihi.MinDate = bTarih;

        }

        private void dtpBitisTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime bTarih = Convert.ToDateTime(dtpBaslangicTarihi.Text);
            DateTime eTarih = Convert.ToDateTime(dtpBitisTarihi.Text);
            TimeSpan Sonuc = eTarih - bTarih;
            dtpBitisTarihi.MinDate = bTarih;
            txtSure.Text = Sonuc.TotalDays.ToString();
        }

        private void btnProjeSil_Click(object sender, EventArgs e)
        {
            
                tblProjects silinecekproje = db.tblProjects.Where(x => x.ProjectID == projeID).FirstOrDefault();
                db.tblProjects.Remove(silinecekproje);
                db.SaveChanges();
            tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
            log.LogDate = DateTime.Now;
            log.UserLogDescription = "Projeyi sildi.";
            log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
            db.tblUserLogDetails.Add(log);
            db.SaveChanges();
            DataGridDoldur();

                MessageBox.Show("Projeniz Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AlanlariSifirla();
         }
        private void AlanlariSifirla()
        {
            txtProjeAdi.Text = txtButce2.Text = txtProjeAciklamasi.Text = txtSure.Text = "";
            progressBarTamamlanmaOrani.Value = 0;
            cmbProjeYöneticisi.Text = "";
            chbAktif.Checked = false;
            

        }
    }
}
