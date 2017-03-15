using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Yetkilendirme12M.Helper
{

    /// <summary>
    /// Otomatik mesaj tipleri
    /// </summary>
    public enum MesajTip
    {
        /// <summary>
        /// İşlem başarıyla gerçekleştirildi
        /// </summary>
        Basari1,
        /// <summary>
        /// İşlem başarılı
        /// </summary>
        Basari2,
        /// <summary>
        /// Dikkat
        /// </summary>
        Uyari1
    }

    public class Mesaj
    {
        private static Timer Time = new Timer() { Interval = 400 };
        public static string ResimYol = Application.StartupPath;
        private static MemoryStream ms = new MemoryStream();

        private static bool acikKapali = true;
        /// <summary>
        /// AcikKapali değeri false ise Uyari ve Bilgi mesajları gösterilmez. 
        /// Default değeri true dur.
        /// </summary>
        public static bool AcikKapali
        {
            get { return acikKapali; }
            set { acikKapali = value; }
        }

        public static void Bilgi(string mesaj="İşlem başarıyla gerçekleşti.")
        {
            XtraMessageBox.Show(mesaj, "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Uyari(string mesaj)
        {

            XtraMessageBox.Show(mesaj, "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult Onay(string mesaj, MessageBoxButtons MBB = MessageBoxButtons.YesNo, MessageBoxIcon MBI = MessageBoxIcon.Question)
        {
            return XtraMessageBox.Show(mesaj, "Onaylama Mesajı", MBB, MBI);
        }

        /// <summary>
        ///<para>Üçüncü parametre hatanın oluştuğu metodun hangi controle ait olduğunu gösterir.</para> 
        ///<para>Örnek kullanım:  Mesaj.Hata(ex,"Özel mesajımdır.",sender)</para> 
        /// Dikkat: sender Control tipine cast edilebilmeli.
        /// </summary>
        public static void Hata(Exception ex, string mesaj = null)
        {
            try
            {

                Exception exx = DipHata(ex);
                //EkranGoruntusuAlmayaBasla();

                if (mesaj.IsNullEmpty())
                    mesaj = "";
                else
                    mesaj += "\n";

                bool Detay = false;

                StackFrame callStack = new StackFrame(1, true);
                if (Detay)
                {
                    mesaj += "Dosya Adı: " + callStack.GetMethod().DeclaringType.Name + "\n";
                    mesaj += "Metot Adı: " + callStack.GetMethod().Name + "\n";
                    mesaj += "Kaynak   : " + exx.Source + "\n";
                    mesaj += "Mesaj    : " + exx.Message + "\n";
                    mesaj += "StackTrace :" + exx.StackTrace;
                    XtraMessageBox.Show(mesaj, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mesaj += "Dosya Adı: " + callStack.GetMethod().DeclaringType.Name + "\n";
                    mesaj += "Metot Adı: " + callStack.GetMethod().Name + "\n";
                    mesaj += "Kaynak   : " + exx.Source + "\n";
                    mesaj += "Mesaj    : " + exx.Message;
                    XtraMessageBox.Show(mesaj, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //if (Ayarlar.HatalariYaz)
                //{
                //    SOLARDataDataContext LinqSql = new SOLARDataDataContext(Ayarlar.SOLARConStr);
                //    HLG01 hata = new HLG01();
                //    hata.Kod = AnaForm.Kullanici.Kod;
                //    hata.KayitTarih = (DateTime.Now.ToShortDateString().ToDatetime().ToOADate()).ToInt32();
                //    hata.Source = ex.Source;
                //    hata.ExceptionType = ex.GetType().FullName;
                //    hata.Message = ex.Message;
                //    hata.StackTrace = ex.StackTrace;
                //    hata.ErrorImage = ms.ToArray();
                //    LinqSql.HLG01s.InsertOnSubmit(hata);
                //    LinqSql.SubmitChanges();
                //}

            }
            catch (Exception exx)
            {
                XtraMessageBox.Show("Hata yazdırırken hata :(" + exx.Message);
            }
        }

        public static void HataYazmadan(string mesaj = "")
        {
            XtraMessageBox.Show(mesaj, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static void Goster(MesajTip tip)
        {
            switch (tip)
            {
                case MesajTip.Basari1:
                    Mesaj.Bilgi("İşlem başarıyla gerçekleştirildi.");
                    break;
                case MesajTip.Basari2:
                    Mesaj.Bilgi("İşlem başarılı");
                    break;
                case MesajTip.Uyari1:
                    Mesaj.Uyari("Dikkat");
                    break;
                default:
                    break;
            }
        }

        private static Exception DipHata(Exception hata)
        {
            if (hata.InnerException != null)
                return DipHata(hata.InnerException);
            else
                return hata;
        }


        private static void EkranGoruntusuAlmayaBasla()
        {
            Time.Tick += Time_Tick;
            Time.Start();
        }

        private static void Time_Tick(object sender, EventArgs e)
        {
            Time.Stop();
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics grafik = Graphics.FromImage(bitmap);
            grafik.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Jpeg);
            //string dosyaAdi = DateTime.Now.ToString("yyyy-MM-dd__HH-mm-ss");
            //bitmap.Save(ResimYol + dosyaAdi + ".jpeg", ImageFormat.Jpeg);
            Time.Tick -= Time_Tick;
        }
    }
}
