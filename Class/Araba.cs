using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	public class Araba
	{
		public string Marka { get; set; }
		public string Model { get; set; }
		public int Yil { get; set; }

		public void BilgiYazdir()
		{
			Console.WriteLine($"Marka: {Marka}, Model: {Model}, Yıl: {Yil}");
		}
	}
}
