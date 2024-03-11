using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Döngüsü			

            //for (int i = 0; i < 100; i++)
            //{
            //	Console.WriteLine(i);
            //}
            // i++ 1 arttırma
            // i-- 1 azaltma

            //string[] renkler = { "Kırmızı", "Yeşil", "Mavi" };

            //for (int i = 0; i < renkler.Length; i++)
            //{
            //	Console.WriteLine(renkler[i]);
            //}

            //int sayi = 20;
            //Console.WriteLine(sayi + " sayısının çarpanları:");

            //for (int i = 1; i <= sayi; i++)
            //{
            //	// karşılaştırma ya da kontrol etme
            //	if (sayi % i == 0)
            //	{
            //		Console.WriteLine(i);
            //	}
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int sayi = 10;
            //int toplam = 0;

            //for (int i = 1; i <= sayi; i++)
            //{
            //	toplam = toplam + i;
            //}
            //Console.WriteLine("1'den " + sayi + " ya kadar olan sayıların toplamı : " + toplam);

            //for (int i = 1; i <= 30; i++)
            //{
            //	if (i % 3 == 0 && i % 5 == 0)
            //	{
            //		Console.WriteLine("FizzBuzz");
            //	}
            //	else if (i % 5 == 0)
            //	{
            //		Console.WriteLine("Buzz");
            //	}
            //	else if (i % 3 == 0)
            //	{
            //		Console.WriteLine("Fizz");					
            //	}
            //	else
            //	{
            //		Console.WriteLine(i);
            //	}
            //}

            // İç içe for döngüsü

            //for (int i = 1; i <= 5; i++)
            //{
            //	for (int j = 1; j <= 5; j++)
            //	{
            //		Console.WriteLine("i: " + i + " - " + "j: " + j);
            //	}
            //}

            //int sayi = 9;

            //Console.WriteLine("Aşağıya doğru üçgen deseni:");

            //for (int i = sayi; i >= 1; i--)
            //{
            //	for (int j = 1; j <=i; j++)
            //	{
            //		Console.Write("*");
            //	}
            //	Console.WriteLine();
            //}

            //int n = 1000;

            //Console.WriteLine("1 den " + n + "e kadar olan mükemmel sayı listesi:");

            //for (int i = 1; i <= n; i++)
            //{
            //	int toplam = 0;
            //	for (int j = 1; j < i; j++)
            //	{
            //		if (i % j == 0)
            //		{
            //			toplam = toplam + j;
            //		}
            //	}
            //	if (toplam == i)
            //	{
            //		Console.WriteLine(i);
            //	}
            //}

            //Console.WriteLine("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktoriyel = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //	faktoriyel = faktoriyel * i;
            //	Console.WriteLine("----------");
            //	Console.WriteLine(i);
            //}

            //Console.WriteLine($"{sayi}! = {faktoriyel}");

            //ÖDEV 1

            //int toplam = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine("1'den 100'e kadar olan sayıların toplamı: " + toplam);

            //ÖDEV 4

            //int tekSayilar = 0, ciftSayilar = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftSayilar++;
            //    }
            //    else
            //    {
            //        tekSayilar++;
            //    }
            //}

            //Console.WriteLine($"Tek Sayıların sayısı: {tekSayilar}, Cift sayıların sayısı: {ciftSayilar}");

            Console.ReadLine();
        }
    }
}
