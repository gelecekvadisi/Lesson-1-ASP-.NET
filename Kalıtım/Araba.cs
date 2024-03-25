using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
	public class Araba : Arac
	{
        public bool IsHaveAClose { get; set; }
        public Araba()
		{
			Marka = "Toyota";
		}
	}
}
