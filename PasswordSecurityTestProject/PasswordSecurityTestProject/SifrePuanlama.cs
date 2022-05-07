using System;
using System.Text.RegularExpressions;


namespace PasswordSecurityTestProject
{
    public static class SifrePuanlama
    {
        public static int puan = 0;                     // Sifre puanini tutacak degisken tanimlandi
        public static int buyukHarfSayisi = 0;          // Buyuk harf sayisini tutacak degisken tanimlandi
        public static int kucukHarfSayisi = 0;          // Kucuk harf sayisini tutacak degisken tanimlandi
        public static int rakamSayisi = 0;              // Rakam sayisini tutacak degisken tanimlandi
        public static int sembolSayisi = 0;             // Sembol sayisini tutacak degisken tanimlandi
        public static int BuyukHarfPaun(string sifre)       //Sifre icindeki buyuk harfleri bulan ve puan donduren fonksiyon tanimlandi
        {
            buyukHarfSayisi = sifre.Length - Regex.Replace(sifre, "[A-Z]|[ŞİÇÖÜĞ]", "").Length;       //Sifrenin uzunlugundan icinden aranan karakterlerin cikarildigi sifrenin uzunlugu cikarilarak istenen karakterlerin sayisi bulunur   
            puan = Math.Min(2, buyukHarfSayisi) * 10;       //Bulunan buyuk harf sayisina gore en kucuk sayi secilerek 10 ile carpilir ve puan elde edilir
            return puan;        
        }
        public static int KucukHarfPuan(string sifre)       //Sifre icindeki kucuk harfleri bulan ve puan donduren fonksiyon tanimlandi
        {
            kucukHarfSayisi = sifre.Length - Regex.Replace(sifre, "[a-z]|[şıçöüğ]", "").Length;
            puan = Math.Min(2, kucukHarfSayisi) * 10;       //Bulunan kucuk harf sayisina gore en kucuk sayi secilerek 10 ile carpilir ve puan elde edilir
            return puan;
        }
        public static int RakamPuan(string sifre)       //Sifre icindeki rakamlari bulan ve puan donduren fonksiyon tanimlandi
        {
            rakamSayisi = sifre.Length - Regex.Replace(sifre, "[0-9]", "").Length;
            puan = Math.Min(2, rakamSayisi) * 10;       //Bulunan rakam sayisina gore en kucuk sayi secilerek 10 ile carpilir ve puan elde edilir
            return puan;
        }
        public static int SembolPuan(string sifre)      //Sifre icindeki sembolleri bulan ve puan donduren fonksiyon tanimlandi
        {
            sembolSayisi = Regex.Replace(sifre, "[a-zA-Z0-9]", "").Length;      //Sifreden belirtilen karakterler ve rakamlar cikarilarak sifredeki sembol sayisi bulunur
            puan = sembolSayisi * 10;   
            return puan;
        }
    }
}
