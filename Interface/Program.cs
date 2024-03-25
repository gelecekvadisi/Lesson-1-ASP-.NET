using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// INTERFACE (ARAYUZ)
			Hayvan hayvan = new Hayvan();
			hayvan.HareketEt();

			Console.WriteLine("***********");

			IHareket arac = new Arac();
			arac.HareketEt();

			Console.WriteLine("***********");

			Kus kus = new Kus();
			kus.Uc();

			Console.WriteLine("***********");

			IKisi kisi = new Calisan("Emir","Gözcü");
			kisi.AdSoyadYazidr();

			Console.ReadLine();
		}
	}
}
