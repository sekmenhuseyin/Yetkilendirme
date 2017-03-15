using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Yetkilendirme12M.Helper;

namespace Yetkilendirme12M
{
    public partial class formKullanici : DevExpress.XtraEditors.XtraForm
    {
        string KulKod = "";
        public formKullanici(string kulKod)
        {
            InitializeComponent();
            KulKod = kulKod;
        }

        private void formKullanici_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }      

        void VerileriGetir()
        {
            try
            {
                glueRol.Properties.DataSource = Yetki.GetRoles();
                gridKullanicilar.DataSource = Yetki.GetUsers(); 
                string userName = viewKullanicilar.GetFocusedRowCellDisplayText(gcuUserName);
                if (userName.IsNotNullEmpty())
                    gridKullaniciIzinleri.DataSource = Yetki.GetUserPerms(userName);
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void bbtnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VerileriGetir();
        }

        private void cmKullaniciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                formKullaniciEkle fmKullaniciEkle = new formKullaniciEkle(KulKod);
                if (fmKullaniciEkle.ShowDialog() == DialogResult.OK)
                {
                    gridKullanicilar.DataSource = Yetki.GetUsers(); 
                }
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void cmKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewKullanicilar.FocusedRowHandle < 0)
                    return;

                User Kul = viewKullanicilar.GetFocusedRow() as User;

                using (formKullaniciEkle fmKullaniciEkle = new formKullaniciEkle(KulKod) {  Kullanici = Kul })
                {
                    if (fmKullaniciEkle.ShowDialog() == DialogResult.OK)
                    {
                        gridKullanicilar.DataSource = Yetki.GetUsers();
                        string userName = viewKullanicilar.GetFocusedRowCellDisplayText(gcuUserName).ToString2();
                        if (userName.IsNotNullEmpty())
                        {
                            gridKullaniciIzinleri.DataSource = Yetki.GetUserPerms(userName);
                        }
                        else
                        {
                            gridKullaniciIzinleri.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
    
        }

        private void cmKullaniciSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewKullanicilar.FocusedRowHandle < 0)
                    return;

                string userName = viewKullanicilar.GetFocusedRowCellDisplayText(gcuUserName);
                bool sonuc = Yetki.DeleteUser(userName);

                if (sonuc)
                {
                    VerileriGetir();
                    Mesaj.Bilgi();
                }
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void viewKullanicilar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (viewKullanicilar.FocusedRowHandle < 0)
                {
                    gridKullaniciIzinleri.DataSource = null;
                    return;
                }

                string role = viewKullanicilar.GetFocusedRowCellDisplayText(gcuRole).Trim();
                if (role == "")
                    glueRol.EditValue = null;
                else
                    glueRol.EditValue = role;
                

                var UserPermList = Yetki.GetUserPerms(viewKullanicilar.GetFocusedRowCellDisplayText(gcuUserName));
                gridKullaniciIzinleri.DataSource = UserPermList;
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void bbtnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (viewKullanicilar.FocusedRowHandle < 0)
                    return;
                ActiveControl = groupControl1;

                string userName = viewKullanicilar.GetFocusedRowCellDisplayText(gcuUserName);
                string roleName = glueRol.EditValue.ToString2();
                List<PermEx> permList = gridKullaniciIzinleri.DataSource as List<PermEx>;

                bool sonuc = Yetki.InsertUpdateUserPerm(roleName, userName, permList, "");

                if (sonuc)
                {
                    if (glueRol.EditValue.IsNullEmpty())
                    {
                        viewKullanicilar.SetFocusedRowCellValue(gcuRole, null);
                    }
                    else
                    {
                        viewKullanicilar.SetFocusedRowCellValue(gcuRole, glueRol.EditValue);
                    }
                    Mesaj.Bilgi();
                }

            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }

        }

        private void glueRol_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (viewKullanicilar.FocusedRowHandle < 0)
                    return;

                if (viewKullanicilar.GetFocusedRowCellValue(gcuAdmin).ToBool())
                    return;

                if (glueRol.EditValue.IsNullEmpty())
                {
                    //gridKullaniciIzinleri.DataSource = Yetki.GetRolePerms("");

                    gcpReading.OptionsColumn.ReadOnly = false;
                    gcpWriting.OptionsColumn.ReadOnly = false;
                    gcpDeleting.OptionsColumn.ReadOnly = false;
                    viewKullaniciIzinleri.OptionsBehavior.Editable = true;
                }
                else
                {
                    gridKullaniciIzinleri.DataSource = Yetki.GetRolePerms(glueRol.EditValue.ToString2());

                    gcpReading.OptionsColumn.ReadOnly = true;
                    gcpWriting.OptionsColumn.ReadOnly = true;
                    gcpDeleting.OptionsColumn.ReadOnly = true;
                    viewKullaniciIzinleri.OptionsBehavior.Editable = false;
                }
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void cmTumunuSec_Click(object sender, EventArgs e)
        {
            if (glueRol.EditValue.IsNotNullEmpty())
                return;

            if (viewKullaniciIzinleri.FocusedColumn == gcpReading)
            {
                for (int i = 0; i < viewKullaniciIzinleri.RowCount; i++)
                {
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpReading, true);
                }
            }
            else if (viewKullaniciIzinleri.FocusedColumn == gcpWriting)
            {
                for (int i = 0; i < viewKullaniciIzinleri.RowCount; i++)
                {
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpWriting, true);
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpReading, true);
                }
            }
            else if (viewKullaniciIzinleri.FocusedColumn == gcpUpdating)
            {
                for (int i = 0; i < viewKullaniciIzinleri.RowCount; i++)
                {
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpUpdating, true);
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpReading, true);
                }
            }
            else if (viewKullaniciIzinleri.FocusedColumn == gcpDeleting)
            {
                for (int i = 0; i < viewKullaniciIzinleri.RowCount; i++)
                {
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpDeleting, true);
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpReading, true);
                }
            }
        }

        private void cmTumunuKaldir_Click(object sender, EventArgs e)
        {
            if (glueRol.EditValue.IsNotNullEmpty())
                return;

            if (viewKullaniciIzinleri.FocusedColumn == gcpReading)
            {
                for (int i = 0; i < viewKullaniciIzinleri.RowCount; i++)
                {
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpReading, false);
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpWriting, false);
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpUpdating, false);
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpDeleting, false);
                }
            }
            else if (viewKullaniciIzinleri.FocusedColumn == gcpWriting)
            {
                for (int i = 0; i < viewKullaniciIzinleri.RowCount; i++)
                {
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpWriting, false);
                }
            }
            else if (viewKullaniciIzinleri.FocusedColumn == gcpUpdating)
            {
                for (int i = 0; i < viewKullaniciIzinleri.RowCount; i++)
                {
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpUpdating, false);
                }
            }
            else if (viewKullaniciIzinleri.FocusedColumn == gcpDeleting)
            {
                for (int i = 0; i < viewKullaniciIzinleri.RowCount; i++)
                {
                    viewKullaniciIzinleri.SetRowCellValue(i, gcpDeleting, false);
                }
            }
        }

        private void repCeYazma_CheckedChanged(object sender, EventArgs e)
        {
            if (viewKullaniciIzinleri.FocusedRowHandle < 0)
                return;

            if ((sender as CheckEdit).Checked)
                viewKullaniciIzinleri.SetFocusedRowCellValue(gcpReading, true);
        }

        private void repCeOkuma_CheckedChanged(object sender, EventArgs e)
        {
            if (viewKullaniciIzinleri.FocusedRowHandle < 0)
                return;

            if ((bool)viewKullaniciIzinleri.GetFocusedRowCellValue(gcpWriting) 
                || (bool)viewKullaniciIzinleri.GetFocusedRowCellValue(gcpUpdating)
                || (bool)viewKullaniciIzinleri.GetFocusedRowCellValue(gcpDeleting))
                viewKullaniciIzinleri.SetFocusedRowCellValue(gcpReading, true);
        }

        private void repCeGuncelleme_CheckedChanged(object sender, EventArgs e)
        {
            if (viewKullaniciIzinleri.FocusedRowHandle < 0)
                return;

            if ((sender as CheckEdit).Checked)
                viewKullaniciIzinleri.SetFocusedRowCellValue(gcpReading, true);
        }

        private void repCeSilme_CheckedChanged(object sender, EventArgs e)
        {
            if (viewKullaniciIzinleri.FocusedRowHandle < 0)
                return;

            if ((sender as CheckEdit).Checked)
                viewKullaniciIzinleri.SetFocusedRowCellValue(gcpReading, true);

        }
    }
}