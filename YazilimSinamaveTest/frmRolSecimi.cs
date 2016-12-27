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
    public partial class frmRolSecimi : Form
    {
        public frmRolSecimi()
        {
            InitializeComponent();
        }
        yazilimsinamaEntities db = new yazilimsinamaEntities();
        private void frmRolSecimi_Load(object sender, EventArgs e)
        {
            foreach (var item in db.tblUserRoles.Where(x=>x.UserID==frmUyeGiris.uyeID))
            {
                cmbRol.Items.Add(item.tblRoleNames.RoleName);
            }
            if (cmbRol.Items.Count == 0)
            {
                MessageBox.Show("Bu Kullanıcının hiç bir giriş yetkisi bulunmamaktadır!");
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = "yetkisiz olarak giriş yapmaya çalıştı.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
            }
            else
            {
                cmbRol.SelectedIndex = 0;
            }
        }

        private void btnRolGiris_Click(object sender, EventArgs e)
        {
           if(cmbRol.SelectedItem.ToString()=="Yazılımcı")
            {
                frmYazilimci frmyazilimci = new frmYazilimci();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = "Yazılımcı olarak giriş yaptı.";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
                this.Hide();
                frmyazilimci.Show();
            }
           else if(cmbRol.SelectedItem.ToString()=="Müşteri")
            {
                frmMusteri frmmusteri = new frmMusteri();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = "Müşteri olarak giriş yaptı";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
                this.Hide();
                frmmusteri.Show();
            }
           else if(cmbRol.SelectedItem.ToString()=="Yönetici")
            {
                frmYonetici frmyonetici = new frmYonetici();
                tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                log.LogDate = DateTime.Now;
                log.UserLogDescription = "Yönetici olarak giriş yaptı";
                log.Username = db.tblUsers.FirstOrDefault(x => x.UsersID == frmUyeGiris.uyeID).UserNickname;
                db.tblUserLogDetails.Add(log);
                db.SaveChanges();
                this.Hide();
                frmyonetici.Show();
            }
            else
            {
                MessageBox.Show("Aman Tanrım! Bir şeyler ters gitti!");
            }

        }
    }
}
