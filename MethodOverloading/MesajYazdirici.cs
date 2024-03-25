using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
	public class MesajYazdirici
	{
		public void Yazdir()
		{
			Console.WriteLine("Merhaba Dünya!");
		}
		public void Yazdir(string mesaj)
		{
			Console.WriteLine(mesaj);
		}
		public void Yazdir(string mesaj, int tekrarSayisi)
		{
			for (int i = 0; i < tekrarSayisi; i++)
			{
				Console.WriteLine(mesaj);
			}
		}
	}
}
