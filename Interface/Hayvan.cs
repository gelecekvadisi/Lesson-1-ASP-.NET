using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public class Hayvan : IHareket
	{
		public void HareketEt()
		{
			Console.WriteLine("Hayvan hareket ediyor");
		}
	}
}
