using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool asalMi = true;

            if (sayi < 2) //sayi 2 den küçük
            {
                asalMi = false;
            }
            else if (sayi == 2) //sayi 2 ye eşit
            {
                asalMi = true;
            }
            else //sayi 2 den büyük
            {
                for (int i = 2; i <= (sayi - 1); i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
            }

            if (asalMi)
            {
                Console.WriteLine($"{sayi} bir asal sayıdır.");
            }else
            {
                Console.WriteLine($"{sayi} bir asal sayı değildir.");
            }

            Console.ReadLine();
        }
    }
}
