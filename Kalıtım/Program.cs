using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// KALITIM (INHERITANCE)

			UstSinif ustSinif = new UstSinif();
			ustSinif.UstSinifMetodu();

			Console.WriteLine("**************");

			AltSinif altSinif = new AltSinif();
			altSinif.UstSinifMetodu();

			Console.WriteLine("**************");

			Hayvan hayvan = new Hayvan();
			hayvan.YemekYe();

			Console.WriteLine("**************");

			Kedi kedi = new Kedi();
			kedi.YemekYe();
			kedi.Miyavla();

			Console.WriteLine("**************");

			Kopek kopek = new Kopek();
			kopek.YemekYe();
			kopek.Havla();

			Console.WriteLine("**************");

			Arac toyota = new Araba();
			Console.WriteLine(toyota.Marka);
			toyota.Calistir();

			Console.ReadLine();
		}
	}
}
