using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// VERİ TİPLERİ

			int sayi = 10;
			Console.WriteLine(sayi);

			string metin = "Merhaba Dünya!";
			Console.WriteLine(metin);

			bool mezunMu = true;
			Console.WriteLine(mezunMu);

			double piSayisi = 3.14;
			Console.WriteLine(piSayisi);

			var isimSoyisim = "Muhammed Emir Gözcü";
			var sayi2 = 152;
			Console.WriteLine(isimSoyisim);

			// veri tipleri arasında dönüşüm

			double ondalikliSayi = 9.78;
			int tamSayi = (int)ondalikliSayi;
			Console.WriteLine(tamSayi);

			int tamSayi2 = 100;
			double ondalikliSayi2 = tamSayi2;
			Console.WriteLine(ondalikliSayi2);

			string sayiMetni = "123";
			int sayi3 = Convert.ToInt32(sayiMetni);
			Console.WriteLine(sayi3);

			//OPERATÖRLER
			// 1-ARİTMETİK OPERATÖRLER

			int toplam = 10 + 5;
			int fark = 10 - 5;
			int carpim = 10 * 5;
			int bolum = 10 / 5;
			int kalan = 10 % 3;

			// 2-KARŞILAŞTIRMA OPERATÖRLERİ

			bool sonuc1 = (5 == 5);
			bool sonuc2 = (5 != 4);
			bool sonuc3 = (5 <= 4);
			bool sonuc4 = (5 >= 4);

			// 3-MANTIKSAL OPERATÖRLERİ

			bool sonuc5 = (5 > 4) && (4 > 3);
			bool sonuc6 = (5 < 4) || (4 > 3);
			bool sonuc7 = !(5 > 4);

			//İF,ELSE İF,ELSE

			int not = 49;
			if (not >= 50)
			{
				Console.WriteLine("Dersi geçtiniz.");
			}
			else
			{
				Console.WriteLine("Dersten kaldınız.");
			}

			Console.WriteLine("---------------------");

			int not2 = 68;
			if (not2 >= 80)
			{
				Console.WriteLine("Notunuz:A");
			}
			else if (not2 >= 70 && not2 < 80)
			{
				Console.WriteLine("Notunuz:B");
			}
			else if (not2 >= 60 && not2 < 70)
			{
				Console.WriteLine("Notunuz:C");
			}
			else
			{
				Console.WriteLine("Dersten kaldınız.");
			}

			// FOR DÖNGÜSÜ

			for (int i = 1; i <= 5; i++)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("---------------------");

			for (int i = 5; i <= 20; i += 5)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("---------------------");

			for (int i = 5; i >= 1; i--)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("---------------------");

			string[] renkler = { "Kırmızı", "Mavi", "Yeşil" };

			for (int i = 0; i < renkler.Length; i++)
			{
				Console.WriteLine(renkler[i]);
			}

			Console.WriteLine("---------------------");

			// FOREACH

			string[] meyveler = { "elma", "armut", "nar", "mandalina" };

			foreach (string meyve in meyveler)
			{
				Console.WriteLine(meyve);
			}

			Console.WriteLine("---------------------");

			List<int> sayilar = new List<int> { 1, 2, 5, 4, 8, 9 };
			foreach (int rakam in sayilar)
			{
				Console.WriteLine(rakam);
			}

			Console.WriteLine("---------------------");

			string[] agaclar = { "çam", "kozalak", "meşe" };
			for (int i = 0; i < agaclar.Length; i++)
			{
				Console.WriteLine($"Index: {i}, Değer: {agaclar[i]}");
			}

			// WHİLE DÖNGÜSÜ

			int sayac = 1;
			while (sayac <= 5)
			{
				Console.WriteLine(sayac);
				sayac++;
			}

			Console.WriteLine("---------------------");

			// METOTLAR

			Yazdir();
			int sonuc = topla(5, 10);
			Console.WriteLine(sonuc);

			string cumlem = "Teşekkürler, Başarılı";

			int kelimeAdedi = metinHarfUzunlugu(cumlem);
			Console.WriteLine("Metnin harf sayısı: " + kelimeAdedi);

			void Yazdir()
			{
				Console.WriteLine("Merhaba Dünya!");
			}

			int topla(int sayii1, int sayii2)
			{
				return sayii1 + sayii2;
			}

			int metinHarfUzunlugu(string cumle)
			{
				return cumle.Length;
			}

			// DİZİLER

			int[] sayilar2 = { 1, 5, 8, 4, 9 };
			int[] sayilar3 = new int[5];

			Console.WriteLine("Dizi eleman sayısı: " + sayilar3.Length);

			sayilar2[3] = 44;

			Console.WriteLine(sayilar2[3]);

			Console.WriteLine("---------");

			foreach (int sayimiz in sayilar2)
			{
				Console.WriteLine(sayimiz);
			}

			// for, foreach, while

			Console.WriteLine("---------");

			// KOLEKSİYONLAR

			List<int> rakamlar = new List<int>();
			rakamlar.Add(15);
			rakamlar.Add(8);
			rakamlar.Add(3);
			rakamlar.Add(22);
			rakamlar.Add(11);

			for (int i = 0; i < rakamlar.Count; i++)
			{
				Console.WriteLine(rakamlar[i]);
			}

			Console.WriteLine("---------");

			// SINIFLAR

			Araba araba = new Araba(); // araba nesnesi oluştu
			araba.Marka = "Renault";
			araba.Model = "Megane";
			araba.Yil = 2023;
			Console.WriteLine(araba.Model);
			araba.Calistir();

			Console.WriteLine("---------");

			Araba araba2 = new Araba()
			{
				Marka = "Ford",
				Model = "Focus",
				Yil = 2018,
			};

			Console.WriteLine(araba2.Yil);
			araba2.Calistir();

			Console.ReadLine();
		}
	}

}
