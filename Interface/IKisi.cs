using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public interface IKisi
	{
		string Ad { get; set; }
		string Soyad { get; set; }
		void AdSoyadYazidr();
	}
}
