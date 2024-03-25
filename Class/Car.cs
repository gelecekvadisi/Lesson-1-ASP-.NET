using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	public class Car
	{
		public string Marka { get; set; }
		public string Model { get; set; }

		public Car(string marka, string model) // constructor(yapıcı metot)
		{
			Marka = marka;
			Model = model;
		}
	}
}
