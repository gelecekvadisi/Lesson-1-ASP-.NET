using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyiciler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// ERİŞİM BELİRLEYİCİLER

			// 1- Public -> her yerden erişilebilir
			Araba araba = new Araba();
			araba.Model = "Ford";

			// 2- Private -> yalnızca tanımlandığı sınıf içerisinden erişilebilir
			Hesap hesap = new Hesap();
			hesap.ParaYatir(300);
			Console.WriteLine(hesap.BakiyeGoster());

			// 22:05 mola

			Console.ReadLine();
		}
	}
}
