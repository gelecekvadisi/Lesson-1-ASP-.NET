using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLineIff
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Single Line İf
			//Console.WriteLine("Bir sayi giriniz: ");
			//int sayi = Convert.ToInt32(Console.ReadLine());
			//string sonuc = sayi >= 0 ? "Sayı pozitif" : "Sayı negatif";
			//Console.WriteLine(sonuc);

			//Console.WriteLine("------------");


			//Console.WriteLine("Yaşınızı giriniz: ");
			//int yas = Convert.ToInt32(Console.ReadLine());
			//string mesaj = yas < 18 ? "Reşit değilsiniz" : "Reşitsiniz";
			//Console.WriteLine(mesaj);

			//Console.WriteLine("------------");

			//Console.WriteLine("Bir sayı giriniz: ");
			//int sayi = Convert.ToInt32(Console.ReadLine());
			//string ciftMi = (sayi % 2 == 0) ? "Çift" : "Tek";
			//Console.WriteLine(sayi + " bir " + ciftMi + " sayıdır.");

			//Console.WriteLine("------------");

			// İÇ İÇE İF KULLANIMI

			//string dogruKullaniciAdi = "admin";
			//string dogruSifre = "1234";

			//Console.WriteLine("Kullanıcı adınızı giriniz:");
			//string kullaniciAdi = Console.ReadLine();

			//Console.WriteLine("Şifrenizi giriniz:");
			//string sifre = Console.ReadLine();

			//if (kullaniciAdi == dogruKullaniciAdi)
			//{
			//	if (sifre == dogruSifre)
			//	{
			//		Console.WriteLine("Hoş geldiniz, !" + dogruKullaniciAdi);
			//	}
			//	else
			//	{
			//		Console.WriteLine("Hatalı şifre");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("Hatalı kullanıcı adı");
			//}

			//Console.WriteLine("------------");

			//Console.WriteLine("Not ortalamanızı giriniz:");
			//double notOrtalamasi = Convert.ToDouble(Console.ReadLine());

			//if (notOrtalamasi >= 50)
			//{
			//	if (notOrtalamasi >= 75)
			//	{
			//		Console.WriteLine("Tebrikler, yüksek başarı!");
			//	}
			//	else
			//	{
			//		Console.WriteLine("Geçtiniz, ancak daha iyi olabilir.");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("Maalesef, kaldınız.");
			//}

			//Console.WriteLine("------------");

			//Console.WriteLine("Yaşınızı giriniz: ");
			//int yas = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("Tecrübe yılınızı giriniz: ");
			//int tecrube = Convert.ToInt32(Console.ReadLine());

			//if (yas > 18)
			//{
			//	if (tecrube >= 5)
			//	{
			//		Console.WriteLine("İşe alındınız.");
			//	}
			//	else
			//	{
			//		Console.WriteLine("Yaşınız uygun fakat tecrübeniz yeterli değil. Daha fazla tecrübeye ihtiyacınız var.");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("Yaşınız iş için uygun değil");
			//}

			//Ödev 2

			Console.WriteLine("Bir sayı giriniz: ");
			int sayi = Convert.ToInt32(Console.ReadLine());
			string sonuc = sayi > 0 ? "Pozitif" : sayi < 0 ? "Negatif" : "Sıfır";

			Console.WriteLine(sonuc);

            Console.ReadLine();
		}
	}
}
