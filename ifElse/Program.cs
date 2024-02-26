using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sayi = 10;
			if (sayi > 0)
			{
				Console.WriteLine("sayı pozitif");
			}

			Console.WriteLine("-----------");

			int yas = 12;
			if (yas >= 18)
			{
				Console.WriteLine("Reşitsiniz");
			}
			else
			{
				Console.WriteLine("Reşit değilsiniz");
			}

			Console.WriteLine("-----------");


			// ctrl + k + d
			int not = 79;
			if (not >= 90)
			{
				Console.WriteLine("Harf notunuz : AA");
			}
			else if (not >= 80)
			{
				Console.WriteLine("Harf notunuz : BA");
			}
			else if (not >= 70)
			{
				Console.WriteLine("Harf notunuz : BB");
			}
			else if (not >= 50)
			{
				Console.WriteLine("Harf notunuz : CC");
			}
			else
			{
				Console.WriteLine("Daha düşük bir not aldınız: FF");
			}

			Console.WriteLine("-----------");

			int harfNotu = 79;
			if (harfNotu >= 70)
			{
				Console.WriteLine("Notunuz 70'ten büyük");
			}
			if (harfNotu > 60)
			{
				Console.WriteLine("Notunuz 60'ten büyük");
			}
			if (harfNotu > 50)
			{
				Console.WriteLine("Notunuz 50'ten büyük");
			}

			//Console.WriteLine("-----------");

			//string dogurKullaniciAdi = "admin";
			//string dogruSifre = "1234";

			//Console.WriteLine("Kullanıcı adını giriniz: ");
			//string kullaniciAdi = Console.ReadLine();

			//Console.WriteLine("Şifreyi giriniz: ");
			//string sifre = Console.ReadLine();

			//if ((kullaniciAdi == dogurKullaniciAdi) && (sifre == dogruSifre))
			//{
			//	Console.WriteLine("Sisteme giriş başarılı.");
			//}
			//else
			//{
			//	Console.WriteLine("Giriş başarısız.");
			//}

			Console.WriteLine("-----------");

			//Console.WriteLine("Ay numarasını giriniz(1-12): ");
			//int ay = Convert.ToInt32(Console.ReadLine());

			//if (ay == 12 || ay == 1 || ay == 2)
			//{
			//	Console.WriteLine("Kış Mevsimi");
			//}
			//else if (ay >= 3 && ay <= 5)
			//{
			//	Console.WriteLine("İlkbahar mevsimi");
			//}
			//else if (ay >= 6 && ay <= 8)
			//{
			//	Console.WriteLine("Yaz mevsimi");
			//}
			//else if (ay >= 9 && ay <= 11)
			//{
			//	Console.WriteLine("Sonbahar mevsimi");
			//}
			//else
			//{
			//	Console.WriteLine("Geçersiz ay numarası girdiniz.");
			//}

			Console.WriteLine("-----------");

			//ÖDEV 1

			//Console.WriteLine("Hava sıcaklığını giriniz:");
			//int sicaklikDegeri = Convert.ToInt32(Console.ReadLine());

			//if (sicaklikDegeri < 5)
			//{
			//	Console.WriteLine("Soğuk");
			//}
			//else if (sicaklikDegeri >= 5 && sicaklikDegeri <= 25)
			//{
			//	Console.WriteLine("Ilık");
			//}
			//else
			//{
			//	Console.WriteLine("Sıcak");
			//}

			//Console.WriteLine("-----------");

			//ÖDEV 3

			//Console.WriteLine("Notunuzu Giriniz (0-100): ");
			//int ogrenciNotu = Convert.ToInt32(Console.ReadLine());
			//// int tam sayı, string metin

			//if (ogrenciNotu >= 60)
			//{
			//	Console.WriteLine("Geçti");
			//}
			//else
			//{
			//	Console.WriteLine("Kaldı");
			//}

			Console.WriteLine("-----------");

			//ÖDEV 5

			//Console.WriteLine("Üç adet sayı giriniz: ");
			//int sayi1 = Convert.ToInt32(Console.ReadLine());
			//int sayi2 = Convert.ToInt32(Console.ReadLine());
			//int sayi3 = Convert.ToInt32(Console.ReadLine());

			//int enBuyukSayi = sayi1;

			//         if (sayi2 > enBuyukSayi)
			//         {
			//	enBuyukSayi = sayi2;
			//         }
			//if (sayi3>enBuyukSayi)
			//{
			//	enBuyukSayi = sayi3;
			//}

			//Console.WriteLine("En büyük sayı: " + enBuyukSayi);

			Console.WriteLine("-----------");

			Console.WriteLine("Birinci sayıyı giriniz: ");
			double sayi1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("İkinci sayıyı giriniz: ");
			double sayi2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Yapmak istediğiniz işlemi giriniz(+ , - , * , /): ");

			char islem = Console.ReadKey().KeyChar;
			Console.WriteLine();			

			if (islem == '+')
			{
				Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
			}
			else if (islem == '-')
			{
				Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
			}
			else if (islem == '*')
			{
				Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
			}
			else if (islem == '/')
			{
				if (sayi2 != 0)
				{
					Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
				}
				else
				{
					Console.WriteLine("Bir sayı sıfıra bölünemez!");
				}
			}
			else
			{
				Console.WriteLine("Geçersiz işlem!");
			}

			Console.ReadLine();

			
		}
	}
}
