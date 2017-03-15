using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yetkilendirme12M;
using Yetkilendirme12M.Helper;

namespace WinTestApp
{
    public partial class AnaForm : Form
    {

        public static User Kullanici { get; set; }
        public static List<UserPerm> KullaniciYetkileri { get; set; }
        public AnaForm()
        {
            InitializeComponent();

            Yetki.SetConnection("Data Source=TESTSERVER; Database=12M; Persist Security Info=True;User ID=sa;Password=Birikim12");
        }

    
        private void btnRolePerm_Click(object sender, EventArgs e)
        {
            formRol frm = new formRol();
            frm.ShowDialog();
        }

        private void btnUserPerm_Click(object sender, EventArgs e)
        {
            formKullanici frm = new formKullanici("Admin");
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formLogin frm = new formLogin("00001", 1);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Kullanici = frm.Kullanici;
                KullaniciYetkileri = Yetki.LoginYetkileriniGetir(1, Kullanici.Sirket, Kullanici.Kod);
                Mesaj.Bilgi("Giriş başarılı. Yetkiler alındı.");
            }                   
        }

        private void btnYazma_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {

        }

        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            txtCozulmus.Text = Sifreleme.Cozumle(txtSifreli.Text);
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            txtCozulmus.Text = Sifreleme.Sifrele(txtSifreli.Text);
        }
    }
}
