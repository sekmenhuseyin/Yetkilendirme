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
    public partial class formKullaniciEkle : DevExpress.XtraEditors.XtraForm
    {
        string KulKod = "";
        public User Kullanici = null;
        public formKullaniciEkle(string kulKod)
        {
            InitializeComponent();
            KulKod = kulKod;
        }

        private void formKullaniciEkle_Load(object sender, EventArgs e)
        {
            if (Kullanici.IsNotNullEmpty())
            {
                txtKullaniciAdi.Text = Kullanici.Kod;
                txtAdiSoyadi.Text = Kullanici.AdSoyad;
                txtEmail.Text = Kullanici.Email;
                try
                {
                    txtParola.Text = Sifreleme.Cozumle(Kullanici.Sifre);
                }
                catch
                {
                    txtParola.Text = Kullanici.Sifre;
                }
                chkAdmin.Checked = Kullanici.Admin;
                chkAktif.Checked = Kullanici.Aktif;
                this.Text = "  Kullanıcı Güncelleme";
            }
        }

        private void bbtnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtKullaniciAdi.Text.IsNullEmpty())
                {
                    Mesaj.Uyari("Kullanıcı adı girmelisiniz !");
                    return;
                }

                if (txtParola.Text.IsNullEmpty())
                {
                    Mesaj.Uyari("Parola girmelisiniz !");
                    return;
                }

                string[] sirketler = txtSirketKodu.Text.Trim().Split(',');
              
                bool sonuc = false;
                if (Kullanici.IsNullEmpty())
                {
                    List<User> kulList = new List<User>();
                    for (int i = 0; i < sirketler.Length; i++)
                    {
                        Kullanici = new User();
                        Kullanici.DefaultValueSet("ID");
                        Kullanici.AdSoyad = txtAdiSoyadi.Text;
                        Kullanici.Kod = txtKullaniciAdi.Text.ToString2();
                        Kullanici.Email = txtEmail.Text;
                        Kullanici.Sifre = Sifreleme.Sifrele(txtParola.Text.ToString2());
                        Kullanici.Aktif = chkAktif.Checked;
                        Kullanici.Admin = chkAdmin.Checked;
                        Kullanici.Sirket = sirketler[i];
                        Kullanici.Tip = 1;

                      
                        Kullanici.Kaydeden = KulKod;
                        Kullanici.Degistiren = KulKod;
                        Kullanici.KayitSurum = "1.0.0";
                        Kullanici.DegisSurum = "1.0.0";
                        Kullanici.KayitTarih = DateTime.Today.ToOADate().ToInt32();
                        Kullanici.DegisTarih = Kullanici.KayitTarih; 
                        Kullanici.KayitSaat = DateTime.Now.TimeInt();
                        Kullanici.DegisSaat = Kullanici.KayitSaat;


                        kulList.Add(Kullanici);
                    }
                    sonuc = Yetki.AddUser(kulList);
                }
                else
                {
                    User eskiKul = new User();
                    eskiKul.Kod = Kullanici.Kod;
                    eskiKul.Tip = Kullanici.Tip;
                    eskiKul.Sirket = Kullanici.Sirket;

                    Kullanici.Kod = txtKullaniciAdi.Text.ToString2();
                    Kullanici.AdSoyad = txtAdiSoyadi.Text;
                    Kullanici.Email = txtEmail.Text;
                    Kullanici.Sifre = Sifreleme.Sifrele(txtParola.Text.ToString2());
                    Kullanici.Aktif = chkAktif.Checked;
                    Kullanici.Admin = chkAdmin.Checked;
                    Kullanici.Sirket = sirketler[0];

                    Kullanici.Degistiren = KulKod;
                    Kullanici.DegisTarih = DateTime.Today.ToOADate().ToInt32();
                    Kullanici.DegisSaat = DateTime.Now.TimeInt();

                    sonuc = Yetki.UpdateUser(eskiKul, Kullanici);
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
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void bbtnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtAdiSoyadi.Text = "";
            txtKullaniciAdi.Text = "";
            txtEmail.Text = "";
            txtParola.Text = "";
            chkAdmin.Checked = false;
            chkAktif.Checked = true;
        }

        private void chkParolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParolaGoster.Checked)
                txtParola.Properties.UseSystemPasswordChar = false;
            else
                txtParola.Properties.UseSystemPasswordChar = true;
        }

       
        

       
    }
}