using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
	public class Matematik
	{
		public int Topla(int a, int b)
		{
			return a + b;
		}
		public int Topla(int a, int b, int c)
		{
			return a + b + c;
		}
		public double Topla(double a, double b)
		{
			return a + b;
		}
	}
}
