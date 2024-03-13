using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string benimIsim = "Emir", benimSoyisim = "Gözcü 2";

			//METOTLAR (FONKSİYONLAR)

			hosgeldinYazdir();

			cizgiYazdir();

			IsımSoyisimYazdirma(benimIsim, benimSoyisim);

			tarihYazdir();

			hosgeldinYazdir();

			cizgiYazdir();

			ikiSayiTopla();

			IsımSoyisimYazdirma(benimIsim, benimSoyisim);

			cizgiYazdir();

			tarihYazdir();

			yuru();

			hosgeldinYazdir();

			cizgiYazdir();

			IsımSoyisimYazdirma(benimIsim, benimSoyisim);

			cizgiYazdir();

			carpmaIslemi(5, 10);

			cizgiYazdir();

			alisverisToplami(435.38, 5, 50);

			cizgiYazdir();

			kdvHesapla(159.25, 5.2);

			cizgiYazdir();

			toplamaIslemi(15, 5);

			IsımSoyisimYazdirma(benimIsim, benimSoyisim);

			cizgiYazdir();

			silindirAlaniHesapla(8, 5);

			cizgiYazdir();

			ucgenAlaniHesapla(5.8, 8.3);

			cizgiYazdir();

			hosgeldinYazdir2();
			hosgeldinYazdir2("Emir");

			cizgiYazdir();

			isimSoyisimYazdirma("Muhammed Emir", "Gözcü");
			isimSoyisimYazdirma("Muhammed Emir", "Gözcü", "Prof.Dr.");

			cizgiYazdir();

			alisverisToplami2(55.10, 3, 20);
			alisverisToplami2(55.10);

			cizgiYazdir();

			int sonucum = topla(5, 10);
			Console.WriteLine("İki sayının toplamı: " + sonucum);
			Console.WriteLine("İki sayının toplamı: " + topla(9, 18));

			cizgiYazdir();

			string adSoyad = isimSoyisimBirleştirme("Muhammed Emir", "Gözcü");
			Console.WriteLine(adSoyad);

			cizgiYazdir();

			double fiyatSon = kdvHesaplama(88.89, 3.5);
			Console.WriteLine(fiyatSon);

			cizgiYazdir();

			// 1 - PARAMETRESİZ METOTLAR

			void hosgeldinYazdir() //metot tanımlama
			{
				Console.WriteLine("Hoşgeldiniz");
			}
			void cizgiYazdir()
			{
				Console.WriteLine("--------------");
			}
			void tarihYazdir()
			{
				//bugünün tarihi
				Console.WriteLine(DateTime.Now.ToShortDateString());
			}
			void ikiSayiTopla()
			{
				Console.WriteLine("İki sayının toplamı: " + (5 + 15));
			}
			void yuru()
			{
				Console.WriteLine("Yürümeye başladı");
			}

			// 2 - PARAMETRELİ METOTLAR

			void toplamaIslemi(int sayi1, int sayi2)
			{
				Console.WriteLine("İki sayının toplamı: " + (sayi1 + sayi2));
			}
			void IsımSoyisimYazdirma(string isim, string soyisim)
			{
				Console.WriteLine(isim + " " + soyisim);
			}
			void carpmaIslemi(int sayi1, int sayi2)
			{
				Console.WriteLine("İki sayının çarpımı: " + (sayi1 * sayi2));
			}
			void kdvHesapla(double fiyat, double kdvOrani)
			{
				// fiyat + (fiyat x kdvOrani / 100) -> kdv hesaplama formül
				Console.WriteLine("Kdv sonucu fiyat: " + (fiyat + (fiyat * kdvOrani / 100)));
			}
			void alisverisToplami(double fiyat, int adet, double indirim)
			{
				// (fiyat * adet) - indirim
				Console.WriteLine("Alışveriş toplamı: " + ((fiyat * adet) - indirim));
			}
			void silindirAlaniHesapla(int yukseklik, int yaricap)
			{
				// silindir alanı -> 2 x pi x (r2) x h
				double piSayisi = 3.14;
				double sonuc = 2 * piSayisi * (yaricap * yaricap) * yukseklik;
				Console.WriteLine("Silindir hacmi: " + sonuc);
			}
			void ucgenAlaniHesapla(double taban, double yukseklik)
			{
				// üçgenin alanı -> (taban x yukseklik) / 2
				double sonuc = (taban * yukseklik) / 2;
				Console.WriteLine("Üçgenin alanı: " + sonuc);
			}

			// 3 - VARSAYILAN PARAMETRELİ METOTLAR

			void hosgeldinYazdir2(string isim = "Misafir")
			{
				Console.WriteLine("Hoşgeldin, " + isim);
			}
			void isimSoyisimYazdirma(string ad, string soyad, string unvan = "Sayın")
			{
				Console.WriteLine(unvan + " " + ad + " " + soyad);
			}
			void alisverisToplami2(double fiyat, int adet = 1, double indirim = 0)
			{
				double sonuc = (fiyat * adet) - indirim;
				Console.WriteLine("Alışveriş toplamı: " + sonuc);
			}

			// 4 - GERİYE DEĞER DÖNDÜREN METOTLAR

			int topla(int sayi1, int sayi2)
			{
				return sayi1 + sayi2;
			}
			string isimSoyisimBirleştirme(string isim, string soyisim)
			{
				return isim + " " + soyisim;
			}
			double kdvHesaplama(double fiyat, double kdvOrani)
			{
				return fiyat + (fiyat * kdvOrani / 100);
			}

			// 22:30 mola

			Console.ReadLine();
		}
	}

}

