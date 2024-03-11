using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string benimIsim = "Emir", benimSoyisim = "Gözcü 2";

            //METOTLAR (FONKSİYONLAR)

            hosgeldinYazdir();

            cizgiYazdir();

            IsımSoyisimYazdirma(benimIsim, benimSoyisim);

            tarihYazdir();

            hosgeldinYazdir();

            cizgiYazdir();

            ikiSayiTopla();

            IsımSoyisimYazdirma(benimIsim, benimSoyisim);

            cizgiYazdir();

            tarihYazdir();

            hosgeldinYazdir();

            cizgiYazdir();

            IsımSoyisimYazdirma(benimIsim, benimSoyisim);

            cizgiYazdir();

            toplamaIslemi(15, 5);

            IsımSoyisimYazdirma(benimIsim, benimSoyisim);

            cizgiYazdir();

            // 1 - PARAMETRESİZ METOTLAR

            void hosgeldinYazdir() //metot tanımlama
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            void cizgiYazdir()
            {
                Console.WriteLine("--------------");
            }
            void tarihYazdir()
            {
                //bugünün tarihi
                Console.WriteLine(DateTime.Now.ToShortDateString());
            }
            void ikiSayiTopla()
            {
                Console.WriteLine("İki sayının toplamı: " + (5 + 15));
            }

            // 2 - PARAMETLERİ METOTLAR

            void toplamaIslemi(int sayi1, int sayi2)
            {
                Console.WriteLine("İki sayının toplamı: " + (sayi1 + sayi2));
            }
            void IsımSoyisimYazdirma(string isim, string soyisim)
            {
                Console.WriteLine(isim + " " + soyisim);
            }

            Console.ReadLine();
        }
    }

}

