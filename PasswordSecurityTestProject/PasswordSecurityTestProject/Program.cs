using System;
using System.Text.RegularExpressions;


namespace PasswordSecurityTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string sifre;
                Console.WriteLine("--------------------------------------------------------------------------------------------------");
                Console.Write("Sifre Giriniz : ");
                sifre = Console.ReadLine();

                int boslukSayisi = sifre.Length - Regex.Replace(sifre, " ", "").Length;  //Sifredeki bosluk kontrolu yapilir ve bosluk sayisi bulunur

                if (boslukSayisi > 0)       //Sifrede bosluk varsa tekrar sifre istenmesi saglanir
                {
                    Console.WriteLine("\nBosluk Oldugu Icin Sifre Gecersiz Lutfen Tekrar Sifre Giriniz!!\n");
                    continue;
                }
                else
                {
                    int buyukHarafPuani = SifrePuanlama.BuyukHarfPaun(sifre);
                    int kucukHarfPuani = SifrePuanlama.KucukHarfPuan(sifre);
                    int rakamPuani = SifrePuanlama.RakamPuan(sifre);
                    int sembolPuani = SifrePuanlama.SembolPuan(sifre);
                    int sifrePuani = buyukHarafPuani + kucukHarfPuani + rakamPuani + sembolPuani;

                    if (sifre.Length < 9)
                    {
                        Console.WriteLine("\nSifre Dokuz Karakterden Kisa Oldugu Icin Kabul Edilemez Lutfen Tekrar Sifre Giriniz!!\n");
                        continue;
                    }
                    
                    if (sifre.Length == 9 || sifre.Length > 9)
                    {
                        if (sifre.Length == 9)
                        {
                            sifrePuani += 10;            //Sifre karakter sayisinin dokuza esit olmasi durumunda sifre puanina on puan eklenir
                        }

                        if (buyukHarafPuani == 0)     //Sifrede buyuk harf olmamasi durumunda tekrar sifre istenmesi saglanir
                        {
                            Console.WriteLine("\nSifre Buyuk Harf Icermedigi Icin Kabul Edilemez Lutfen Tekrar Sifre Giriniz!!\n");
                            continue;
                        }
                        if (kucukHarfPuani == 0)    //Sifrede kucuk harf olmamasi durumunda tekrar sifre istenmesi saglanir
                        {
                            Console.WriteLine("\nSifre Kucuk Harf Icermedigi Icin Kabul Edilemez Lutfen Tekrar Sifre Giriniz!!\n");
                            continue;
                        }
                        if (rakamPuani == 0)        //Sifrede rakam olmamasi durumunda tekrar sifre istenmesi saglanir
                        {
                            Console.WriteLine("\nSifre Rakam Icermedigi Icin Kabul Edilemez Lutfen Tekrar Sifre Giriniz!!\n");
                            continue;
                        }
                        if (sembolPuani == 0)       //Sifrede sembol olmamasi durumunda tekrar sifre istenmesi saglanir
                        {
                            Console.WriteLine("\nSifre Sembol Icermedigi Icin Kabul Edilemez Lutfen Tekrar Sifre Giriniz!!\n");
                            continue;
                        }

                        if (sifrePuani < 70)
                        {
                            Console.WriteLine("\nSifre Gecersiz Lutfen Tekrar Deneyiniz\n");
                            Console.WriteLine("Sifre Puani : {0}", sifrePuani);
                            Console.WriteLine("Buyuk Harf Sayisi : {0}", SifrePuanlama.buyukHarfSayisi);
                            Console.WriteLine("Kucuk Harf Sayisi : {0}", SifrePuanlama.kucukHarfSayisi);
                            Console.WriteLine("Rakam Sayisi : {0}", SifrePuanlama.rakamSayisi);
                            Console.WriteLine("Sembol Sayisi : {0}\n", SifrePuanlama.sembolSayisi);
                        }
                        if (sifrePuani >= 70 && sifrePuani < 90)
                        {
                            Console.WriteLine("\nSifre Kabul Edilir\n");
                            Console.WriteLine("Sifre Puani : {0}", sifrePuani);
                            Console.WriteLine("Buyuk Harf Sayisi : {0}", SifrePuanlama.buyukHarfSayisi);
                            Console.WriteLine("Kucuk Harf Sayisi : {0}", SifrePuanlama.kucukHarfSayisi);
                            Console.WriteLine("Rakam Sayisi : {0}", SifrePuanlama.rakamSayisi);
                            Console.WriteLine("Sembol Sayisi : {0}\n", SifrePuanlama.sembolSayisi);
                        }
                        if (sifrePuani >= 90 && sifrePuani <= 100)
                        {
                            Console.WriteLine("\nSifre Kabul Edilir Ve Guclu\n");
                            Console.WriteLine("Sifre Puani : {0}", sifrePuani);
                            Console.WriteLine("Buyuk Harf Sayisi : {0}", SifrePuanlama.buyukHarfSayisi);
                            Console.WriteLine("Kucuk Harf Sayisi : {0}", SifrePuanlama.kucukHarfSayisi);
                            Console.WriteLine("Rakam Sayisi : {0}", SifrePuanlama.rakamSayisi);
                            Console.WriteLine("Sembol Sayisi : {0}\n", SifrePuanlama.sembolSayisi);
                        }
                        if(sifrePuani > 100)
                        {
                            Console.WriteLine("\nSifre Kabul Edilir Ve Cok Guclu\n");
                            Console.WriteLine("Sifre Puani : {0}", sifrePuani);
                            Console.WriteLine("Buyuk Harf Sayisi : {0}", SifrePuanlama.buyukHarfSayisi);
                            Console.WriteLine("Kucuk Harf Sayisi : {0}", SifrePuanlama.kucukHarfSayisi);
                            Console.WriteLine("Rakam Sayisi : {0}", SifrePuanlama.rakamSayisi);
                            Console.WriteLine("Sembol Sayisi : {0}\n", SifrePuanlama.sembolSayisi);
                        }
                    }
                }
            }
        }
    }
}



