using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data ;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(1, 101); // 1 ile 50 arasında sayı
            int tahmin;
            int hak = 7;

            Console.WriteLine("== SAYI TAHMİN OYUNU ==");
            Console.WriteLine("1 ile 50 arasında bir sayı tuttum. Bakalım tahmin edebilecek misin?");
            Console.WriteLine($"Toplam {hak} hakkın var. Bol şans!\n");

            while (hak > 0)
            {
                Console.Write("Tahminini gir: ");
                string giris = Console.ReadLine();

                if (!int.TryParse(giris, out tahmin))
                {
                    Console.WriteLine("Lütfen geçerli bir sayı gir.\n");
                    continue;
                }

                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine("\n Tebrikler! Doğru tahmin ettin.");
                    break;
                }
                else if (tahmin < rastgeleSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı dene.");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı dene.");
                }

                hak--;
                Console.WriteLine($"Kalan hakkın: {hak}\n");
            }

            if (hak == 0)
            {
                Console.WriteLine($"\n Üzgünüm! Tahmin hakkın bitti. Doğru sayı: {rastgeleSayi}");
            }

            Console.WriteLine("\nÇıkmak için bir tuşa bas...");
            Console.ReadKey();

        }
    }
}
