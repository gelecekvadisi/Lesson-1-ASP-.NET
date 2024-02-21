using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorss
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Temel Aritmetik Operatörler(Sayısal)
			// 1-> Toplama(+)
			// 2-> Çıkarma(-)
			// 3-> Çarpma(*)
			// 4-> Bölme(/)
			// 5-> Modülüs(%)(Mod)

			int toplam = 10 + 5; // Toplama
			int fark = 10 - 5; // Çıkarma
			int carpim = 10 * 5; // Çarpma
			int bolum = 10 / 5; // Bölme
			int kalan = 10 % 3; // Mod
			Console.WriteLine("Kalan: " + kalan);

			//Karşılaştırma Operatörleri
			// 1-> == (Eşit)
			// 2-> != (Eşit değil)
			// 3-> > (Büyüktür)
			// 4-> < (Küçüktür)
			// 5-> >= (Büyük eşittir)
			// 6-> <= (Küçük eşittir)

			bool esitMi = (5 == 5); // true
			bool esitDegilMi = (5 != 4); // true
			bool buyukMu = (5 > 4); // true
			bool kucukMu = (3 < 4); // true
			bool buyukEsitMi = (5 >= 5); // true
			bool kucukEsitMi = (4 <= 5); // true
			Console.WriteLine(buyukMu);

			// Mantıksal Operatörler
			// 1-> && (VE) 
			// 2-> || (VEYA)
			// 3-> ! (DEĞİL)

			//             doğru     doğru
			bool sonuc = (5 > 4) && (3 < 4);
			bool sonuc2 = (5 > 4) && (3 > 4);

			bool sonuc3 = (5 < 4) || (3 > 4);

			bool sonuc4 = !(5 > 4); // false(yanlış)
			Console.WriteLine(sonuc4);

			// Atama Operatörleri
			// 1-> = (Atama)
			// 2-> += (Toplama ve Atama)
			// 3-> -= (Çıkarma ve Atama)
			// .. *= , /=, %=
			int sayi = 10;
			sayi += 5; // 15
			sayi -= 3; // 12
			sayi *= 2; // 24

			int sayi2 = 18;
			sayi2 += 5;
			sayi2 *= 2;
			sayi2 -= 10;
			Console.ReadLine();
		}
	}
}
