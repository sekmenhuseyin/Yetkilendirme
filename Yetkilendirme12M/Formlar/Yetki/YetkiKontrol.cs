using System.Collections.Generic;
using System;
using Yetkilendirme12M.Helper;

namespace Yetkilendirme12M
{
    public class YetkiKontrol
    {
        /// <summary>
        /// Üzerinde Kontrol işleminin yapılacağı Yetki Listesi. İlgili Kullanıcıya Ait Yetki Listesi olacak.
        /// </summary>
        public List<UserPerm> YetkiList { get; set; }
        /// <summary>
        /// <para>Evrak Yeni Kayıt işlemi için kayıt yapılan formun üzerinde kontrol edilecek kontroller. (buton, menü, vs) </para>
        /// <para>	1. Sadece Yeni Kayıt Yapar</para>
        /// <para>	2. Evrağı çağırabilir. Evrağı Silemez. Satır silemez. Satır ekleyemez.  Satırları Güncelleyemez. Sadece Görür</para>
        /// </summary>
        public List<object> YeniKayitKontrolList { get; set; }
        /// <summary>
        /// <para>Evrak Güncelleme işlemi için kayıt yapılan formun üzerinde kontrol edilecek kontroller. (buton, menü, vs) </para>
        /// <para>  1. Yeni Kayıt hiçbir zaman açamaz.</para>
        /// <para>	2. Evrağı Çağırır. Satır Ekleyebilir. Satır Silebilir. Satırları güncelleyebilir.</para>
        /// <para>  3. Evrağı Silemez.</para>
        /// <para></para>
        /// </summary>
        public List<object> GuncellemeKontrolList { get; set; }
        /// <summary>
        /// <para>Evrak Silme işlemi için kayıt yapılan formun üzerinde kontrol edilecek kontroller. (buton, menü, vs) </para>
        /// <para>	1. Evrağı Çağırır ve Siler. Bunun Dışında hiçbir şey yapamaz. Satır da silemez.</para>
        /// </summary>
        public List<object> SilmeKontrolList { get; set; }

        /// <summary>
        /// Yetki Adı (Kayıt işleminin üzerinde yapıldığı form, ekran, ekranın yetki ismi)
        /// </summary>
        public string FormName { get; set; }

        public YetkiKontrol(List<UserPerm> yetkiList, string formName)
        {
            if (yetkiList == null)
                throw new ArgumentException("Yetki Listesi boş. Yetkilendirme hatalı!!");
            if (string.IsNullOrWhiteSpace(formName))
                throw new ArgumentNullException("Yetki Adı boş.");
            YetkiList = yetkiList;
            FormName = formName;

            YeniKayitKontrolList = new List<object>();
            GuncellemeKontrolList = new List<object>();
            SilmeKontrolList = new List<object>();
        }


        public void YeniKayitKontrolList_Add(params object[] kontrols)
        {
            if(kontrols == null || kontrols.Length == 0)
                return;

            foreach (var obj in kontrols)
                YeniKayitKontrolList.Add(obj);
        }

        public void GuncellemeKontrolList_Add(params object[] kontrols)
        {
            if (kontrols == null || kontrols.Length == 0)
                return;

            foreach (var obj in kontrols)
                GuncellemeKontrolList.Add(obj);
        }

        public void SilmeKontrolList_Add(params object[] kontrols)
        {
            if (kontrols == null || kontrols.Length == 0)
                return;

            foreach (var obj in kontrols)
                SilmeKontrolList.Add(obj);
        }

        public bool YeniKayitKontrol(bool mesajVer = false)
        {
            bool sonuc = Yetki.YazmaYetkisi(YetkiList, FormName, YeniKayitKontrolList.ToArray());
            if (sonuc == false && mesajVer)
                Mesaj.Uyari("Yeni Kayıt yetkiniz bulunmamaktadır!!");
            return sonuc;
        }

        public bool GuncellemeKontrol(bool mesajVer = false)
        {
            bool sonuc = Yetki.GuncellemeYetkisi(YetkiList, FormName, GuncellemeKontrolList.ToArray());
            if (sonuc == false && mesajVer)
                Mesaj.Uyari("Güncelleme yetkiniz bulunmamaktadır!!");
            return sonuc;
        }

        public bool SilmeKontrol (bool mesajVer = false)
        {
            bool sonuc = Yetki.SilmeYetkisi(YetkiList, FormName, SilmeKontrolList.ToArray());
            if (sonuc == false && mesajVer)
                Mesaj.Uyari("Silme yetkiniz bulunmammaktadır!!");
            return sonuc;
        }

        public void BaslangicGenelKontrol()
        {
            Yetki.YazmaYetkisi(YetkiList, FormName, YeniKayitKontrolList.ToArray());
            Yetki.SilmeYetkisi(YetkiList, FormName, SilmeKontrolList.ToArray());
        }

        public bool YeniKayitYetki
        {
            get { return Yetki.YazmaYetkisi(YetkiList, FormName); }            
        }

        public bool GuncellemeYetki
        {
            get { return Yetki.GuncellemeYetkisi(YetkiList, FormName); }
        }

        public bool SilmeYetki 
        {
            get { return Yetki.SilmeYetkisi(YetkiList, FormName); }
        }


    }
}
