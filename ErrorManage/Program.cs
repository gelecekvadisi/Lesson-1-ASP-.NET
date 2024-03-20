using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorManage
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// HATA YÖNETİMİ (TRY-CATCH)
			try
			{
				// hata oluşabilecek kodları buraya yazar
			}
			catch (Exception e) // yakalama
			{
				// belirli bir hata türünü yakalar ve bu hata ile ilgili işlemler yapar
			}

			try
			{
				int sayi = int.Parse("abc");
			}
			catch (Exception e)
			{
				Console.WriteLine("Hatalı format: " + e.Message);
			}

			Console.WriteLine("------------------------");

			try
			{
				int[] dizi = new int[5];
				Console.WriteLine(dizi[10]);
			}
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine("Dizi sınırları dışında erişim: " + e.Message);
			}
			finally
			{
				Console.WriteLine("Finally çalıştı");
			}

			Console.WriteLine("------------------------");

			// 21:50 mola

			Console.ReadLine();

		}
	}
}
