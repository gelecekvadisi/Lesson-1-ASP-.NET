using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public class Arac : IHareket
	{
		public void HareketEt()
		{
			Console.WriteLine("Araç hareket ediyor");
		}
	}
}
