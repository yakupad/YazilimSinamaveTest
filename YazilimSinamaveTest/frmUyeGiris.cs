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
    public partial class frmUyeGiris : Form
    {
        
       
 
        public frmUyeGiris()
        {
            InitializeComponent();
        }
        yazilimsinamaEntities db = new yazilimsinamaEntities();
        
        
        public static int uyeID = 0;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text!="" ||txtSifre.Text!="")
            {
                if (db.tblUsers.Any(x => x.UserNickname == txtKulAdi.Text && x.UserPassword == txtSifre.Text))
                {
                    frmRolSecimi frmrol = new frmRolSecimi();
                    uyeID = db.tblUsers.FirstOrDefault(x => x.UserNickname == txtKulAdi.Text && x.UserPassword == txtSifre.Text).UsersID;
                    this.Hide();
                    frmrol.Show();
                }
                else
                {
                    MessageBox.Show("Giriş Yapılamadı");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Ve Şifre Alanını Boş Bırakmayınız!!!");
            }
        }

        private void lblUyelik_Click(object sender, EventArgs e)
        {
            

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmUyeKayit frmkayit = new frmUyeKayit();
            this.Hide();
            frmkayit.Show();
        }

        private void frmUyeGiris_Load(object sender, EventArgs e)
        {
            txtKulAdi.Select();
        }
    }
}
