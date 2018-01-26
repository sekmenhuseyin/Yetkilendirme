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
    public partial class formIzinEkle : DevExpress.XtraEditors.XtraForm
    {
        public Perm Izin = null;

        public formIzinEkle()
        {
            InitializeComponent();          
        }

        private void formRolEkle_Load(object sender, EventArgs e)
        {
            if (Izin.IsNotNullEmpty())
            {
                txtIzinFormAdi.Text = Izin.PermName;
                txtGrupAdi.Text = Izin.Group;
                cmbTip.SelectedIndex = Izin.Type;
                this.Text = "  İzin Form Güncelle";
            }
        }


        private void btnIzinKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bool sonuc = false;
                if (Izin.IsNullEmpty())  ///YENİ KAYIT
                {
                    Izin = new Perm();
                    Izin.PermName = txtIzinFormAdi.Text.ToString2();
                    Izin.Group = txtGrupAdi.Text.ToString2();
                    Izin.Type = cmbTip.SelectedIndex.ToShort();
                    Izin.Active = chkAktif.Checked;
                    Izin.RecordDate = DateTime.Now;
                    sonuc = Yetki.AddPerm(Izin);
                }
                else                     ///GÜNCELLEME
                {
                    string permNameKey = Izin.PermName;
                    Izin.PermName = txtIzinFormAdi.Text.ToString2();
                    Izin.Group = txtGrupAdi.Text.ToString2();
                    Izin.Type = cmbTip.SelectedIndex.ToShort();
                    Izin.Active = chkAktif.Checked;
                    sonuc = Yetki.UpdatePerm(permNameKey, Izin);
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