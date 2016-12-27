using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaveTest
{
    public partial class frmYazilimci : Form
    {
        public frmYazilimci()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir şeyler oldu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        yazilimsinamaEntities db = new yazilimsinamaEntities();
        private void frmYazilimci_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in db.tblUserProcess.Where(x => x.tblUsers.UsersID == frmUyeGiris.uyeID))
                {
                if (db.tblProcess.Any(x => x.ProcessID == item.ProcessID))
                {
                    tblProcess yazilimciningorevi = db.tblProcess.FirstOrDefault(x => x.ProcessID == item.ProcessID);
                    int rowIndex = this.dataGridViewGorevler.Rows.Add();
                    var row = this.dataGridViewGorevler.Rows[rowIndex];


                    row.Cells[0].Value = yazilimciningorevi.ProcessID;
                    row.Cells[1].Value = yazilimciningorevi.ProcessName;
                    row.Cells[2].Value = db.tblProjects.FirstOrDefault(x => x.ProjectID == yazilimciningorevi.ProjectID).ProjectName;
                    row.Cells[3].Value = yazilimciningorevi.StartDate;
                    row.Cells[4].Value = yazilimciningorevi.FinishDate;
                    row.Cells[5].Value = yazilimciningorevi.Duration;
                    row.Cells[6].Value = yazilimciningorevi.CompleteRate;
                    row.Cells[7].Value = yazilimciningorevi.Priority;
                    row.Cells[8].Value = yazilimciningorevi.Notes;
                    row.Cells[9].Value = yazilimciningorevi.Descriptions;
                    row.Cells[10].Value = db.tblUsers.FirstOrDefault(x => x.UsersID == yazilimciningorevi.CreateUserID).UserNickname;
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir şeyler oldu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBarTorani_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                progressBarTorani.Value = trackBarTorani.Value;
                lblYuzde.Text = "%"+progressBarTorani.Value;
                tblProcess yuzdedegistir = db.tblProcess.Where(x => x.ProcessID == ProcessID).FirstOrDefault();
                yuzdedegistir.CompleteRate = progressBarTorani.Value;
                db.SaveChanges();
                dataGridViewGorevler.Rows[IndexRow].Cells[6].Value = trackBarTorani.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir şeyler oldu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxAciklama_TextChanged(object sender, EventArgs e)
        {

        }
        int IndexRow;
        int ProcessID;
        private void dataGridViewGorevler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    groupBoxGörev.Enabled = true;
                    IndexRow = e.RowIndex;
                    if (IndexRow == -1)
                    {
                            //DataGridViewde başlığa tıklayınca tepki vermeyecek
                    }
                    else
                    {
                        DataGridViewRow row = dataGridViewGorevler.Rows[IndexRow];
                        ProcessID = Convert.ToInt32(row.Cells[0].Value);
                        lblProjeAdi.Text = "Proje Adı: " + row.Cells[2].Value.ToString();
                        lblToplamSure.Text = "Toplam Süre: " + row.Cells[5].Value + " Gün";
                        lblMusteriAdi.Text = "Müşteri Adı: " + row.Cells[10].Value;
                        lblOncelik.Text = "Öncelik:" + row.Cells[7].Value;
                        lblGorevAdi.Text = "Görev Adı: " + row.Cells[1].Value;
                        richTextBoxAciklama.Text = row.Cells[9].Value.ToString();
                        richTextBoxNotlar.Text = row.Cells[8].Value.ToString();
                        int yuzde = Convert.ToInt32(row.Cells[6].Value);
                        trackBarTorani.Value = yuzde;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir şeyler oldu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbTamamlandi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarTorani.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir şeyler oldu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lblYuzde_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewGorevler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trackBarTorani_Scroll(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRolSecimi _temp = new frmRolSecimi();
            _temp.Show();
        }
    }
}
