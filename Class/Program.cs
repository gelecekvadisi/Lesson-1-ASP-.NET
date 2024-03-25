using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person(); // nesne oluşturduk
			person.ad = "Muhammed Emir Gözcü";
			person.yas = 23;

			Person person2 = new Person();
			person2.ad = "Şeyma Küçük";
			person2.yas = 25;

			Console.WriteLine($"Ad: {person2.ad}, Yaş: {person2.yas}");

			Console.WriteLine($"Ad: {person.ad}, Yaş: {person.yas}");

			Console.WriteLine("------------------");

			Kitap kitap1 = new Kitap
			{
				ad = "Sefiller",
				Yazar = "Victor Hugo",
				SayfaSayisi = 300
			};

			Console.WriteLine($"Kitap adı: {kitap1.ad}, yazar: {kitap1.Yazar}, sayfa sayısı: {kitap1.SayfaSayisi}");

			Console.WriteLine("------------------");

			Worker worker1 = new Worker();
			worker1.Ad = "Mehmet Uysal";
			worker1.Pozisyon = "İşçi";
			worker1.Maas = 20000;

			Console.WriteLine($"Çalışan adı: {worker1.Ad}, pozisyon: {worker1.Pozisyon}, maaş: {worker1.Maas}");

			Console.WriteLine("------------------");

			Araba araba = new Araba();
			// sınıf içerisinde özellik tanımlama
			araba.Marka = "Wolkswagen";
			araba.Model = "Jetta";
			araba.Yil = 2017;

			// sınıf içerisinde metot kullanımı
			araba.BilgiYazdir();

			Console.WriteLine("------------------");

			Calculator calculator = new Calculator();
			int toplam = calculator.Topla(10, 20);
			int fark = calculator.Cikar(10, 20);
			int bolme = calculator.bolme(10, 5);
			Console.WriteLine("Toplam: " + toplam);
			Console.WriteLine("Fark: " + fark);
			Console.WriteLine("Bölüm: " + bolme);

			Console.WriteLine("------------------");

			Product product = new Product();
			product.Ad = "Iphone 13";
			product.Fiyat = 40000;

			Console.WriteLine($"ürün adı: {product.Ad}, ürün fiyat: {product.Fiyat}");

			Console.WriteLine("------------------");

			// CONSTRUCTOR(YAPICI METOT)

			Car car = new Car("renault", "megane");
			Console.WriteLine(car.Marka + " " + car.Model);

			Console.WriteLine("------------------");

			Book book = new Book("Sefiller", "Victor Hugo", 155);
			Console.WriteLine(book.Ad + " " + book.Yazar + " " + book.SayfaSayisi);

			Console.WriteLine("------------------");

			Calisan calisan = new Calisan();
			Calisan calisan1 = new Calisan("Emir", "Bilgisayar", 1500);
			calisan.BilgileriGoster();

			Console.WriteLine("------------------");

			Ogrenci ogrenci = new Ogrenci();
			ogrenci.Ad = "Mehmet Yıldız";
			ogrenci.DersEkle("Matematik");
			ogrenci.DersEkle("Tarih");
			ogrenci.DersEkle("Biyoloji");

			ogrenci.DersleriListele();

			Console.ReadLine();
		}
	}
	class ClassName
	{
		// özellikler, metotlar, olaylar, alanlar, vs
	}
}
