using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> sayilar = new List<int>();
			sayilar.Add(150);

			List<string> meyveler = new List<string>();
			meyveler.Add("elma");

			List<double> ucretler = new List<double>();
			List<bool> bools = new List<bool>();

			Console.WriteLine("****************");

			MyGenericClass<GenericClass> genericClass = new MyGenericClass<GenericClass>(150);
			Console.WriteLine(genericClass.NumberGet());

			Console.ReadLine();
		}
	}
}
