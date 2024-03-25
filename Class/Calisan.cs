using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	public class Calisan
	{
		public string Ad { get; set; }
		public string Pozisyon { get; set; }
		public decimal Maas { get; set; }
		public void BilgileriGoster()
		{
			Console.WriteLine("Ad: " + Ad + " Pozisyon: " + Pozisyon + " Maaş: " + Maas);
		}
		public Calisan()
		{
			Ad = "Bilinmiyor";
			Pozisyon = "Bilinmiyor";
			Maas = 0;
		}
		public Calisan(string ad, string pozisyon, decimal maas)
		{
			Ad = ad;
			Pozisyon = pozisyon;
			Maas = maas;
		}
	}
}
