using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public class Kus : ISes, IUcabilir
	{
		public void SesCikar()
		{
			Console.WriteLine("Cik cik");
		}

		public void Uc()
		{
			Console.WriteLine("kuş uçuyor");
		}
	}
}
