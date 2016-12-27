﻿using System;
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
    public partial class frmUyeKayit : Form
    {
        yazilimsinamaEntities db = new yazilimsinamaEntities();
        
        public frmUyeKayit()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text == "" || txtKulIsmi.Text == "" || txtKulSoyad.Text == "" || txtKulParola.Text == "")
            {
                MessageBox.Show("Boş Alanları Lütfen Doldurunuz!");
            }
            else
            {
                tblUsers user = new YazilimSinamaveTest.tblUsers();
                user.UserNickname = txtKulAdi.Text;
                user.UserName = txtKulIsmi.Text;
                user.UserSurname = txtKulSoyad.Text;
                user.UserPassword = txtKulParola.Text;
                user.UserCreatedDate = DateTime.Now;
                db.tblUsers.Add(user);
                db.SaveChanges();
                tblUserRoles userrole = new YazilimSinamaveTest.tblUserRoles();
                userrole.UserID = user.UsersID;
                userrole.RoleNameID = 2;
                db.tblUserRoles.Add(userrole);
                db.SaveChanges();
                
                
                frmUyeGiris giris = new YazilimSinamaveTest.frmUyeGiris();
                this.Hide();
                giris.Show();
            }
        }

        private void lblUyeyim_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            frmUyeGiris giris = new frmUyeGiris();
            this.Hide();
            giris.Show();
        }

        
    }
}