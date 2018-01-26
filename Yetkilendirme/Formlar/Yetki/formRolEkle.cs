using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Yetkilendirme12M.Helper;

namespace Yetkilendirme12M
{
    public partial class formRolEkle : DevExpress.XtraEditors.XtraForm
    {
        public string RoleName
        {
            get;
            set;
        }

        public formRolEkle()
        {
            InitializeComponent();          
        }

        private void formRolEkle_Load(object sender, EventArgs e)
        {
            if (RoleName.IsNotNullEmpty())
            {
                txtRoleName.Text = RoleName;
                this.Text = "  Rol Güncelle";
            }
        }

        private void btnRolKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bool sonuc = false;
                if (RoleName.IsNullEmpty())  ///YENİ KAYIT
                {
                    Role role = new Role();
                    role.RoleName = txtRoleName.Text.ToString2();
                    sonuc = Yetki.AddRoles(role);
                }
                else                         ///GÜNCELLEME
                {
                    sonuc = Yetki.UpdateRoles(RoleName, txtRoleName.Text.ToString2());
                }

                if (sonuc)
                {
                    Mesaj.Bilgi();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception hata)
            {
                Mesaj.Hata(hata);
            }
        }

       
    }
}