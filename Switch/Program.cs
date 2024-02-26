using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//switch

			//int gun = 1;

			//switch (gun)
			//{
			//	case 1:
			//		Console.WriteLine("Pazartesi");
			//		break;
			//	case 2:
			//		Console.WriteLine("Salı");
			//		break;
			//	case 3:
			//		Console.WriteLine("Çarşamba");
			//		break;
			//	case 4:
			//		Console.WriteLine("Perşembe");
			//		break;
			//	case 5:
			//		Console.WriteLine("Cuma");
			//		break;
			//	case 6:
			//		Console.WriteLine("Cumartesi");
			//		break;
			//	case 7:
			//		Console.WriteLine("Pazar");
			//		break;
			//}

			Console.WriteLine("---------------");

			//Console.WriteLine("Birinci sayıyı giriniz:");
			//int sayi1 = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("İkinci sayıyı giriniz:");
			//int sayi2 = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("Yapmak istediğiniz işlemi giriniz(+,-,*,/): ");
			//char islem = Console.ReadKey().KeyChar;
			//Console.WriteLine();

			//switch (islem)
			//{
			//	case '+':
			//		Console.WriteLine("Toplam: " + (sayi1 + sayi2));
			//		break;
			//	case '-':
			//		Console.WriteLine("Fark: " + (sayi1 - sayi2));
			//		break;
			//	case '*':
			//		Console.WriteLine("Çarpım: " + (sayi1 * sayi2));
			//		break;
			//	case '/':
			//                 if (sayi2 != 0)
			//                 {
			//			Console.WriteLine("Bölüm: " + (sayi1 / sayi2));
			//		}
			//		else
			//		{
			//			Console.WriteLine("Bir sayı sıfıra bölünemez");
			//		}
			//                 break;
			//	default:
			//		Console.WriteLine("Geçersiz işlem");
			//		break;
			//}

			Console.WriteLine("-------------------");

			//Console.WriteLine("Bir sayı giriniz: ");
			//int sayi = Convert.ToInt32(Console.ReadLine());
			//string durum;

			//switch (sayi % 2)
			//{
			//	case 0:
			//		durum = "Çift sayı";
			//		break;
			//	case 1:
			//		durum = "Tek sayı";
			//		break;
			//	default:
			//		durum = "Geçersiz sayı";
			//		break;
			//}
			//Console.WriteLine(durum);

			Console.WriteLine("-------------------");

			//Console.WriteLine("Not değerinizi giriniz:");
			//int not = Convert.ToInt32(Console.ReadLine());

			//char harfNotu;

			//switch (not / 10)
			//{
			//	case 10:
			//	case 9:
			//		harfNotu = 'A';
			//		break;
			//	case 8:
			//		harfNotu = 'B';
			//		break;
			//	case 7:
			//		harfNotu = 'C';
			//		break;
			//	case 6:
			//		harfNotu = 'D';
			//		break;
			//	default:
			//		harfNotu = 'F';
			//		break;
			//}
			//Console.WriteLine($"{not} değerinize karşılık gelen harf notunuz : {harfNotu}");

			//Console.WriteLine("-------------------");

			Console.WriteLine("Gün sayısı giriniz: ");
			int gunSayisi = Convert.ToInt32(Console.ReadLine());

			string ayAdi;

			switch (gunSayisi)
			{
				case 28:
				case 29:
					ayAdi = "Şubat";
					break;
				case 30:
					ayAdi = "Nisan, Haziran, Eylül, Kasım";
					break;
				case 31:
					ayAdi = "Ocak, Mart, Mayıs, Temmuz, Ağustos, Ekim,Aralık";
					break;
				default:
					ayAdi = "Geçersiz gün sayısı";
					break;
			}
			Console.WriteLine("Bu ay " + ayAdi + " ayıdır.");

			Console.ReadLine();			
		}
	}
}
