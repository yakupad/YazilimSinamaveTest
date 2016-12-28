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
    public partial class frmKullaniciIslemleri : Form
    {
        public frmKullaniciIslemleri()
        {
            InitializeComponent();
        }
        yazilimsinamaEntities db = new yazilimsinamaEntities();
        private void frmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            foreach (var item in db.tblUsers)
            {
                comboBoxUyeler.Items.Add(item.UserNickname);
            }
            checkBoxYazilimci.Enabled = checkBoxYonetici.Enabled = checkBoxMusteri.Enabled = false;
           
        }
        int userID;
        private void comboBoxUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                checkBoxYazilimci.Enabled = checkBoxYonetici.Enabled = checkBoxMusteri.Enabled = true;
                tblUsers user = db.tblUsers.Where(x => x.UserNickname == comboBoxUyeler.SelectedItem.ToString()).FirstOrDefault();
                textBoxAd.Text = user.UserName;
                textBoxKullanıcıAd.Text = user.UserNickname;
                textBoxParola.Text = user.UserPassword;
                textBoxSoyad.Text = user.UserSurname;
                dateTimePickerKayitTarihi.Value = user.UserCreatedDate.Value;
                userID = user.UsersID;
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "Üye ID'li Üyenin bilgileri görüntülendi.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
                if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 1))
                {
                    checkBoxYazilimci.Checked = true;
                }
                else
                {
                    checkBoxYazilimci.Checked = false;
                }
                if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 2))
                {
                    checkBoxMusteri.Checked = true;
                }
                else
                {
                    checkBoxMusteri.Checked = false;
                }
                if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 3))
                {
                    checkBoxYonetici.Checked = true;
                }
                else
                {
                    checkBoxYonetici.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        
        

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            tblUsers userguncelle = db.tblUsers.Where(x => x.UsersID == userID).FirstOrDefault();
            userguncelle.UserName = textBoxAd.Text;
            userguncelle.UserNickname = textBoxKullanıcıAd.Text;
            userguncelle.UserPassword = textBoxParola.Text;
            userguncelle.UserSurname = textBoxSoyad.Text;
            db.SaveChanges();
            tblUserLogDetails logG = new YazilimSinamaveTest.tblUserLogDetails();
            logG.LogDate = DateTime.Now;
            logG.UserLogDescription = userID + "Üye ID'li Üyenin profili güncellendi.";
            logG.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
            db.tblUserLogDetails.Add(logG);
            db.SaveChanges();

            //Müşteri İçin
            if (checkBoxMusteri.Checked == true && db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 2) == true)
            {
                checkBoxMusteri.Checked = true;
            }
            else if (checkBoxMusteri.Checked == false && db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 2)==true)
            {
                tblUserRoles rol = db.tblUserRoles.Where(x => x.RoleNameID == 2 && x.UserID == userID).FirstOrDefault();
                db.tblUserRoles.Remove(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "Üye ID'li Üyenin rolünü müşteri olmaktan çıkardı.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 2) == false && checkBoxMusteri.Checked == true)
            {
                tblUserRoles rol = new tblUserRoles();
                rol.UserID = userID;
                rol.RoleNameID = 2;
                db.tblUserRoles.Add(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "Üye ID'li Üyenin rolünü müşteri olarak değiştirdi.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else if(db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 2)==false&&checkBoxMusteri.Checked==false)
            {
                checkBoxMusteri.Checked = false;
            }
            bool yazilimci = db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 1);
            //Yazılımcı için
            if (checkBoxYazilimci.Checked == true && yazilimci == true)
            {
                checkBoxYazilimci.Checked = true;
            }
            else if (checkBoxYazilimci.Checked == false && yazilimci == true)
            {
                tblUserRoles rol = db.tblUserRoles.Where(x => x.RoleNameID == 1 && x.UserID == userID).FirstOrDefault();
                db.tblUserRoles.Remove(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "Üye ID'li Üyenin rolünü yazılımcı olmaktan çıkardı.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 1) == false && checkBoxYazilimci.Checked == true)
            {
                tblUserRoles rol = new tblUserRoles();
                rol.UserID = userID;
                rol.RoleNameID = 1;
                db.tblUserRoles.Add(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "Üye ID'li Üyenin rolünü yazılımcı olarak değiştirdi.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 1) == false && checkBoxYazilimci.Checked == false)
            {
                checkBoxMusteri.Checked = false;
            }

            //Yönetici İçin
            if (checkBoxYonetici.Checked == true && db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 3) == true)
            {
                checkBoxYonetici.Checked = true;
            }
            else if (checkBoxYonetici.Checked == false && db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 3) == true)
            {
                tblUserRoles rol = db.tblUserRoles.Where(x => x.RoleNameID == 3 && x.UserID == userID).FirstOrDefault();
                db.tblUserRoles.Remove(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "Üye ID'li Üyenin rolünü yöenetici olmaktan çıkardı.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 3) == false && checkBoxYonetici.Checked == true)
            {
                tblUserRoles rol = new tblUserRoles();
                rol.UserID = userID;
                rol.RoleNameID = 3;
                db.tblUserRoles.Add(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "Üye ID'li Üyenin rolünü yönetici olarak değiştirdi.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 3) == false && checkBoxYonetici.Checked == false)
            {
                checkBoxMusteri.Checked = false;
            }

            if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 1))
            {
                checkBoxYazilimci.Checked = true;
            }
            else
            {
                checkBoxYazilimci.Checked = false;
            }
            if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 2))
            {
                checkBoxMusteri.Checked = true;
            }
            else
            {
                checkBoxMusteri.Checked = false;
            }
            if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 3))
            {
                checkBoxYonetici.Checked = true;
            }
            else
            {
                checkBoxYonetici.Checked = false;
            }


        }
    }
}
