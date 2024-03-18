using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Koleksiyonlar(Collections)

			// 1-) List -> Sıralı bir şekilde, tekrar edenlere izin verilir.
			// int[] -> dizi
			// List<int> -> liste

			List<int> sayilar = new List<int>();
			sayilar.Add(15); // listeye eleman ekleme
			sayilar.Add(22);
			sayilar.Add(3);
			sayilar.Add(21);
			sayilar.Add(15);
			sayilar.Add(8);

			sayilar.Remove(21); // listeden veri silme
			sayilar.RemoveAt(1); // listede indexe göre veri silme

			//sayilar.Clear(); // tüm verileri silme

			bool isItem = sayilar.Contains(21); // veriyi içerip içermeme durumu

			Console.WriteLine("------");

			int sayimiz = sayilar.ElementAt(0); // indeksteki sayıyı verir

			int ilkEleman = sayilar.First();
			int sonEleman = sayilar.Last();
			Console.WriteLine(sayimiz);
			Console.WriteLine("------");
			Console.WriteLine(isItem);
			Console.WriteLine("------");
			Console.WriteLine(ilkEleman);
			Console.WriteLine("------");
			Console.WriteLine(sonEleman);

			foreach (int sayi in sayilar)
			{
				Console.WriteLine(sayi);
			}

			Console.WriteLine("Liste boyutu: " + sayilar.Count); //eleman sayısı

			Console.ReadLine();

			// array list farkı
			// arrayler ( int[] ) dizinin boyutu en başta verilmeli, sonradan veri eklenemz
			// listlere sonradan eklenebilir ve boyutu sonra belirlenebilir

			int[] dizi = { 1, 5, 8, 9, 15 };

			Console.WriteLine("--------------");

			// 2-) Dictionary (anahtar/değer - key/value)


			Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
			kullanicilar.Add(1, "Muhammed");
			kullanicilar.Add(2, "Emir");
			kullanicilar.Add(3, "Tuba");
			kullanicilar.Add(4, "Şeyma");
			kullanicilar.Add(5, "Talha");

			Console.WriteLine(kullanicilar[3] + " " + kullanicilar[4]);

			Console.WriteLine("--------------");

			Dictionary<string, string> kimlikBilgileri = new Dictionary<string, string>();

			kimlikBilgileri.Add("Emir", "151526");
			kimlikBilgileri.Add("Tuba", "251475");
			kimlikBilgileri.Add("Şeyma", "120212");
			kimlikBilgileri.Add("Talha", "123852");

			Console.WriteLine(kimlikBilgileri["Şeyma"]);

			Console.WriteLine("--------------");

			// 3-) HashSet
			// tekrar eden verileri almaz

			HashSet<int> sayilar2 = new HashSet<int>();
			sayilar2.Add(15);
			sayilar2.Add(15);
			sayilar2.Add(25);
			sayilar2.Add(25);
			sayilar2.Add(12);

			Console.WriteLine(sayilar2.Count);

			Console.ReadLine();
		}
	}
}
