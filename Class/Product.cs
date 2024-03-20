using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	public class Product
	{
		public string Ad { get; set; }
		private decimal urunfiyat;
		public decimal Fiyat
		{
			get { return urunfiyat; } // çağırma işlemleri
			set { urunfiyat = value < 0 ? 0 : value; } // tanımlama işlemi
		}
	}
}
