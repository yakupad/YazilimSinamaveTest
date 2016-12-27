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
            textBoxAd.Enabled = textBoxKullanıcıAd.Enabled = textBoxParola.Enabled = textBoxSoyad.Enabled = false;
        }
        int userID;
        private void comboBoxUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            checkBoxYazilimci.Enabled = checkBoxYonetici.Enabled = checkBoxMusteri.Enabled = true;
            tblUsers user = db.tblUsers.Where(x => x.UserNickname == comboBoxUyeler.SelectedItem.ToString()).FirstOrDefault();
            textBoxAd.Text = user.UserName;
            textBoxKullanıcıAd.Text = user.UserNickname;
            textBoxParola.Text = user.UserPassword;
            textBoxSoyad.Text = user.UserSurname;
            dateTimePickerKayitTarihi.Value = user.UserCreatedDate.Value;
            userID = user.UsersID;
            if(db.tblUserRoles.Any(x=>x.UserID==userID&&x.RoleNameID==1))
            {
                checkBoxYazilimci.Checked = true;
            }
            if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 2))
            {
                checkBoxMusteri.Checked = true;
            }
            if (db.tblUserRoles.Any(x => x.UserID == userID && x.RoleNameID == 3))
            {
                checkBoxYonetici.Checked = true;
            }

        }

        private void checkBoxMusteri_CheckedChanged(object sender, EventArgs e)
        {
            
            if(checkBoxMusteri.Checked==true)
            {
                tblUserRoles rol = new tblUserRoles();
                rol.UserID = userID;
                rol.RoleNameID = 2;
                db.tblUserRoles.Add(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID+ "'li Üyenin rolünü müşteri olarak değiştirdi.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else
            {
                tblUserRoles rol = db.tblUserRoles.Where(x=>x.RoleNameID==2&&x.UserID==userID).FirstOrDefault();
                db.tblUserRoles.Remove(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "'li Üyenin rolünü müşteri olmaktan çıkardı.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
                
        }

        private void checkBoxYazilimci_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYazilimci.Checked == true)
            {
                tblUserRoles rol = new tblUserRoles();
                rol.UserID = userID;
                rol.RoleNameID = 1;
                db.tblUserRoles.Add(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "'li Üyenin rolünü yazılımcı olarak değiştirdi.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else
            {
                tblUserRoles rol = db.tblUserRoles.Where(x => x.RoleNameID == 1 && x.UserID == userID).FirstOrDefault();
                db.tblUserRoles.Remove(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "'li Üyenin rolünü yazılımcı olmaktan çıkardı.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
        }

        private void checkBoxYonetici_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYonetici.Checked == true)
            {
                tblUserRoles rol = new tblUserRoles();
                rol.UserID = userID;
                rol.RoleNameID = 3;
                db.tblUserRoles.Add(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "'li Üyenin rolünü yönetici olarak değiştirdi.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else
            {
                tblUserRoles rol = db.tblUserRoles.Where(x => x.RoleNameID == 3 && x.UserID == userID).FirstOrDefault();
                db.tblUserRoles.Remove(rol);
                db.SaveChanges();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = userID + "'li Üyenin rolünü yönetici olmaktan çıkardı.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
        }

        private void btnKulGuncelle_Click(object sender, EventArgs e)
        {
           
        }
    }
}
