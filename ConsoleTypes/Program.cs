using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTypes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			//Console.WriteLine("Bu c# programlama dili.");

			//string kullaniciGirisi = Console.ReadLine();
			//Console.WriteLine(kullaniciGirisi);

			Console.WriteLine("Adınız nedir?"); //ekrana çıktı verir
			string ad = Console.ReadLine(); //kullanıcıdan veri alır
			Console.WriteLine(ad);

			Console.ReadLine();
		}
	}
}
