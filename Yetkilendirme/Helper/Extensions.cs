﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Reflection;

namespace Yetkilendirme12M.Helper
{
    public static class Extensions
    {

        #region GENEL TİP DÖNÜŞÜMLERİ

        /// <summary>
        /// <para>Gelen değeri Int32 türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static int ToInt32(this object Deger, int defaultValue = 0)
        {
            try { return Convert.ToInt32(Deger); }
            catch { return defaultValue; }
        }

        /// <summary>
        /// <para>Gelen değeri Int32 türüne dönüştürür.</para>
        /// Hata olursa 0 döner.
        /// </summary>
        public static int ToInt32(this object Deger)
        {
            try { return Convert.ToInt32(Deger); }
            catch { return 0; }
        }


        /// <summary>
        /// <para>Gelen değeri Short (Int16) türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static short ToShort(this object Deger, short defaultValue = 0)
        {
            try { return Convert.ToInt16(Deger); }
            catch { return defaultValue; }
        }


        /// <summary>
        /// <para>Gelen değeri Long (Int64) türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static long ToLong(this object Deger, long defaultValue = 0)
        {
            try { return Convert.ToInt64(Deger); }
            catch { return defaultValue; }
        }

        /// <summary>
        /// <para>Gelen değeri Double türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static double ToDouble(this object Deger, double defaultValue = 0.0)
        {
            try { return Convert.ToDouble(Deger); }
            catch { return defaultValue; }
        }

        /// <summary>
        /// <para>Gelen değeri Float türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static float ToFloat(this object Deger, float defaultValue = 0.0f)
        {
            try { return Convert.ToSingle(Deger); }
            catch { return defaultValue; }
        }

        /// <summary>
        /// <para>Gelen değeri Decimal türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static decimal ToDecimal(this object Deger, decimal defaultValue = 0.0M)
        {
            try { return Convert.ToDecimal(Deger); }
            catch { return defaultValue; }
        }

        /// <summary>
        /// <para>Gelen değeri Char türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static char ToChar(this object Deger, char defaultValue = ' ')
        {
            try { return Convert.ToChar(Deger); }
            catch { return defaultValue; }
        }


        /// <summary>
        /// <para>Gelen değeri DateTime türüne dönüştürür.</para>
        /// <para> Hata olursa "01.01.1970" değeri döner.</para>
        /// format değerini 1 gönderirseniz saat kısmını o anki saat olarak set eder.
        /// </summary>
        public static DateTime ToDatetime(this object Deger, int format = 0)
        {
            DateTime mDeger;
            try
            {
                if (format == 1)
                {
                    mDeger = DateTime.Parse(Deger.ToString());
                    mDeger = new DateTime(mDeger.Year, mDeger.Month, mDeger.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                }
                else
                {
                    mDeger = DateTime.Parse(Deger.ToString());
                }
            }
            catch
            {
                mDeger = new DateTime(1970, 1, 1);
            }
            return mDeger;
        }

        /// <summary>
        /// <para>Gelen değeri DateTime türüne dönüştürür.</para>
        /// <para> Hata olursa NULL değeri döner.</para>
        /// format değerini 1 gönderirseniz saat kısmını o anki saat olarak set eder.
        /// </summary>
        public static DateTime? ToDatetimeNull(this object Deger, int format = 0)
        {
            DateTime? mDeger = null;
            try
            {
                if (format == 1)
                {
                    mDeger = DateTime.Parse(Deger.ToString());
                    mDeger = new DateTime(mDeger.Value.Year, mDeger.Value.Month, mDeger.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                }
                else
                {
                    mDeger = DateTime.Parse(Deger.ToString());
                }
            }
            catch
            {
                mDeger = null;
            }
            return mDeger;
        }

        /// <summary>
        /// <para>Gelen değeri Bool türüne dönüştürür.</para>
        /// Hata olursa defaultValue parametresi döner.
        /// </summary>
        public static bool ToBool(this object Deger, bool defaultValue = false)
        {
            try { return Convert.ToBoolean(Deger); }
            catch { return defaultValue; }
        }

        /// <summary>
        /// <para>Gelen değeri String türüne dönüştürür.</para>
        /// Trimle boşluklar atılır. Hata olursa defaultValue döner.
        /// </summary>
        public static string ToString2(this object Deger, string defaultValue = "")
        {
            try { return Convert.ToString(Deger).Trim(); }
            catch { return defaultValue; }
        }


        /// <summary>
        /// <para>Gelen değeri string olarak alır ve ifadeyi ters çevirir.</para>
        /// Hata olursa defaultValue döner.
        /// </summary>
        public static string ToReverse(this string Deger, string defaultValue = "?")
        {
            try
            {
                char[] dizi = Deger.ToCharArray();
                Array.Reverse(dizi);
                return new string(dizi);
            }
            catch { return defaultValue; }
        }

        /// <summary>
        /// Gelen değer NULL ise boşluk değilse aynı değeri döndürür
        /// </summary>
        public static object IfNullGetValue(this object Deger)
        {
            if (Deger == DBNull.Value || Deger == null)
            {
                return "";
            }
            else
                return Deger;
        }


        /// <summary>
        /// ? operatöründe kullanılan karşılaştırmayı yapar. 
        /// İlk parametre hangi değerle karşılaştırıldığını gösterir.
        /// Eğer sonuc true ise ikinci parametre değilse üçüncü parametre döner.
        /// </summary>
        public static string IfElse(this object Deger, object EsitKosulu, string Esitse, string Degilse)
        {
            if (Deger.Equals(EsitKosulu))
                return Esitse;
            else
                return Degilse;
        }

        /// <summary>
        /// Int tipindeki değerleri DateTime tipine dönüştürür.
        /// </summary>
        public static DateTime IntToDateTime(this int Deger)
        {
            DateTime date = new DateTime(1899, 12, 30);
            date = date.AddDays(Deger);
            return date;
        }

        /// <summary>
        /// DateTime tipindeki saat kısmını alıp int olarak saat değeri üretir.
        /// </summary>
        public static int TimeInt(this DateTime DateSaat)
        {
            int saat = 0;
            if (DateSaat.Hour >= 1)
            {
                saat += DateSaat.Hour * 60 * 60;
            }
            if (DateSaat.Minute >= 1)
            {
                saat += DateSaat.Minute * 60;
            }
            if (DateSaat.Second > 0)
            {
                saat += DateSaat.Second;
            }
            return saat;
        }

        /// <summary>
        /// IEnumerable tipleri DataTable'a dönüştürür.  Örnek List<Class> => DataTable
        /// </summary>
        public static DataTable ToDataTable<T>(this IEnumerable<T> collection)
        {
            DataTable newDataTable = new DataTable();
            Type impliedType = typeof(T);
            PropertyInfo[] _propInfo = impliedType.GetProperties();
            foreach (PropertyInfo pi in _propInfo)
            {
                if (pi.Name.Substring(0, 1) == "_")
                    continue;

                if (!pi.PropertyType.IsGenericType)
                    newDataTable.Columns.Add(pi.Name, pi.PropertyType);
                else
                    newDataTable.Columns.Add(pi.Name, pi.PropertyType.GetGenericArguments()[0]);
            }

            foreach (T item in collection)
            {
                DataRow newDataRow = newDataTable.NewRow();
                newDataRow.BeginEdit();
                foreach (PropertyInfo pi in _propInfo)
                {
                    if (pi.Name.Substring(0, 1) == "_")
                        continue;

                    try
                    {
                        if (pi.GetValue(item, null).IsNotNull())
                            newDataRow[pi.Name] = pi.GetValue(item, null);
                        else
                            newDataRow[pi.Name] = DBNull.Value;
                    }
                    catch
                    { }
                }
                newDataRow.EndEdit();
                newDataTable.Rows.Add(newDataRow);
            }

            newDataTable.AcceptChanges();
            return newDataTable;
        }
        #endregion   // GENEL TİP DÖNÜŞÜMLERİ

        #region TİPLERDE BOŞLUK NULL KONTROLLERİ
        /// <summary>
        /// Null ve DBNULL kontrolü yapar 
        /// </summary>
        public static bool IsNull(this object value)
        {
            if (value == DBNull.Value || value == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Null ve DBNULL değilse true döner
        /// </summary>
        public static bool IsNotNull(this object value)
        {
            if (value == DBNull.Value || value == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Null ve DBNULL değilse true döner
        /// </summary>
        public static bool IsNullEmpty(this object value)
        {
            if (value == null) return true;
            if (value == DBNull.Value) return true;
            if (value.ToString().Trim() == string.Empty) return true;
            return false;
        }

        public static bool IsNotNullEmpty(this object value)
        {
            if (value == null) return false;
            if (value == DBNull.Value) return false;
            if (value.ToString().Trim() == string.Empty) return false;
            return true;
        }
        #endregion  // TİPLERDE BOŞLUK NULL KONTROLLERİ


        public static object ToType<T>(this object obj, T type)
        {
            //create instance of T type object:
            var tmp = Activator.CreateInstance(Type.GetType(type.ToString()));

            //loop through the properties of the object you want to covert:          
            foreach (PropertyInfo pi in obj.GetType().GetProperties())
            {
                try
                {
                    //get the value of property and try 
                    //to assign it to the property of T type object:
                    tmp.GetType().GetProperty(pi.Name).SetValue(tmp,
                                              pi.GetValue(obj, null), null);
                }
                catch { }
            }

            //return the T type object:         
            return tmp;
        }

        /// <summary>
        /// Aynı tipteki nesnenin değerlerini kendine set eder 
        /// </summary>
        public static void Set(this object obj, object deger, List<string> istisnalar = null)
        {

            foreach (PropertyInfo pi in deger.GetType().GetProperties())
            {
                if (istisnalar != null)
                {
                    if (istisnalar.Contains(pi.Name))
                        continue;
                }

                try
                {
                    deger.GetType().GetProperty(pi.Name).SetValue(obj, pi.GetValue(deger, null), null);
                }
                catch { }
            }
        }




        /// <summary>
        /// Propertisi olan nesnelerin propertisini default değerler verir.
        /// </summary>
        /// <param name="Istisnalar">Default değeri set edilmeyecek propertyleri belirtmek gerekiyor.</param>
        public static void DefaultValueSet(this object Deger, params string[] Istisnalar)
        {
            foreach (var pi in Deger.GetType().GetProperties())
            {
                if (Istisnalar.Contains(pi.Name))
                    continue;

                if (pi.PropertyType == typeof(string))
                    pi.SetValue(Deger, "", null);
                else if (pi.PropertyType == typeof(decimal))
                    pi.SetValue(Deger, 0.0m, null);
                else if (pi.PropertyType == typeof(int) || pi.PropertyType == typeof(short) ||
                         pi.PropertyType == typeof(Single) || pi.PropertyType == typeof(double))
                    pi.SetValue(Deger, (short)0, null);
            }
        }

    }
}
