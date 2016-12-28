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
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        yazilimsinamaEntities db = new yazilimsinamaEntities();
        
        
        public static int uyeID = 0;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisYap(txtKulAdi.Text, txtSifre.Text);
        }

        private void lblUyelik_Click(object sender, EventArgs e)
        {
            

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                frmUyeKayit frmkayit = new frmUyeKayit();
                this.Hide();
                frmkayit.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }

        private void frmUyeGiris_Load(object sender, EventArgs e)
        {
            try
            {
                txtKulAdi.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bilinmeyen Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void buyuksekucukyap()
        {
            foreach (char chr in txtKulAdi.Text)
            {
                if (char.IsUpper(chr))
                {
                    txtKulAdi.Text = txtKulAdi.Text.Replace(chr, char.ToLower(chr));
                }
            }
        }
        private void txtKulAdi_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void txtSifre_MouseClick(object sender, MouseEventArgs e)
        {
            buyuksekucukyap();
        }
        public int GirisYap(string ad, string password)
        {

            try
            {
                if (ad !="" || password != "")
                {
                    if (db.tblUsers.Any(x => x.UserNickname == ad && x.UserPassword == password))
                    {
                        frmRolSecimi frmrol = new frmRolSecimi();
                        uyeID = db.tblUsers.FirstOrDefault(x => x.UserNickname == ad && x.UserPassword == password).UsersID;
                        tblUserLogDetails log = new YazilimSinamaveTest.tblUserLogDetails();
                        log.LogDate = DateTime.Now;
                        log.UserLogDescription = "Üye Girişi Yaptı";
                        log.Username = ad;
                        db.tblUserLogDetails.Add(log);
                        db.SaveChanges();
                        this.Hide();
                        frmrol.Show();
                        return 1;
                    }
                    else
                    {

                        MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Kullanıcı Adı Ve Şifre Alanını Boş Bırakmayınız!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Oluştu!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }

        }
    }
}
