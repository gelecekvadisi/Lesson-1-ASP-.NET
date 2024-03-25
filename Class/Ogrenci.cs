using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	public class Ogrenci
	{
		public string Ad { get; set; }
		public List<string> Dersler { get; set; }

		public Ogrenci()
		{
			Dersler = new List<string>();
		}
		public void DersEkle(string ders)
		{
			Dersler.Add(ders);
		}
		public void DersleriListele()
		{
			foreach (string ders in Dersler)
			{
				Console.WriteLine(ders);
			}
			Console.WriteLine(Ad);
		}
	}
}
