using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while döngüsü
            // true = doğru
            // false = yanlış

            //int sayi = 0;

            //while (sayi < 5)
            //{
            //	Console.WriteLine(sayi);
            //	sayi++;
            //}

            //int sayi = 1;

            //while (sayi <= 10)
            //{
            //	if (sayi % 2 == 0)
            //	{
            //		Console.WriteLine(sayi);
            //	}
            //	sayi++;
            //}

            //int sayi = 5;
            //int faktoriyel = 1;
            //int sayac = 1;

            //while (sayac <= sayi)
            //{
            //	Console.WriteLine(sayac);
            //	faktoriyel = faktoriyel * sayac;
            //	sayac++;
            //}
            //Console.WriteLine(faktoriyel);

            //int toplam = 0;
            //int sayac = 1;
            //Console.Write("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //while (sayac <= sayi)
            //{
            //	toplam = toplam + sayac;
            //	sayac++;
            //}
            //Console.WriteLine(toplam);

            //int baslangic = 1; 
            //int bitis = 10;
            //int toplam = 0;

            //Console.WriteLine(baslangic + " ile " + bitis + " arasındaki tek sayıların toplamı: ");

            //         while (baslangic<=bitis)
            //         {
            //	if (baslangic % 2 != 0)
            //	{
            //		toplam = toplam + baslangic;
            //	}
            //	baslangic++;
            //         }
            //Console.WriteLine(toplam);

            //string cevap = "";

            //while (cevap != "evet" && cevap != "hayır")
            //{
            //	Console.WriteLine("Devam etmek istiyor musunuz? (evet/hayır)");
            //	cevap = Console.ReadLine().ToLower();
            //}
            //Console.WriteLine("Cevabınız: " + cevap);


            // sonsuz döngü !!!
            //while (true)
            //{
            //	Console.WriteLine("Döngü");
            //}

            //ÖDEV 1

            //Random rnd = new Random();

            //int rastgeleSayi = rnd.Next(1, 11);
            //int tahmin = 0;

            //while (tahmin != rastgeleSayi)
            //{
            //    Console.WriteLine("Bir sayı tahmin edin (1-10): ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin != rastgeleSayi)
            //    {
            //        Console.WriteLine("Yanlış tahmin, tekrar deneyin. ");
            //    }
            //    Console.WriteLine("Rastgele sayı değeri: " + rastgeleSayi);
            //}

            //Console.WriteLine("Doğru tahmin!");

            //ÖDEV 5

            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            while (sayi > 0)
            {
                toplam = toplam + (sayi % 10);
                sayi = sayi / 10;
            }

            Console.WriteLine("Basamakların toplamı: " + toplam);

            Console.ReadLine();

        }
    }
}
