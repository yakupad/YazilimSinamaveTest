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
    public partial class frmSurec : Form
    {
        public frmSurec()
        {
            InitializeComponent();
        }
        yazilimsinamaEntities db = new yazilimsinamaEntities ();

        private void dateTimePicker27_ValueChanged(object sender, EventArgs e)
        {

        }
        private void DateTimeSifirla()
        {
            try
            {
                dateTimePickerAnaliz1.MinDate = dateTimePickerAnaliz2.MinDate = dateTimePickerAnaliz3.MinDate = DateTime.Now;
                dateTimePickerarayuz1.MinDate = dateTimePickerarayuz2.MinDate = dateTimePickerarayuz3.MinDate = DateTime.Now;
                dateTimePickerdllislem1.MinDate = dateTimePickerdllislem2.MinDate = dateTimePickerdllislem3.MinDate = DateTime.Now;
                dateTimePickerdlllist1.MinDate = dateTimePickerdlllist2.MinDate = dateTimePickerdlllist3.MinDate = DateTime.Now;
                dateTimePickerProcedure1.MinDate = dateTimePickerProcedure2.MinDate = dateTimePickerProcedure3.MinDate = DateTime.Now;
                dateTimePickerTable1.MinDate = dateTimePickerTable2.MinDate = dateTimePickerTable3.MinDate = DateTime.Now;
                dateTimePickertest11.MinDate = dateTimePickertest12.MinDate = dateTimePickertest13.MinDate = DateTime.Now;
                dateTimePickertest21.MinDate = dateTimePickertest22.MinDate = dateTimePickertest23.MinDate = DateTime.Now;
                dateTimePickertest31.MinDate = dateTimePickertest32.MinDate = dateTimePickertest33.MinDate = DateTime.Now;
                dateTimePickertest41.MinDate = dateTimePickertest42.MinDate = dateTimePickertest43.MinDate = DateTime.Now;
                dateTimePickertest51.MinDate = dateTimePickertest52.MinDate = dateTimePickertest53.MinDate = DateTime.Now;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }

        private void BilgileriGetir()
        {
            try
            {
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblAnaliz.Text))
                {
                    comboBoxAnaliz.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickerAnaliz1.Value = dateTimePickerAnaliz1.MinDate = item.StartDate.Value;
                    dateTimePickerAnaliz2.Value = dateTimePickerAnaliz2.MinDate = item.FinishDate.Value;
                    dateTimePickerAnaliz3.Value = dateTimePickerAnaliz3.MinDate = item.CompletedDate.Value;
                    trackBar1.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTable.Text))
                {
                    comboBoxTable.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickerTable1.Value = dateTimePickerTable1.MinDate = item.StartDate.Value;
                    dateTimePickerTable2.Value = dateTimePickerTable2.MinDate = item.FinishDate.Value;
                    dateTimePickerTable3.Value = dateTimePickerTable3.MinDate = item.CompletedDate.Value;
                    trackBar2.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblProcedure.Text))
                {
                    comboBoxProcedure.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickerProcedure1.Value = dateTimePickerProcedure1.MinDate = item.StartDate.Value;
                    dateTimePickerProcedure2.Value = dateTimePickerProcedure2.MinDate = item.FinishDate.Value;
                    dateTimePickerProcedure3.Value = dateTimePickerProcedure3.MinDate = item.CompletedDate.Value;
                    trackBar3.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllList.Text))
                {
                    comboBoxDllList.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickerdlllist1.Value = dateTimePickerdlllist1.MinDate = item.StartDate.Value;
                    dateTimePickerdlllist2.Value = dateTimePickerdlllist2.MinDate = item.FinishDate.Value;
                    dateTimePickerdlllist3.Value = dateTimePickerdlllist3.MinDate = item.CompletedDate.Value;
                    trackBar4.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllIslem.Text))
                {
                    comboBoxDllIslem.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickerdllislem1.Value = dateTimePickerdllislem1.MinDate = item.StartDate.Value;
                    dateTimePickerdllislem2.Value = dateTimePickerdllislem2.MinDate = item.FinishDate.Value;
                    dateTimePickerdllislem3.Value = dateTimePickerdllislem3.MinDate = item.CompletedDate.Value;
                    trackBar5.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblArayuz.Text))
                {
                    comboBoxArayuz.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickerarayuz1.Value = dateTimePickerarayuz1.MinDate = item.StartDate.Value;
                    dateTimePickerarayuz2.Value = dateTimePickerarayuz2.MinDate = item.FinishDate.Value;
                    dateTimePickerarayuz3.Value = dateTimePickerarayuz3.MinDate = item.CompletedDate.Value;
                    trackBar6.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest1.Text))
                {
                    comboBoxTest1.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickertest11.Value = dateTimePickertest11.MinDate = item.StartDate.Value;
                    dateTimePickertest12.Value = dateTimePickertest12.MinDate = item.FinishDate.Value;
                    dateTimePickertest13.Value = dateTimePickertest13.MinDate = item.CompletedDate.Value;
                    trackBar7.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest2.Text))
                {
                    comboBoxTest2.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickertest21.Value = dateTimePickertest21.MinDate = item.StartDate.Value;
                    dateTimePickertest22.Value = dateTimePickertest22.MinDate = item.FinishDate.Value;
                    dateTimePickertest23.Value = dateTimePickertest23.MinDate = item.CompletedDate.Value;
                    trackBar8.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest3.Text))
                {
                    comboBoxTest3.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickertest31.Value = dateTimePickertest31.MinDate = item.StartDate.Value;
                    dateTimePickertest32.Value = dateTimePickertest32.MinDate = item.FinishDate.Value;
                    dateTimePickertest33.Value = dateTimePickertest33.MinDate = item.CompletedDate.Value;
                    trackBar8.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest4.Text))
                {
                    comboBoxTest4.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickertest41.Value = dateTimePickertest41.MinDate = item.StartDate.Value;
                    dateTimePickertest42.Value = dateTimePickertest42.MinDate = item.FinishDate.Value;
                    dateTimePickertest43.Value = dateTimePickertest43.MinDate = item.CompletedDate.Value;
                    trackBar9.Value = item.CompleteRate.Value;
                }
                foreach (var item in db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest5.Text))
                {
                    comboBoxText5.Text = db.tblUsers.FirstOrDefault(x => x.UsersID == item.UserID).UserNickname;
                    dateTimePickertest51.Value = dateTimePickertest51.MinDate = item.StartDate.Value;
                    dateTimePickertest52.Value = dateTimePickertest52.MinDate = item.FinishDate.Value;
                    dateTimePickertest53.Value = dateTimePickertest53.MinDate = item.CompletedDate.Value;
                    trackBar10.Value = item.CompleteRate.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmSurec_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in db.tblUserRoles.Where(x => x.RoleNameID == 1))
                {
                    comboBoxAnaliz.Items.Add(item.tblUsers.UserNickname);
                    comboBoxArayuz.Items.Add(item.tblUsers.UserNickname);
                    comboBoxDllIslem.Items.Add(item.tblUsers.UserNickname);
                    comboBoxDllList.Items.Add(item.tblUsers.UserNickname);
                    comboBoxProcedure.Items.Add(item.tblUsers.UserNickname);
                    comboBoxTable.Items.Add(item.tblUsers.UserNickname);
                    comboBoxTest1.Items.Add(item.tblUsers.UserNickname);
                    comboBoxTest2.Items.Add(item.tblUsers.UserNickname);
                    comboBoxTest3.Items.Add(item.tblUsers.UserNickname);
                    comboBoxTest4.Items.Add(item.tblUsers.UserNickname);
                    comboBoxText5.Items.Add(item.tblUsers.UserNickname);

                }
                DateTimeSifirla();
                BilgileriGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
            label12.Text = "%" +trackBar1.Value;
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            progressBar3.Value = trackBar2.Value;
            label13.Text = "%" + trackBar2.Value;
        }
        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            progressBar4.Value = trackBar3.Value;
            label14.Text = "%" + trackBar3.Value;
        }
        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            progressBar5.Value = trackBar4.Value;
            label15.Text = "%" + trackBar4.Value;
        }
        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            progressBar6.Value = trackBar5.Value;
            label16.Text = "%" + trackBar5.Value;
        }
        private void trackBar6_ValueChanged(object sender, EventArgs e)
        {
            progressBar7.Value = trackBar6.Value;
            label17.Text = "%" + trackBar6.Value;
        }
        private void trackBar7_ValueChanged(object sender, EventArgs e)
        {
            progressBar8.Value = trackBar7.Value;
            label18.Text = "%" + trackBar7.Value;
        }
        private void trackBar8_ValueChanged(object sender, EventArgs e)
        {
            progressBar9.Value = trackBar8.Value;
            label19.Text = "%" + trackBar8.Value;
        }
        private void trackBar9_ValueChanged(object sender, EventArgs e)
        {
            progressBar10.Value = trackBar9.Value;
            label20.Text = "%" + trackBar9.Value;
        }
        private void trackBar10_ValueChanged(object sender, EventArgs e)
        {
            progressBar11.Value = trackBar10.Value;
            label21.Text = "%" + trackBar10.Value;
        }
        private void trackBar11_ValueChanged(object sender, EventArgs e)
        {
            progressBar12.Value = trackBar11.Value;
            label22.Text = "%" + trackBar11.Value;
        }

        private void btnAnalizEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAnaliz.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblAnaliz.Text))
                    {
                        tblWorkFollow guncellenicek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblAnaliz.Text).FirstOrDefault();
                        guncellenicek.CompletedDate = dateTimePickerAnaliz3.Value;
                        guncellenicek.FinishDate = dateTimePickerAnaliz2.Value;
                        guncellenicek.StartDate = dateTimePickerAnaliz1.Value;
                        guncellenicek.CompleteRate = trackBar1.Value;
                        guncellenicek.ProcessID = frmYonetici.ProcessID;
                        guncellenicek.WorkFollowName = lblAnaliz.Text;
                        guncellenicek.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxAnaliz.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();

                    }
                    else
                    {
                        tblWorkFollow analizsureciekle = new tblWorkFollow();
                        analizsureciekle.CompletedDate = dateTimePickerAnaliz3.Value;
                        analizsureciekle.FinishDate = dateTimePickerAnaliz2.Value;
                        analizsureciekle.StartDate = dateTimePickerAnaliz1.Value;
                        analizsureciekle.CompleteRate = trackBar1.Value;
                        analizsureciekle.ProcessID = frmYonetici.ProcessID;
                        analizsureciekle.WorkFollowName = lblAnaliz.Text;
                        analizsureciekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxAnaliz.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(analizsureciekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void btnTableEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTable.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTable.Text))
                    {
                        tblWorkFollow tablesureciekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTable.Text).FirstOrDefault();
                        tablesureciekle.CompletedDate = dateTimePickerTable3.Value;
                        tablesureciekle.FinishDate = dateTimePickerTable2.Value;
                        tablesureciekle.StartDate = dateTimePickerTable1.Value;
                        tablesureciekle.CompleteRate = trackBar2.Value;
                        tablesureciekle.ProcessID = frmYonetici.ProcessID;
                        tablesureciekle.WorkFollowName = lblTable.Text;
                        tablesureciekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTable.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow tablesureciekle = new tblWorkFollow();
                        tablesureciekle.CompletedDate = dateTimePickerTable3.Value;
                        tablesureciekle.FinishDate = dateTimePickerTable2.Value;
                        tablesureciekle.StartDate = dateTimePickerTable1.Value;
                        tablesureciekle.CompleteRate = trackBar2.Value;
                        tablesureciekle.ProcessID = frmYonetici.ProcessID;
                        tablesureciekle.WorkFollowName = lblTable.Text;
                        tablesureciekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTable.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(tablesureciekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnProcedureEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProcedure.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblProcedure.Text))
                    {
                        tblWorkFollow procedureekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblProcedure.Text).FirstOrDefault();
                        procedureekle.CompletedDate = dateTimePickerProcedure3.Value;
                        procedureekle.FinishDate = dateTimePickerProcedure2.Value;
                        procedureekle.StartDate = dateTimePickerProcedure1.Value;
                        procedureekle.CompleteRate = trackBar3.Value;
                        procedureekle.ProcessID = frmYonetici.ProcessID;
                        procedureekle.WorkFollowName = lblProcedure.Text;
                        procedureekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxProcedure.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow procedureekle = new tblWorkFollow();
                        procedureekle.CompletedDate = dateTimePickerProcedure3.Value;
                        procedureekle.FinishDate = dateTimePickerProcedure2.Value;
                        procedureekle.StartDate = dateTimePickerProcedure1.Value;
                        procedureekle.CompleteRate = trackBar3.Value;
                        procedureekle.ProcessID = frmYonetici.ProcessID;
                        procedureekle.WorkFollowName = lblProcedure.Text;
                        procedureekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxProcedure.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(procedureekle);
                        db.SaveChanges();
                    }
                }//deneme
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnDllListEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDllList.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllList.Text))
                    {
                        tblWorkFollow dlllistekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllList.Text).FirstOrDefault();
                        dlllistekle.CompletedDate = dateTimePickerdlllist3.Value;
                        dlllistekle.FinishDate = dateTimePickerdlllist2.Value;
                        dlllistekle.StartDate = dateTimePickerdlllist1.Value;
                        dlllistekle.CompleteRate = trackBar4.Value;
                        dlllistekle.ProcessID = frmYonetici.ProcessID;
                        dlllistekle.WorkFollowName = lblDllList.Text;
                        dlllistekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxDllList.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow dlllistekle = new tblWorkFollow();
                        dlllistekle.CompletedDate = dateTimePickerdlllist3.Value;
                        dlllistekle.FinishDate = dateTimePickerdlllist2.Value;
                        dlllistekle.StartDate = dateTimePickerdlllist1.Value;
                        dlllistekle.CompleteRate = trackBar4.Value;
                        dlllistekle.ProcessID = frmYonetici.ProcessID;
                        dlllistekle.WorkFollowName = lblDllList.Text;
                        dlllistekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxDllList.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(dlllistekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnDllIslemEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDllIslem.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllIslem.Text))
                    {
                        tblWorkFollow dllislemekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllIslem.Text).FirstOrDefault();
                        dllislemekle.CompletedDate = dateTimePickerdllislem3.Value;
                        dllislemekle.FinishDate = dateTimePickerdllislem2.Value;
                        dllislemekle.StartDate = dateTimePickerdllislem1.Value;
                        dllislemekle.CompleteRate = trackBar5.Value;
                        dllislemekle.ProcessID = frmYonetici.ProcessID;
                        dllislemekle.WorkFollowName = lblDllIslem.Text;
                        dllislemekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxDllIslem.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow dllislemekle = new tblWorkFollow();
                        dllislemekle.CompletedDate = dateTimePickerdllislem3.Value;
                        dllislemekle.FinishDate = dateTimePickerdllislem2.Value;
                        dllislemekle.StartDate = dateTimePickerdllislem1.Value;
                        dllislemekle.CompleteRate = trackBar5.Value;
                        dllislemekle.ProcessID = frmYonetici.ProcessID;
                        dllislemekle.WorkFollowName = lblDllIslem.Text;
                        dllislemekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxDllIslem.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(dllislemekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnArayuzEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxArayuz.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblArayuz.Text))
                    {
                        tblWorkFollow arayuzekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblArayuz.Text).FirstOrDefault();
                        arayuzekle.CompletedDate = dateTimePickerarayuz3.Value;
                        arayuzekle.FinishDate = dateTimePickerarayuz2.Value;
                        arayuzekle.StartDate = dateTimePickerarayuz1.Value;
                        arayuzekle.CompleteRate = trackBar6.Value;
                        arayuzekle.ProcessID = frmYonetici.ProcessID;
                        arayuzekle.WorkFollowName = lblArayuz.Text;
                        arayuzekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxArayuz.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow arayuzekle = new tblWorkFollow();
                        arayuzekle.CompletedDate = dateTimePickerarayuz3.Value;
                        arayuzekle.FinishDate = dateTimePickerarayuz2.Value;
                        arayuzekle.StartDate = dateTimePickerarayuz1.Value;
                        arayuzekle.CompleteRate = trackBar6.Value;
                        arayuzekle.ProcessID = frmYonetici.ProcessID;
                        arayuzekle.WorkFollowName = lblArayuz.Text;
                        arayuzekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxArayuz.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(arayuzekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTest1Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTest1.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest1.Text))
                    {
                        tblWorkFollow test1ekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest1.Text).FirstOrDefault();
                        test1ekle.CompletedDate = dateTimePickertest11.Value;
                        test1ekle.FinishDate = dateTimePickertest12.Value;
                        test1ekle.StartDate = dateTimePickertest13.Value;
                        test1ekle.CompleteRate = trackBar7.Value;
                        test1ekle.ProcessID = frmYonetici.ProcessID;
                        test1ekle.WorkFollowName = lblTest1.Text;
                        test1ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTest1.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow test1ekle = new tblWorkFollow();
                        test1ekle.CompletedDate = dateTimePickertest11.Value;
                        test1ekle.FinishDate = dateTimePickertest12.Value;
                        test1ekle.StartDate = dateTimePickertest13.Value;
                        test1ekle.CompleteRate = trackBar7.Value;
                        test1ekle.ProcessID = frmYonetici.ProcessID;
                        test1ekle.WorkFollowName = lblTest1.Text;
                        test1ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTest1.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(test1ekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTest2Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTest2.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest2.Text))
                    {
                        tblWorkFollow test2ekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest2.Text).FirstOrDefault();
                        test2ekle.CompletedDate = dateTimePickertest11.Value;
                        test2ekle.FinishDate = dateTimePickertest22.Value;
                        test2ekle.StartDate = dateTimePickertest23.Value;
                        test2ekle.CompleteRate = trackBar8.Value;
                        test2ekle.ProcessID = frmYonetici.ProcessID;
                        test2ekle.WorkFollowName = lblTest2.Text;
                        test2ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTest2.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow test2ekle = new tblWorkFollow();
                        test2ekle.CompletedDate = dateTimePickertest11.Value;
                        test2ekle.FinishDate = dateTimePickertest22.Value;
                        test2ekle.StartDate = dateTimePickertest23.Value;
                        test2ekle.CompleteRate = trackBar8.Value;
                        test2ekle.ProcessID = frmYonetici.ProcessID;
                        test2ekle.WorkFollowName = lblTest2.Text;
                        test2ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTest2.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(test2ekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTest3Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTest3.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest3.Text))
                    {
                        tblWorkFollow test3ekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest3.Text).FirstOrDefault();
                        test3ekle.CompletedDate = dateTimePickertest11.Value;
                        test3ekle.FinishDate = dateTimePickertest32.Value;
                        test3ekle.StartDate = dateTimePickertest33.Value;
                        test3ekle.CompleteRate = trackBar7.Value;
                        test3ekle.ProcessID = frmYonetici.ProcessID;
                        test3ekle.WorkFollowName = lblTest3.Text;
                        test3ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTest3.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow test3ekle = new tblWorkFollow();
                        test3ekle.CompletedDate = dateTimePickertest11.Value;
                        test3ekle.FinishDate = dateTimePickertest32.Value;
                        test3ekle.StartDate = dateTimePickertest33.Value;
                        test3ekle.CompleteRate = trackBar7.Value;
                        test3ekle.ProcessID = frmYonetici.ProcessID;
                        test3ekle.WorkFollowName = lblTest3.Text;
                        test3ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTest3.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(test3ekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTest4Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTest4.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest4.Text))
                    {
                        tblWorkFollow test4ekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest4.Text).FirstOrDefault();
                        test4ekle.CompletedDate = dateTimePickertest11.Value;
                        test4ekle.FinishDate = dateTimePickertest42.Value;
                        test4ekle.StartDate = dateTimePickertest43.Value;
                        test4ekle.CompleteRate = trackBar7.Value;
                        test4ekle.ProcessID = frmYonetici.ProcessID;
                        test4ekle.WorkFollowName = lblTest4.Text;
                        test4ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTest4.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow test4ekle = new tblWorkFollow();
                        test4ekle.CompletedDate = dateTimePickertest11.Value;
                        test4ekle.FinishDate = dateTimePickertest42.Value;
                        test4ekle.StartDate = dateTimePickertest43.Value;
                        test4ekle.CompleteRate = trackBar7.Value;
                        test4ekle.ProcessID = frmYonetici.ProcessID;
                        test4ekle.WorkFollowName = lblTest4.Text;
                        test4ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxTest4.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(test4ekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btntest5Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxText5.Text == "")
                {
                    MessageBox.Show("Lütfen bir yazılımcı atayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest5.Text))
                    {
                        tblWorkFollow test5ekle = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest5.Text).FirstOrDefault();
                        test5ekle.CompletedDate = dateTimePickertest11.Value;
                        test5ekle.FinishDate = dateTimePickertest52.Value;
                        test5ekle.StartDate = dateTimePickertest53.Value;
                        test5ekle.CompleteRate = trackBar7.Value;
                        test5ekle.ProcessID = frmYonetici.ProcessID;
                        test5ekle.WorkFollowName = lblTest5.Text;
                        test5ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxText5.SelectedItem.ToString()).UsersID;
                        db.SaveChanges();
                    }
                    else
                    {
                        tblWorkFollow test5ekle = new tblWorkFollow();
                        test5ekle.CompletedDate = dateTimePickertest11.Value;
                        test5ekle.FinishDate = dateTimePickertest52.Value;
                        test5ekle.StartDate = dateTimePickertest53.Value;
                        test5ekle.CompleteRate = trackBar7.Value;
                        test5ekle.ProcessID = frmYonetici.ProcessID;
                        test5ekle.WorkFollowName = lblTest5.Text;
                        test5ekle.UserID = db.tblUsers.FirstOrDefault(x => x.UserNickname == comboBoxText5.SelectedItem.ToString()).UsersID;
                        db.tblWorkFollow.Add(test5ekle);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void btnAnalizSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblAnaliz.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblAnaliz.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickerAnaliz1.MinDate = dateTimePickerAnaliz2.MinDate = dateTimePickerAnaliz3.MinDate = DateTime.Now;
                    dateTimePickerAnaliz1.Value = dateTimePickerAnaliz2.Value = dateTimePickerAnaliz3.Value = DateTime.Now;
                    comboBoxAnaliz.Text = "";
                    trackBar1.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnTableSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTable.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTable.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickerTable1.MinDate = dateTimePickerTable2.MinDate = dateTimePickerTable3.MinDate = DateTime.Now;
                    dateTimePickerTable1.Value = dateTimePickerTable2.Value = dateTimePickerTable3.Value = DateTime.Now;
                    comboBoxTable.Text = "";
                    trackBar2.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnProcedureSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblProcedure.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblProcedure.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickerProcedure1.MinDate = dateTimePickerProcedure2.MinDate = dateTimePickerProcedure3.MinDate = DateTime.Now;
                    dateTimePickerProcedure1.Value = dateTimePickerProcedure2.Value = dateTimePickerProcedure3.Value = DateTime.Now;
                    comboBoxProcedure.Text = "";
                    trackBar3.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDllListSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllList.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllList.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickerdlllist1.MinDate = dateTimePickerdlllist2.MinDate = dateTimePickerdlllist3.MinDate = DateTime.Now;
                    dateTimePickerdlllist1.Value = dateTimePickerdlllist2.Value = dateTimePickerdlllist3.Value = DateTime.Now;
                    comboBoxDllList.Text = "";
                    trackBar4.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDllIslemSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllIslem.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblDllIslem.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickerdllislem1.MinDate = dateTimePickerdllislem2.MinDate = dateTimePickerdllislem3.MinDate = DateTime.Now;
                    dateTimePickerdllislem1.Value = dateTimePickerdllislem2.Value = dateTimePickerdllislem3.Value = DateTime.Now;
                    comboBoxDllIslem.Text = "";
                    trackBar5.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnArayuzSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblArayuz.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblArayuz.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickerarayuz1.MinDate = dateTimePickerarayuz2.MinDate = dateTimePickerarayuz3.MinDate = DateTime.Now;
                    dateTimePickerarayuz1.Value = dateTimePickerarayuz2.Value = dateTimePickerarayuz3.Value = DateTime.Now;
                    comboBoxArayuz.Text = "";
                    trackBar6.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTest1Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest1.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest1.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickertest11.MinDate = dateTimePickertest12.MinDate = dateTimePickertest13.MinDate = DateTime.Now;
                    dateTimePickertest11.Value = dateTimePickertest12.Value = dateTimePickertest13.Value = DateTime.Now;
                    comboBoxTest1.Text = "";
                    trackBar7.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTest2Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest2.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest2.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickertest21.MinDate = dateTimePickertest22.MinDate = dateTimePickertest23.MinDate = DateTime.Now;
                    dateTimePickertest21.Value = dateTimePickertest22.Value = dateTimePickertest23.Value = DateTime.Now;
                    comboBoxTest2.Text = "";
                    trackBar8.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTest3Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest3.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest3.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickertest31.MinDate = dateTimePickertest32.MinDate = dateTimePickertest33.MinDate = DateTime.Now;
                    dateTimePickertest31.Value = dateTimePickertest32.Value = dateTimePickertest33.Value = DateTime.Now;
                    comboBoxTest3.Text = "";
                    trackBar9.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnTest4Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest4.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest4.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickertest41.MinDate = dateTimePickertest42.MinDate = dateTimePickertest43.MinDate = DateTime.Now;
                    dateTimePickertest41.Value = dateTimePickertest42.Value = dateTimePickertest43.Value = DateTime.Now;
                    comboBoxTest4.Text = "";
                    trackBar10.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTest5Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.tblWorkFollow.Any(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest5.Text))
                {
                    tblWorkFollow silinecek = db.tblWorkFollow.Where(x => x.ProcessID == frmYonetici.ProcessID && x.WorkFollowName == lblTest5.Text).FirstOrDefault();
                    db.tblWorkFollow.Remove(silinecek);
                    db.SaveChanges();
                    dateTimePickertest51.MinDate = dateTimePickertest52.MinDate = dateTimePickertest53.MinDate = DateTime.Now;
                    dateTimePickertest51.Value = dateTimePickertest52.Value = dateTimePickertest53.Value = DateTime.Now;
                    comboBoxText5.Text = "";
                    trackBar11.Value = 0;
                }
                else
                {
                    MessageBox.Show("Silinecek Süreç Bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
