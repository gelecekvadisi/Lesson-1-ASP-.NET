using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeToType
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//// 1-Kapalı Dönüşüm
			//int sayi = 123;
			//// int -> double
			//double ondalikliSayi = sayi;
			//Console.WriteLine(ondalikliSayi);		

			//// 2-Açık Dönüşüm
			//double sayi1 = 123.45; // kesirli
			//int sayi2 = (int)sayi1; // tam
			//Console.WriteLine(sayi2);

			//// 3-Parse
			//string metin = "100";
			//int sayi3 = int.Parse(metin);
			//Console.WriteLine(sayi3);

			//Console.WriteLine("--------");

			//// 4-Convert
			//Console.WriteLine("İlk sayıyı giriniz:");
			//int sayim1 = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("İkinci sayıyı giriniz:");
			//int sayim2 = Convert.ToInt32(Console.ReadLine());

			//int toplam = sayim1 + sayim2;
			//Console.WriteLine("Toplam: " + toplam);
			//Console.ReadLine();

			// Ödev 1
			bool liseMezunuMu = true;
			Console.WriteLine("Lise mezunu mu: " + liseMezunuMu);

			// Ödev 2
			double piSayisi = 3.14;
			Console.WriteLine(piSayisi);

			// Ödev 3
			int sayi1 = 10;
			int sayi2 = 20;
			int toplam = sayi1 + sayi2;
			Console.WriteLine("Toplam: " + toplam);
			Console.ReadLine();
		}
	}
}
