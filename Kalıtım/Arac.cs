using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
	public class Arac
	{
        public string Marka { get; set; }
		public void Calistir()
		{
			Console.WriteLine($"{Marka} araç çalıştırıldı.");
		}
    }
}
