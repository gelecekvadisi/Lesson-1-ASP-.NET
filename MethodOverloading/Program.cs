using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// METHOD OVERLOADING
			Matematik matematik = new Matematik();
			Console.WriteLine(matematik.Topla(10.8,23.7));

			Console.WriteLine("*********************");

			MesajYazdirici yazdirici = new MesajYazdirici();
			yazdirici.Yazdir("Merhaba Emir", 5);


			Console.ReadLine();
		}
	}
}
