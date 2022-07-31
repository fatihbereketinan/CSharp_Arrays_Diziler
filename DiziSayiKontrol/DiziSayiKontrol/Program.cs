using System;

namespace DiziSayiKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 5, 10, 15, 35, 45, 8, 3, 12, 100, 85, 75, 62, 69, 83, 71, 71, 85, 71, 5, 10, 71 };

            while (true)
            {
                int toplam = 0;

                Console.Write("Lütfen bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (sayilar[i] == sayi)
                    {
                        toplam = toplam + 1;
                    }
                }
                if (toplam > 0)
                {
                    Console.WriteLine(sayi + " sayısı dizi içerisinde " + toplam + " adet bulunmuştur");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı dizi içerisinde bulunamamıştır.");
                }
            }
        }
    }
}
