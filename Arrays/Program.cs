using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// DİZİLER (ARRAYS)
			int sayi1 = 2;
			int sayi2 = 5;
			int sayi3 = 10;

			// veriTipi[] diziAdi


			// Diziye değer atama
			// 1;
			int[] sayilar = new int[5];
			sayilar[0] = 15;
			sayilar[1] = 8;
			sayilar[2] = 4;
			sayilar[3] = 9;
			sayilar[4] = 16;

			// 2;
			int[] sayilar2 = new int[] { 2, 5, 10 };

			// 3;
			int[] sayilar3 = { 2, 5, 10, 5, 8, 9, 13, 15 };

			Console.WriteLine(sayilar3[2]);

			string[] isimler = { "Şeyma", "Faika", "Tuba", "Muhammed", "Emir" };
			Console.WriteLine(isimler.Length); //eleman sayısı

			for (int i = 0; i < isimler.Length; i++)
			{
				Console.WriteLine(isimler[i]);
			}

			Console.WriteLine("-----------------");

			//int[] sayilar3 = { 2, 5, 10, 5, 8, 9, 13, 15 };

			for (int i = 0; i < sayilar.Length; i++)
			{
				Console.WriteLine("Sayılar dizinin " + i + ". elemanı = " + sayilar[i]);
			}

			Console.WriteLine("-----------------");

			//int[] sayilar3 = { 2, 5, 10, 5, 8, 9, 13, 15 };

			int toplam = 0;

			foreach (int sayi in sayilar3)
			{
				Console.WriteLine(sayi);
				toplam = toplam + sayi;
			}
			Console.WriteLine("Döngüdeki sayıların toplamı : " + toplam);

			Console.WriteLine("-----------------");

			//int[] sayilar3 = { 2, 5, 10, 5, 8, 9, 13, 15 };

			int enBuyukSayi = sayilar3[0];

			for (int i = 1; i < sayilar3.Length; i++)
			{
				if (sayilar3[i] > enBuyukSayi)
				{
					enBuyukSayi = sayilar3[i];
				}
			}
			Console.WriteLine("En büyük sayı: " + enBuyukSayi);

			Console.WriteLine("-----------------");

			//int[] sayilar3 = { 2, 5, 10, 5, 8, 9, 13, 15 };

			Array.Sort(sayilar3);

			foreach (int sayi in sayilar3)
			{
				Console.WriteLine(sayi);
			}

			Console.ReadLine();
		}
	}
}
