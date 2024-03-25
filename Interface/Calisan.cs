using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public class Calisan : IKisi
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }

        public Calisan(string ad, string soyad)
        {
			Ad = ad;
			Soyad = soyad;
        }
        public void AdSoyadYazidr()
		{
			Console.WriteLine($"{Ad} {Soyad}");
		}
	}
}
