using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKey
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sonuc = Toplam(5, 4, 9, 6, 7, 15, 12, 2, 9);
			Console.WriteLine(sonuc);

			Console.WriteLine("--------------------");

			Console.WriteLine(Birlestir("Hello", "World","C#"));

			int Toplam(params int[] sayilar)
			{
				int toplam = 0;
				foreach (int sayi in sayilar)
				{
					toplam = toplam + sayi;
				}
				return toplam;
			}
			string Birlestir(params string[] kelimeler)
			{
				return string.Join(" ", kelimeler);
			}

			Console.ReadLine();
		}

	}
}
