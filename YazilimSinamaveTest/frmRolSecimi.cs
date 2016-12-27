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
                this.Hide();
                frmyazilimci.Show();
            }
           else if(cmbRol.SelectedItem.ToString()=="Müşteri")
            {
                frmMusteri frmmusteri = new frmMusteri();
                this.Hide();
                frmmusteri.Show();
            }
           else if(cmbRol.SelectedItem.ToString()=="Yönetici")
            {
                frmYonetici frmyonetici = new frmYonetici();
                this.Hide();
                frmyonetici.Show();
            }
            else
            {
                MessageBox.Show("Aman Tanrım! Bir şeyler ters gitti!");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUyeGiris _temp = new frmUyeGiris();
            _temp.Show();
        }
    }
}
