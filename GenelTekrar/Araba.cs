using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
	public class Araba
	{
		public string Marka { get; set; }
		public string Model { get; set; }
		public int Yil { get; set; }

		public void Calistir()
		{
			Console.WriteLine($"{Yil} {Marka} {Model} araç çalıştı.");
		}
	}
}
