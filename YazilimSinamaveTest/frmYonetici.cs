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
    public partial class frmYonetici : Form
    {
        public frmYonetici()
        {
            InitializeComponent();
            treeViewGorevler.KeyDown += new KeyEventHandler(treeViewGorevler_KeyDown);
            treeViewGorevler.Enter += new EventHandler(treeViewGorevler_Enter);
            treeViewGorevler.Click += new EventHandler(treeViewGorevler_Click);
            treeViewGorevler.ExpandAll();
        }
        TimeSpan zamanfarki;
        yazilimsinamaEntities db = new yazilimsinamaEntities();
        List<int> seciliyazilimcilar = new List<int>();

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            if (txtGorevAdi.Text == "" || txtGorevAdi.Text == " ")
            {
                MessageBox.Show("Görev Adını Boş Bırakamazsınız!");
            }
            else
            {
                if (txtOncelik.Text == "")
                {
                    MessageBox.Show("Öncelik Değerini Boş Bırakamazsınız");
                }
                else
                {
                    if (listBoxYazilimcilar.Items.Count == 0)
                    {
                        MessageBox.Show("Sürece Yazılımcı Eklemeyi Unutmayınız!");
                    }
                    else
                    {
                        if (treeViewGorevler.SelectedNode.IsSelected == true)
                        {
                            tblProcess gorev = new tblProcess();
                            gorev.CompleteRate = 0;
                            gorev.CreateUserID = frmUyeGiris.uyeID;
                            gorev.Descriptions = richTextBoxAciklama.Text;
                            zamanfarki = dateTimePickerBitis.Value.Subtract(dateTimePickerBaslangic.Value);
                            gorev.Duration = Convert.ToInt32(zamanfarki.Days.ToString());
                            gorev.FinishDate = dateTimePickerBitis.Value;
                            gorev.Notes = richTextBoxNotlar.Text;
                            gorev.ProcessName = txtGorevAdi.Text;
                            gorev.StartDate = dateTimePickerBaslangic.Value;
                            gorev.CreatedDate = dateTimePickerOlusturulma.Value;
                            if (treeViewGorevler.SelectedNode == treeViewGorevler.Nodes[0])
                            {
                                gorev.ParentID = null;
                            }
                            else
                            {
                                gorev.ParentID = db.tblProcess.FirstOrDefault(x => x.ProcessID.ToString() == treeViewGorevler.SelectedNode.Name).ProcessID;

                            }
                            gorev.Priority = Convert.ToInt32(txtOncelik.Text);
                            gorev.ProjectID = db.tblProjects.FirstOrDefault(x => x.ProjectName == cmbProjeler.SelectedItem.ToString()).ProjectID;
                            db.tblProcess.Add(gorev);
                            db.SaveChanges();
                            treeViewGorevler.SelectedNode.Nodes.Add(gorev.ProcessID.ToString(), txtGorevAdi.Text);
                            foreach (var item in seciliyazilimcilar)
                            {
                                tblUserProcess up = new tblUserProcess();
                                up.UsersID = item;
                                up.UserRolesID = db.tblUserRoles.FirstOrDefault(x => x.UserID == item).UserRolesID;
                                up.ProcessID = gorev.ProcessID;
                                db.tblUserProcess.Add(up);
                                db.SaveChanges();
                            }
                            MessageBox.Show("Görev Eklendi");

                        }
                        else
                        {

                            tblProcess gorev = new tblProcess();
                            gorev.CompleteRate = 0;
                            gorev.CreateUserID = frmUyeGiris.uyeID;
                            gorev.Descriptions = richTextBoxAciklama.Text;
                            gorev.Duration = Convert.ToInt32(dateTimePickerBitis.Value.Subtract(dateTimePickerBaslangic.Value));
                            gorev.FinishDate = dateTimePickerBitis.Value;
                            gorev.Notes = richTextBoxNotlar.Text;
                            gorev.ProcessName = txtGorevAdi.Text;
                            gorev.StartDate = dateTimePickerBaslangic.Value;
                            gorev.ParentID = null;
                            gorev.Priority = Convert.ToInt32(txtOncelik.Text);
                            gorev.ProjectID = db.tblProjects.FirstOrDefault(x => x.ProjectName == cmbProjeler.SelectedItem.ToString()).ProjectID;
                            gorev.CreatedDate = dateTimePickerOlusturulma.Value;
                            db.tblProcess.Add(gorev);
                            db.SaveChanges();
                            treeViewGorevler.Nodes.Add(gorev.ProcessID.ToString(), txtGorevAdi.Text);
                            foreach (var item in seciliyazilimcilar)
                            {
                                tblUserProcess up = new tblUserProcess();
                                up.UsersID = item;
                                up.UserRolesID = db.tblUserRoles.FirstOrDefault(x => x.UserID == item).UserRolesID;
                                up.userProcessID = gorev.ProcessID;
                                db.tblUserProcess.Add(up);
                                db.SaveChanges();
                            }
                            MessageBox.Show("Görev Eklendi");

                            txtGorevAdi.Text = "";

                        }
                        txtGorevAdi.Text = txtGorevSuresi.Text = txtOncelik.Text = richTextBoxAciklama.Text = richTextBoxNotlar.Text = " ";
                        dateTimePickerBaslangic.Value = dateTimePickerBitis.Value = DateTime.Now;

                        treeViewGorevler.ExpandAll();
                    }
                }
            }
        }
       
        public void GorevleriListele(int ProjeID)
        {
            foreach (tblProcess item in db.tblProcess.Where(x => x.ParentID == null && x.ProjectID == ProjeID))
             {
                TreeNode root = new TreeNode(item.ProcessName.ToString());
                root.Name = item.ProcessID.ToString();
                treeViewGorevler.Nodes.Add(root);
                AltGorevleriListele(item, root);
                
            } 
        }
        public void AltGorevleriListele(tblProcess item,TreeNode root)
        {
            foreach (var ite in db.tblProcess.Where(x=>x.ParentID==item.ProcessID))
            {
                TreeNode child = new TreeNode(ite.ProcessName.ToString());
                child.Name = ite.ProcessID.ToString();
                root.Nodes.Add(child);
                AltGorevleriListele(ite, child);
                
            }
        }
       

        private void treeViewGorevler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F2))
            {
                treeViewGorevler.LabelEdit = true;
                treeViewGorevler.SelectedNode.BeginEdit();
            }
        }

        private void btnAltGorevEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void treeViewGorevler_Click(object sender, EventArgs e)
        {
            treeViewGorevler.LabelEdit = false;
        }

        private void treeViewGorevler_Enter(object sender, EventArgs e)
        {
            treeViewGorevler.LabelEdit = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmYonetici_Load(object sender, EventArgs e)
        {
            dateTimePickerOlusturulma.Value = DateTime.Now;
            
            var projeler = db.tblProjects.Where(x => x.ProjectUserID == frmUyeGiris.uyeID);
            foreach (var proje in projeler)
            {
                cmbProjeler.Items.Add(proje.ProjectName);
            }
            var yazilimcilar = db.tblUserRoles.Where(x => x.tblRoleNames.RoleName == "Yazılımcı");
            foreach (var yazilimci in yazilimcilar)
            {

                cmbYazilimcilar.Items.Add(yazilimci.tblUsers.UserNickname);
            }
            btnSurecAkisiGoruntule.Enabled = false;
            groupBoxIslemler.Enabled = false;
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cmbYazilimcilar.Text == "")
            {
                MessageBox.Show("Menüden eklemek istediğiniz yazılımcıyı seçiniz!");
            }
            else
            { 
                listBoxYazilimcilar.Items.Add(cmbYazilimcilar.SelectedItem);
                seciliyazilimcilar.Add(Convert.ToInt32(db.tblUsers.FirstOrDefault(x => x.UserNickname == cmbYazilimcilar.SelectedItem.ToString()).UsersID));
                cmbYazilimcilar.Items.Remove(cmbYazilimcilar.SelectedItem);
                cmbYazilimcilar.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeViewGorevler.SelectedNode.Nodes.Add(txtGorevAdi.Text);
            treeViewGorevler.ExpandAll();
        }

        private void richTextBoxAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewGörevler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbProjeler_SelectedIndexChanged(object sender, EventArgs e)
        {

            GorevleriListele(db.tblProjects.FirstOrDefault(x => x.ProjectName == cmbProjeler.SelectedItem.ToString()).ProjectID);
            treeViewGorevler.Nodes[0].Text = cmbProjeler.SelectedItem.ToString();
            treeViewGorevler.ExpandAll();
            groupBoxIslemler.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lblprocessID.Text == "0")
            {
                MessageBox.Show("Güncellenecek Süreci Seçiniz!");
            }
            else
            {
                int processID = Convert.ToInt32(lblprocessID.Text);
                tblProcess guncellenicekgorev = db.tblProcess.FirstOrDefault(x => x.ProcessID == processID);
                guncellenicekgorev.Descriptions = richTextBoxAciklama.Text;
                guncellenicekgorev.Duration = Convert.ToInt32(txtGorevSuresi.Text);
                guncellenicekgorev.FinishDate = dateTimePickerBitis.Value;
                guncellenicekgorev.StartDate = dateTimePickerBaslangic.Value;
                guncellenicekgorev.Notes = richTextBoxNotlar.Text;
                guncellenicekgorev.Priority = Convert.ToInt32(txtOncelik.Text);
                guncellenicekgorev.ProcessName = txtGorevAdi.Text;
                guncellenicekgorev.CreatedDate = dateTimePickerOlusturulma.Value;
                foreach (var item in seciliyazilimcilar)
                {
                    tblUserProcess up = new tblUserProcess();
                    up.UsersID = item;
                    up.UserRolesID = db.tblUserRoles.FirstOrDefault(x => x.UserID == item).UserRolesID;
                    up.ProcessID = processID;
                    db.tblUserProcess.Add(up);
                    db.SaveChanges();
                }
                treeViewGorevler.SelectedNode.Text = txtGorevAdi.Text;
                listBoxYazilimcilar.Items.Clear();
                txtGorevAdi.Text = txtGorevSuresi.Text = txtOncelik.Text = richTextBoxAciklama.Text = richTextBoxNotlar.Text = " ";
                dateTimePickerBaslangic.Value = dateTimePickerBitis.Value = DateTime.Now;


                db.SaveChanges();
                treeViewGorevler.Nodes.Clear();
                GorevleriListele(db.tblProjects.FirstOrDefault(x => x.ProjectName == cmbProjeler.SelectedItem.ToString()).ProjectID);
                treeViewGorevler.ExpandAll();
            }
        }
        int IndexNode;
        public static int ProcessID = 0;
        private void treeViewGorevler_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btnSurecAkisiGoruntule.Enabled = true;
            listBoxYazilimcilar.Items.Clear();
            IndexNode = Convert.ToInt32(e.Node.Name);
            var doldurgorev = db.tblProcess.Where(x => x.ProcessID == IndexNode).FirstOrDefault();
            txtGorevAdi.Text = doldurgorev.ProcessName;
            dateTimePickerBaslangic.Value =Convert.ToDateTime(doldurgorev.StartDate);
            dateTimePickerBitis.Value =Convert.ToDateTime(doldurgorev.FinishDate);
            txtOncelik.Text = doldurgorev.Priority.ToString();
            txtGorevSuresi.Text = doldurgorev.Duration.ToString();
            richTextBoxAciklama.Text = doldurgorev.Descriptions;
            richTextBoxNotlar.Text = doldurgorev.Notes;
            progressBarGorev.Value = doldurgorev.CompleteRate.Value;
            lblTamamlanmaOrani.Text= doldurgorev.CompleteRate.Value.ToString();
            lblprocessID.Text = doldurgorev.ProcessID.ToString();
            lblTOrani.Text = "%" + doldurgorev.CompleteRate.Value;
            dateTimePickerOlusturulma.Value = doldurgorev.CreatedDate.Value;
            txtSurecSahibi.Text = doldurgorev.tblProjects.CreateUserName;
            foreach (var item in db.tblUserProcess.Where(x => x.tblProcess.ProcessID == IndexNode)) 
            {
                listBoxYazilimcilar.Items.Add(item.tblUsers.UserNickname);
            }

            ProcessID = doldurgorev.ProcessID;
            treeViewGorevler.ExpandAll();
            treeViewGorevler.Update();
        }

        private void btnYazilimciSil_Click(object sender, EventArgs e)
        {
            int processID = Convert.ToInt32(lblprocessID.Text);
            string secilenyazilimci=listBoxYazilimcilar.SelectedItem.ToString();
            listBoxYazilimcilar.Items.Remove(listBoxYazilimcilar.SelectedItem);
            tblUserProcess silinecek = db.tblUserProcess.FirstOrDefault(x => x.tblUsers.UserNickname == secilenyazilimci&&x.ProcessID==processID);
            db.tblUserProcess.Remove(silinecek);
            db.SaveChanges();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblprocessID.Text == "0")
            {
                MessageBox.Show("Lütfen silinecek süreci seçiniz!");
            }
            else
            {
                int processID = Convert.ToInt32(lblprocessID.Text);
                tblProcess silinecekgorev = db.tblProcess.FirstOrDefault(x => x.ProcessID == processID);
                db.tblProcess.Remove(silinecekgorev);
                db.SaveChanges();
                treeViewGorevler.Nodes.Clear();
                GorevleriListele(db.tblProjects.FirstOrDefault(x => x.ProjectName == cmbProjeler.SelectedItem.ToString()).ProjectID);
                treeViewGorevler.ExpandAll();
                txtGorevAdi.Text = txtGorevSuresi.Text = txtOncelik.Text = richTextBoxAciklama.Text = richTextBoxNotlar.Text = txtSurecSahibi.Text = " ";
                dateTimePickerBaslangic.Value = dateTimePickerBitis.Value = dateTimePickerOlusturulma.Value = DateTime.Now;
                progressBarGorev.Value = 0;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtGorevAdi.Text = txtGorevSuresi.Text = txtOncelik.Text = richTextBoxAciklama.Text = richTextBoxNotlar.Text =txtSurecSahibi.Text= " ";
            dateTimePickerBaslangic.Value = dateTimePickerBitis.Value =dateTimePickerOlusturulma.Value= DateTime.Now;
            progressBarGorev.Value = 0;

        }

        private void treeViewGorevler_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        

        private void btnSurecAkisiGoruntule_Click(object sender, EventArgs e)
        {
            frmSurec surecform = new frmSurec();
            surecform.Show();
        }

        private void listBoxYazilimcilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKulIslemleri_Click(object sender, EventArgs e)
        {
            frmKullaniciIslemleri kulislem = new frmKullaniciIslemleri();
            kulislem.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRolSecimi _temp = new frmRolSecimi();
            _temp.Show();
        }
    }
}
