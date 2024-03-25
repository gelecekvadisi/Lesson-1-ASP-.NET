using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	public class Book
	{
		public string Ad { get; set; }
		public string Yazar { get; set; }
		public int SayfaSayisi { get; set; }

		public Book(string ad, string yazar, int sayfaSayisi)
		{
			Ad = ad;
			Yazar = yazar;
			SayfaSayisi = sayfaSayisi;
		}
	}
}
