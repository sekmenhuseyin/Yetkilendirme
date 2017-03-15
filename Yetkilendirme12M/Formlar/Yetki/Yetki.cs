using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using System.Data.SqlClient;
using DevExpress.XtraBars;
using Yetkilendirme12M.Helper;

namespace Yetkilendirme12M
{
    public static class Yetki
    {

        public static void SetConnection(string Connection)
        {          
            SqlConnectionStringBuilder conbuilder = new SqlConnectionStringBuilder(Connection);
            conbuilder.InitialCatalog = "BIRIKIM";

            Properties.Settings.Default.BirikimConnectionString = conbuilder.ConnectionString;
            Properties.Settings.Default.Save();
        }

        public static string ConStr 
        {
            get { return Properties.Settings.Default.BirikimConnectionString; }
        }


        #region ROL İŞLEMLERİ
        public static List<Role> GetRoles()
        {
            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.DeferredLoadingEnabled = false;
                return Context.Roles.ToList();
            }
        }

        public static bool AddRoles(Role role)
        {
            if (role.RoleName.IsNullEmpty())
            {
                Mesaj.Uyari("Rol adı boş geçilemez !");
                return false;
            }

            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.Roles.InsertOnSubmit(role);
                Context.SubmitChanges();
            }
            return true;
        }

        public static bool UpdateRoles(string eskiRolAdi, string yeniRolAdi)
        {
            if (eskiRolAdi.IsNullEmpty() || yeniRolAdi.IsNullEmpty())
            {
                Mesaj.Uyari("Rol adı boş yada geçersiz olamaz !");
                return false;
            }

            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.ExecuteCommand("UPDATE usr.Roles SET RoleName={0} WHERE RoleName={1}", yeniRolAdi, eskiRolAdi);
            }
            return true;
        }

        public static bool DeleteRoles(string rolAdi)
        {
            if (rolAdi.IsNullEmpty())
            {
                Mesaj.Uyari("Rol adı boş yada geçersiz olamaz !");
                return false;
            }

            if (DialogResult.Yes == Mesaj.Onay(string.Format("[{0}]  adlı rolü silmek istediğinize emin misiniz ?", rolAdi)))
            {
                using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
                {
                    Context.ExecuteCommand("DELETE usr.Roles WHERE RoleName={0}", rolAdi);
                }
                return true;
            }
            else
                return false;
        }
        #endregion
   
        public static List<PermEx> GetRolePerms(string RoleName)
        {
            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.DeferredLoadingEnabled = false;

                return Context.ExecuteQuery<PermEx>(@"SELECT P.PermName, ISNULL(RP.Reading,0) Reading, 
                ISNULL(RP.Writing,0) as Writing, ISNULL(RP.Updating,0) as Updating, 
                ISNULL(RP.Deleting,0) as Deleting, P.[Group], 
                CASE P.[Type] WHEN 0 THEN 'Form' WHEN 1 THEN 'Kontrol' ELSE 'None' END as Tip  
                FROM usr.Perm(nolock) P 
                LEFT JOIN usr.RolePerm(nolock) RP ON P.PermName=RP.PermName AND RP.RoleName={0} 
                WHERE P.Active=1", RoleName).ToList();

            }
        }

        public static List<PermEx> GetUserPerms(string UserName)
        {
            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.DeferredLoadingEnabled = false;

                return Context.ExecuteQuery<PermEx>(@"SELECT P.PermName, ISNULL(UP.Reading,0) as Reading, 
                       ISNULL(UP.Writing,0) as Writing, ISNULL(UP.Updating,0) as Updating, 
                       ISNULL(UP.Deleting,0) Deleting, P.[Group],
	                   CASE P.[Type] WHEN 0 THEN 'Form' WHEN 1 THEN 'Kontrol' ELSE 'None' END as Tip  
                FROM usr.Perm (nolock) as P 
                LEFT JOIN usr.UserPerm (nolock) as UP ON P.PermName=UP.PermName AND UP.UserName={0} 
                WHERE P.Active=1 ", UserName).ToList();

            }
        }
    
        public static bool InsertUpdateRolePerm(string rolName, List<PermEx> rolePermList, string userID="")
        {

            using (TransactionScope Scope = new TransactionScope())
            {
                using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
                {

                    List<MUser> UserList = Context.ExecuteQuery<MUser>("SELECT Kod FROM usr.Users(Nolock) WHERE RoleName={0} AND Admin=0", rolName).ToList();

                    foreach (PermEx rPerm in rolePermList)
                    {
                        Context.ExecuteCommand(@"IF (SELECT COUNT(ID) FROM usr.RolePerm (Nolock) WHERE RoleName={0} AND PermName={1})=0
                        INSERT INTO usr.RolePerm (RoleName, PermName, Reading, Writing, Updating, Deleting, RecordUser, ModifiedUser) 
                                    VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {6})
                        ELSE
                        UPDATE usr.RolePerm SET Reading={2}, Writing={3}, Updating={4}, Deleting={5}, 
                               ModifiedDate=Getdate(), ModifiedUser={6} 
                               WHERE RoleName={0} AND PermName={1}"
                                    , rolName, rPerm.PermName, rPerm.Reading, rPerm.Writing, rPerm.Updating, rPerm.Deleting, userID);


                        foreach (var user in UserList)
                        {
                            Context.ExecuteCommand(@"IF (SELECT COUNT(UserName) FROM usr.UserPerm(Nolock) WHERE UserName={0} AND PermName={1})=0
                            INSERT INTO usr.UserPerm (UserName, PermName, Reading, Writing, Updating, Deleting, RecordUser, ModifiedUser) 
                                        VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {6})
                            ELSE
                            UPDATE usr.UserPerm SET Reading={2}, Writing={3}, Updating={4}, Deleting={5}, 
                                   ModifiedDate=GetDate(), ModifiedUser={6} 
                                   WHERE UserName={0} AND PermName={1}"
                                    , user.Kod, rPerm.PermName, rPerm.Reading, rPerm.Writing, rPerm.Updating, rPerm.Deleting, userID);
                        }
                    }
                }

                Scope.Complete();
            }
            return true;
        }

        public static bool InsertUpdateUserPerm(string rolName, string userName, List<PermEx> rolePermList, string userID = "")
        {
            using (TransactionScope Scope = new TransactionScope())
            {
                using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
                {

                    if (rolName.IsNullEmpty())
                    {
                        Context.ExecuteCommand("UPDATE usr.Users SET RoleName=null WHERE Kod={0}", userName);
                    }
                    else
                    {
                        Context.ExecuteCommand("UPDATE usr.Users SET RoleName={0} WHERE Kod={1}", rolName, userName);
                    }

                    foreach (PermEx rPerm in rolePermList)
                    {
                        Context.ExecuteCommand(@" IF (SELECT COUNT(UserName) FROM usr.UserPerm(Nolock) WHERE UserName={0} AND PermName={1})=0
                        INSERT INTO usr.UserPerm (UserName, PermName, Reading, Writing, Updating, Deleting, RecordUser, ModifiedUser) 
                        VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {6})
                        ELSE
                        UPDATE usr.UserPerm SET Reading={2}, Writing={3}, Updating={4}, Deleting={5}, ModifiedDate=GETDATE(), 
                        ModifiedUser={6} WHERE UserName={0} AND PermName={1}", 
                        userName, rPerm.PermName, rPerm.Reading, rPerm.Writing, rPerm.Updating, rPerm.Deleting, userID);

                    }
                }

                Scope.Complete();
            }
            return true;
        }

        #region İZİN İŞLEMLERİ
        public static bool AddPerm(Perm izin)
        {
            if (izin.PermName.IsNullEmpty())
            {
                Mesaj.Uyari("İzin form adı boş geçilemez !");
                return false;
            }

            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.Perms.InsertOnSubmit(izin);
                Context.SubmitChanges();
            }
            return true;
        }

        public static bool UpdatePerm(string permNameKey, Perm mIzin)
        {
            if (permNameKey.IsNullEmpty() || mIzin.PermName.IsNullEmpty())
            {
                Mesaj.Uyari("İzin form adı boş yada geçersiz olamaz !");
                return false;
            }

            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.ExecuteCommand("UPDATE usr.Perm SET PermName={0}, Active={1}, Type={2}, [Group]={3} WHERE PermName={4}", 
                                        mIzin.PermName, mIzin.Active, mIzin.Type, mIzin.Group, permNameKey);
            }
            return true;
        }

        public static bool DeletePerm(string permNameKey)
        {
            if (permNameKey.IsNullEmpty())
            {
                Mesaj.Uyari("İzin form adı boş olamaz !");
                return false;
            }

            if (DialogResult.Yes == Mesaj.Onay(string.Format("[{0}]  adlı izin formu silmek istediğinize emin misiniz ?", permNameKey)))
            {
                using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
                {
                    Context.ExecuteCommand("DELETE usr.Perm WHERE PermName={0}", permNameKey);
                }
                return true;
            }
            else
                return false;
          
        }
        #endregion


        #region KULLANICI İŞLEMLERİ
        public static List<User> GetUsers()
        {
            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.DeferredLoadingEnabled = false;
                return Context.Users.ToList();
            }
        }

        public static bool AddUser(List<User> kullanicilar)
        {
            if (kullanicilar[0].Kod.IsNullEmpty())
            {
                Mesaj.Uyari("Kullanıcı adı boş geçilemez !");
                return false;
            }

            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.Users.InsertAllOnSubmit(kullanicilar);
                Context.SubmitChanges();
            }
            return true;
        }

        public static bool UpdateUser(User eskiKul, User yeniKul)
        {
            if (eskiKul.Kod.IsNullEmpty() || yeniKul.Kod.IsNullEmpty())
            {
                Mesaj.Uyari("Kullanıcı adı boş yada geçersiz olamaz !");
                return false;
            }

            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.ExecuteCommand(@"UPDATE BIRIKIM.usr.Users SET Kod={0}, Sifre={1}, AdSoyad={2}, 
                EMail={3}, Aktif={4}, Admin={5}, Sirket={6} WHERE Kod={7} AND Tip={8} AND Sirket={9}", yeniKul.Kod, yeniKul.Sifre,
                yeniKul.AdSoyad, yeniKul.Email, yeniKul.Aktif, yeniKul.Admin, yeniKul.Sirket, eskiKul.Kod, eskiKul.Tip, eskiKul.Sirket);
            }
            return true;
        }



        public static bool DeleteUser(string userName)
        {
            if (userName.IsNullEmpty())
            {
                Mesaj.Uyari("Kullanıcı adı boş yada geçersiz olamaz !");
                return false;
            }

            if (DialogResult.Yes == Mesaj.Onay(string.Format("[{0}]  adlı kullanıcıyı silmek istediğinize emin misiniz ?", userName)))
            {
                using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
                {
                    Context.ExecuteCommand("DELETE BIRIKIM.usr.Users WHERE Kod={0}", userName);
                }
                return true;
            }
            else
                return false;
        }
        #endregion


        public static User LoginKontrol(int tip, string sirketKod, string userName, string password)
        {
            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.DeferredLoadingEnabled = false;
                if (Context.Users.Any(x => x.Kod == userName))
                {
                    User user = Context.Users.Where(x => x.Kod == userName && x.Tip == tip && x.Sirket == sirketKod).FirstOrDefault();
                    if (user.IsNotNull())
                    {
                        if (Sifreleme.Cozumle(user.Sifre) == password)
                        {
                            return user;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<UserPerm> LoginYetkileriniGetir(int tip, string sirketKodu, string userName)
        {
            using (UserRoleDBDataContext Context = new UserRoleDBDataContext(ConStr))
            {
                Context.DeferredLoadingEnabled = false;
                //return Context.UserPerms.Where(x=> x.UserName == userName).ToList();
                return Context.ExecuteQuery<UserPerm>(@"
                SELECT {0} as UserName, P.PermName,  
                        CASE WHEN (Select Admin From usr.Users(Nolock) Where Kod={0} AND Sirket={1} AND Tip={2})=1 
	                    THEN Cast(1 as Bit) ELSE ISNULL(UP.Reading,0) END Reading,
	                   
                        CASE WHEN (Select Admin From usr.Users(Nolock) Where Kod={0} AND Sirket={1} AND Tip={2})=1 
	                    THEN Cast(1 as Bit) ELSE ISNULL(UP.Writing,0) END Writing,
                       
                        CASE WHEN (Select Admin From usr.Users(Nolock) Where Kod={0} AND Sirket={1} AND Tip={2})=1 
	                    THEN Cast(1 as Bit) ELSE ISNULL(UP.Updating,0) END Updating,
	                   
                        CASE WHEN (Select Admin From usr.Users(Nolock) Where Kod={0} AND Sirket={1} AND Tip={2})=1 
	                    THEN Cast(1 as Bit) ELSE ISNULL(UP.Deleting,0) END Deleting
                FROM usr.Perm (Nolock) P 
                LEFT JOIN usr.UserPerm (Nolock) UP ON P.PermName=UP.PermName AND UP.UserName={0}"
                , userName, sirketKodu, tip).ToList();
            }
        }


        public static bool OkumaYetkisi(List<UserPerm> permList, string formName, params object[] kontroller)
        {
            bool sonuc = false;
            if (permList.IsNull())
                sonuc = false;
                         
            if (permList.Any(x => x.PermName == formName && x.Reading == true))
                sonuc = true;           
            else      
                sonuc = false;

            foreach (var kontrol in kontroller)
            {
                if (kontrol is BarItem)
                    (kontrol as BarItem).Visibility = sonuc ? BarItemVisibility.Always : BarItemVisibility.Never;
                else if (kontrol is Control)
                    (kontrol as Control).Visible = sonuc;
                else if (kontrol is ToolStripMenuItem)
                    (kontrol as ToolStripMenuItem).Visible = sonuc;
            }
            return sonuc;
            
        }




        public static bool YazmaYetkisi(List<UserPerm> permList, string formName, params object[] kontroller)
        {
            bool sonuc = false;
            if (permList.IsNull())
                sonuc = false;

            if (permList.Any(x => x.PermName == formName && x.Writing == true))
                sonuc = true;
            else
                sonuc = false;

            foreach (var kontrol in kontroller)
            {
                if (kontrol is BarItem)
                    (kontrol as BarItem).Enabled = sonuc;
                else if (kontrol is Control)
                    (kontrol as Control).Enabled = sonuc;
                else if (kontrol is ToolStripMenuItem)
                    (kontrol as ToolStripMenuItem).Enabled = sonuc;
            }
            return sonuc;
        }

        public static bool GuncellemeYetkisi(List<UserPerm> permList, string formName, params object[] kontroller)
        {
            bool sonuc = false;
            if (permList.IsNull())
                sonuc = false;

            if (permList.Any(x => x.PermName == formName && x.Updating == true))
                sonuc = true;
            else
                sonuc = false;

            foreach (var kontrol in kontroller)
            {
                if (kontrol is BarItem)
                    (kontrol as BarItem).Enabled = sonuc;
                else if (kontrol is Control)
                    (kontrol as Control).Enabled = sonuc;
                else if (kontrol is ToolStripMenuItem)
                    (kontrol as ToolStripMenuItem).Enabled = sonuc;
            }
            return sonuc;
        }

        public static bool SilmeYetkisi(List<UserPerm> permList, string formName, params object[] kontroller)
        {
            bool sonuc = false;
            if (permList.IsNull())
                sonuc = false;

            if (permList.Any(x => x.PermName == formName && x.Deleting == true))
                sonuc = true;
            else
                sonuc = false;

            foreach (var kontrol in kontroller)
            {
                if (kontrol is BarItem)
                    (kontrol as BarItem).Enabled = sonuc;
                else if (kontrol is Control)
                    (kontrol as Control).Enabled = sonuc;
                else if (kontrol is ToolStripMenuItem)
                    (kontrol as ToolStripMenuItem).Enabled = sonuc;
            }
            return sonuc;
        }


    }

    #region TYPE CLASSES
    public class PermEx
    {
        public string PermName { get; set; }
        public bool Reading { get; set; }
        public bool Writing { get; set; }
        public bool Updating { get; set; }
        public bool Deleting { get; set; }
        public string Group { get; set; } 
        public string Tip { get; set; }
    }

    public class MUser
    {
        public string Kod { get; set; }
    }
    #endregion
   
}
