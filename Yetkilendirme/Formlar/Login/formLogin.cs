using System;
using System.Data;
using System.Windows.Forms;
using Yetkilendirme12M.Helper;

namespace Yetkilendirme12M
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        public bool SirketAktif { get; set; }
        public DataTable dtSirket { get; set; }
        public User Kullanici { get; set; }

        string SirketKod = "";
        int Tip = -1;
        public formLogin(string sirketKod, int tip)
        {
            InitializeComponent();
            SirketKod = sirketKod;
            Tip = tip;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!SirketAktif)
            {
                labSirket.Visible = false;
                lueSirket.Visible = false;
            }
        }

        bool girisBasarili = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {           
                if (SirketAktif && lueSirket.EditValue.IsNullEmpty())
                {
                    Mesaj.Uyari("Lütfen Şirket Seçiniz.");
                    //this.DialogResult = DialogResult.None;
                }
                else
                {
                    Kullanici = Yetki.LoginKontrol(Tip, SirketKod, txtUserID.Text.ToString2(), txtPass.Text.ToString2());
                    if (Kullanici.IsNotNullEmpty())
                    {
                        girisBasarili = true;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Mesaj.Uyari("Giriş başarısız !! \nKullanıcı bilgilerinizi kontrol ediniz. ");
                        this.DialogResult = DialogResult.None;
                    }
                }

            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                Mesaj.Hata(ex, "İşlem Sırasında Bir  Hata Oluştu");
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex, "İşlem Sırasında Bir  Hata Oluştu");
            }
        }

     

    }    
}