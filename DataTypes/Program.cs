using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Veri tipleri(Değişkenler) - Data Types
			// veri_tipi degisken_ismi = değer;

			// *** IntegerType();

			// long veri türü = tam sayı
			// short veri türü = tam sayı
			// byte veri türü = tam sayı

			// *** BooleanType();
			// * CharType();
			// *** DoubleType();

			// * DecimalType();

			// ** EnumType();

			// *** VarType();

			// ***** StringType();
			Console.ReadLine();
		}

		private static void StringType()
		{
			// string veri türü - metinsel ifadeler
			string degiskenAdı = "Metin Değeri";
			string selamlama = "Merhaba, Dünya!";

			string ad = "Emir";
			string soyad = "Gözcü";
			string tamAd = ad + " " + soyad;

			int gun = 30;
			string ay = "Mart";
			string yil = "2020";

			string tarih = string.Format("{0} {1} {2} {3}", gun, ay, yil, ad); //string format 1
			string tarih2 = $"{gun} {ay} {yil}";//string format 2
			Console.WriteLine(tarih);
			Console.WriteLine(tarih2);
			Console.WriteLine(selamlama.Length);//uzunluk
			Console.WriteLine(selamlama.ToUpper());//büyültme
			Console.WriteLine(selamlama.ToLower());//küçültme
			Console.WriteLine(selamlama.Substring(8));//kesme
		}

		private static void VarType()
		{
			// var veri türü - sistem belirler
			var sayi = 10;
			var name = 'E';
			var money = 105.30;
			var day = Gunler.Salı;
		}

		private static void EnumType()
		{
			//enumeration
			Gunler bugün = Gunler.Pazartesi;
			Console.WriteLine(bugün);
		}

		enum Gunler
		{
			Pazartesi,
			Salı,
			Çarşamba,
			Perşembe,
			Cuma,
			Cumartesi,
			Pazar
		}

		private static void DecimalType()
		{
			// decimal - parasal, finansal
			decimal sayi = 123.45M;
			decimal tutar = 150.75M;
			decimal kdvOrani = 0.18M;
			decimal kdvTutari = tutar * kdvOrani;
			Console.WriteLine(kdvTutari);
		}

		private static void DoubleType()
		{
			// Double veri türü
			double sayi1 = 123.15;
			double sayi2 = 20.75;
			double toplam = sayi1 + sayi2;
			Console.WriteLine(toplam);
		}

		private static void CharType()
		{
			// Char veri türü
			char karakter = 'A';
		}

		private static void BooleanType()
		{
			// bool(boolean) veri türü
			// - true(doğru) , - false(yanlış)
			bool durum = true;
			Console.WriteLine(durum);

			bool yagmurYagıyorMu = false;

			if (yagmurYagıyorMu == true)
			{
				Console.WriteLine("Yağmur yağıyor. Şemsiyeni al.");
			}
			else
			{
				Console.WriteLine("Bugün hava güneşli.");
			}
		}

		private static void IntegerType()
		{
			//integer - int
			int sayi1 = 10;
			int sayi2 = 5;
			int toplam = sayi1 + sayi2; // 10 + 5 = 15
			Console.WriteLine(toplam);
		}
	}
}
