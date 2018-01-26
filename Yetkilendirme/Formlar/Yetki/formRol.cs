using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Yetkilendirme12M.Helper;

namespace Yetkilendirme12M
{
    public partial class formRol : DevExpress.XtraEditors.XtraForm
    {
        public formRol()
        {
            InitializeComponent();
        }

        private void FrmRole_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        void VerileriGetir()
        {
            try
            {
                gridRoles.DataSource = Yetki.GetRoles();
                string rolName = viewRoles.GetFocusedRowCellDisplayText(gcRoleName);
                if (rolName.IsNotNullEmpty())
                    gridRoleIzinleri.DataSource = Yetki.GetRolePerms(rolName);
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }


        private void cmRolEkle_Click(object sender, EventArgs e)
        {
            try
            {
                formRolEkle fmRolEkle = new formRolEkle();
                if (fmRolEkle.ShowDialog() == DialogResult.OK)
                {
                    gridRoles.DataSource = Yetki.GetRoles();
                }
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void cmRolGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewRoles.FocusedRowHandle < 0)
                    return;

                using (formRolEkle fmRolEkle = new formRolEkle { RoleName = viewRoles.GetFocusedRowCellDisplayText(gcRoleName) })
                {
                    if (fmRolEkle.ShowDialog() == DialogResult.OK)
                    {
                        gridRoles.DataSource = Yetki.GetRoles();
                    }
                }
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void cmRolSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewRoles.FocusedRowHandle < 0)
                    return;

                string rolName = viewRoles.GetFocusedRowCellDisplayText(gcRoleName);
                bool sonuc = Yetki.DeleteRoles(rolName);

                if (sonuc)
                {
                    gridRoles.DataSource = Yetki.GetRoles();
                    Mesaj.Bilgi();
                }
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
                if (viewRoles.FocusedRowHandle < 0)
                    return;

                ActiveControl = groupControl1;
                string rolName = viewRoles.GetFocusedRowCellDisplayText(gcRoleName);
                List<PermEx> rolePermList = gridRoleIzinleri.DataSource as List<PermEx>;
                
                bool sonuc = Yetki.InsertUpdateRolePerm(rolName, rolePermList, "");

                if (sonuc)
                    Mesaj.Bilgi();

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

        private void viewRoles_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (viewRoles.FocusedRowHandle < 0)
                {
                    gridRoleIzinleri.DataSource = null;
                    return;
                }

                var RolPermList = Yetki.GetRolePerms(viewRoles.GetFocusedRowCellDisplayText(gcRoleName));
                gridRoleIzinleri.DataSource = RolPermList;
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }


        private void repCeYazma_CheckedChanged(object sender, EventArgs e)
        {
            if (viewRoleIzinleri.FocusedRowHandle < 0)
                return;

            if ((sender as CheckEdit).Checked)
                viewRoleIzinleri.SetFocusedRowCellValue(gcpReading, true);
        }

        private void repCeOkuma_CheckedChanged(object sender, EventArgs e)
        {
            if (viewRoleIzinleri.FocusedRowHandle < 0)
                return;

            if ((bool)viewRoleIzinleri.GetFocusedRowCellValue(gcpWriting) 
                || (bool)viewRoleIzinleri.GetFocusedRowCellValue(gcpUpdating)
                || (bool)viewRoleIzinleri.GetFocusedRowCellValue(gcpDeleting))
                viewRoleIzinleri.SetFocusedRowCellValue(gcpReading, true);
        }

        private void repCeGuncelleme_CheckedChanged(object sender, EventArgs e)
        {
            if (viewRoleIzinleri.FocusedRowHandle < 0)
                return;

            if ((sender as CheckEdit).Checked)
                viewRoleIzinleri.SetFocusedRowCellValue(gcpReading, true);
        }

        private void repCeSilme_CheckedChanged(object sender, EventArgs e)
        {
            if (viewRoleIzinleri.FocusedRowHandle < 0)
                return;

            if ((sender as CheckEdit).Checked)
                viewRoleIzinleri.SetFocusedRowCellValue(gcpReading, true);
        }


        private void cmIzinFormEkle_Click(object sender, EventArgs e)
        {
            try
            {
                formIzinEkle fmIzinEkle = new formIzinEkle();
                if (fmIzinEkle.ShowDialog() == DialogResult.OK)
                {
                    string rolName = viewRoles.GetFocusedRowCellDisplayText(gcRoleName).ToString2();
                    if (rolName.IsNotNullEmpty())
                    {
                        gridRoleIzinleri.DataSource = Yetki.GetRolePerms(rolName);
                    }
                    else
                    {
                        gridRoleIzinleri.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void cmIzinFormGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewRoleIzinleri.FocusedRowHandle < 0)
                    return;

                PermEx rPermEx = viewRoleIzinleri.GetFocusedRow() as PermEx;
                short type = 0;
                if (rPermEx.Tip == "Kontrol")
                    type = 1;
                else if (rPermEx.Tip == "None")
                    type = -1;

                using (formIzinEkle fmIzinEkle = new formIzinEkle { Izin = new Perm { PermName = rPermEx.PermName, Group = rPermEx.Group, Type=type } })
                {
                    if (fmIzinEkle.ShowDialog() == DialogResult.OK)
                    {
                        string rolName = viewRoles.GetFocusedRowCellDisplayText(gcRoleName).ToString2();
                        if (rolName.IsNotNullEmpty())
                        {
                            gridRoleIzinleri.DataSource = Yetki.GetRolePerms(rolName);
                        }
                        else
                        {
                            gridRoleIzinleri.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mesaj.Hata(ex);
            }
        }

        private void cmIzinFormSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewRoleIzinleri.FocusedRowHandle < 0)
                    return;

                string permName = viewRoleIzinleri.GetFocusedRowCellDisplayText(gcpPermName);
                bool sonuc = Yetki.DeletePerm(permName);

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

        private void cmTumunuSec_Click(object sender, EventArgs e)
        {
            if (viewRoleIzinleri.FocusedColumn == gcpReading)
            {
                for (int i = 0; i < viewRoleIzinleri.RowCount; i++)
                {
                    viewRoleIzinleri.SetRowCellValue(i, gcpReading, true);
                }
            }
            else if (viewRoleIzinleri.FocusedColumn == gcpWriting)
            {
                for (int i = 0; i < viewRoleIzinleri.RowCount; i++)
                {
                    viewRoleIzinleri.SetRowCellValue(i, gcpWriting, true);
                    viewRoleIzinleri.SetRowCellValue(i, gcpReading, true);
                }
            }
            else if (viewRoleIzinleri.FocusedColumn == gcpUpdating)
            {
                for (int i = 0; i < viewRoleIzinleri.RowCount; i++)
                {
                    viewRoleIzinleri.SetRowCellValue(i, gcpUpdating, true);
                    viewRoleIzinleri.SetRowCellValue(i, gcpReading, true);
                }
            }
            else if (viewRoleIzinleri.FocusedColumn == gcpDeleting)
            {
                for (int i = 0; i < viewRoleIzinleri.RowCount; i++)
                {
                    viewRoleIzinleri.SetRowCellValue(i, gcpDeleting, true);
                    viewRoleIzinleri.SetRowCellValue(i, gcpReading, true);
                }
            }
        }

        private void cmTumunuKaldir_Click(object sender, EventArgs e)
        {
            if (viewRoleIzinleri.FocusedColumn == gcpReading)
            {
                for (int i = 0; i < viewRoleIzinleri.RowCount; i++)
                {
                    viewRoleIzinleri.SetRowCellValue(i, gcpReading, false);
                    viewRoleIzinleri.SetRowCellValue(i, gcpWriting, false);
                    viewRoleIzinleri.SetRowCellValue(i, gcpUpdating, false);
                    viewRoleIzinleri.SetRowCellValue(i, gcpDeleting, false);
                }
            }
            else if (viewRoleIzinleri.FocusedColumn == gcpWriting)
            {
                for (int i = 0; i < viewRoleIzinleri.RowCount; i++)
                {
                    viewRoleIzinleri.SetRowCellValue(i, gcpWriting, false);
                }
            }
            else if (viewRoleIzinleri.FocusedColumn == gcpUpdating)
            {
                for (int i = 0; i < viewRoleIzinleri.RowCount; i++)
                {
                    viewRoleIzinleri.SetRowCellValue(i, gcpUpdating, false);
                }
            }
            else if (viewRoleIzinleri.FocusedColumn == gcpDeleting)
            {
                for (int i = 0; i < viewRoleIzinleri.RowCount; i++)
                {
                    viewRoleIzinleri.SetRowCellValue(i, gcpDeleting, false);
                }
            }
        }




    }
}