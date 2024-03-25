using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyiciler
{
	public class Hesap
	{
		private double bakiye;

		public void ParaYatir(double miktar)
		{
			bakiye = bakiye + miktar;
		}
		public double BakiyeGoster()
		{
			return bakiye;
		}
	}
}
