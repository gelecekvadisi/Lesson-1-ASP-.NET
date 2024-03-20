using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	public class Calculator
	{
		//public int Topla(int sayi1, int sayi2)
		//{
		//	return sayi1 + sayi2;
		//}
		//public int Cikar(int sayi1, int sayi2)
		//{
		//	return sayi1 - sayi2;
		//}

		// Arrow Function
		public int bolme(int sayi1, int sayi2)
		{
			if (sayi2 > 0) { return sayi1 / sayi2; }
			else { return 0; }
		}
		public int Topla(int sayi1, int sayi2) => sayi1 + sayi2;
		public int Cikar(int sayi1, int sayi2) => sayi1 - sayi2;

	}
}
