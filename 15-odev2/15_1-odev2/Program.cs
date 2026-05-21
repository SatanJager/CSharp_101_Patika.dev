using System;
using System.Collections;

namespace _15_1_odev2;

class Program
{
    static void Main(string[] args)
    {
        // Soru - 1: 
        // Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
        // Negatif ve numeric olmayan girişleri engelleyin.
        // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.


        int n = 20; // Pozitif tam sayı adedi
        ArrayList primeNumbers = new ArrayList();
        ArrayList compositeNumbers = new ArrayList();
        ArrayList numbers = new ArrayList();

        // Klavyeden pozitif tam sayıları alma
        for (int i = 0; i < n; i++)
        {
            Console.Write((i + 1) + ". sayıyı giriniz: ");

            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi <= 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                    i--;
                    continue;
                }
                numbers.Add(sayi);
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                i--; // Geçersiz giriş, tekrar deneme hakkı var.
            }
        }

        // Girilen sayıları asal ve asal olmayan olarak ayırma ve ilgili listelere ekleme
        foreach (int sayi in numbers)
        {
            if (IsPrime(sayi))
            {
                primeNumbers.Add(sayi);
            }
            else
            {
                compositeNumbers.Add(sayi);
            }
        }

        // Listedeki asal sayıların bilgilerini ekrana yazdırma
        primeNumbers.Sort();
        primeNumbers.Reverse();
        double totalPrimeNumbers = 0;

        if (primeNumbers.Count > 0)
        {
            Console.WriteLine("Verilen Listedeki Asal Sayılar: ");
            foreach(var asal in primeNumbers)
            {
            Console.Write(asal + " ");
            totalPrimeNumbers += (int)asal;
            }
            Console.WriteLine();
            Console.WriteLine("Asal sayıların adedi: " + primeNumbers.Count);
            Console.WriteLine("Asal sayıların ortalaması: " + (totalPrimeNumbers / primeNumbers.Count));
        }
        else
        {
            Console.WriteLine("Asal sayı girilmedi.");
        }

        // Listedeki asal olmayan sayıların bilgilerini ekrana yazdırma
        compositeNumbers.Sort();
        compositeNumbers.Reverse();
        double totalCompositeNumbers = 0;

        if (compositeNumbers.Count > 0)
        {
            Console.WriteLine("Verilen Listedeki Asal Olmayan Sayılar: ");
            foreach(var asalDegil in compositeNumbers)
            {
                Console.Write(asalDegil + " ");
                totalCompositeNumbers += (int)asalDegil;
            }
            Console.WriteLine();

            Console.WriteLine("Asal Olmayan Sayıların Adedi: " + compositeNumbers.Count);
            Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + (totalCompositeNumbers / compositeNumbers.Count));
        }
        else
        {
            Console.WriteLine("Asal olmayan sayı girilmedi.");
        }

    }
    // Bir sayının asal olup olmadığını kontrol eden yardımcı metot
    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false; //0 ve 1 asal değil
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false; 
            }
        }
        return true; // Bölünen bulanamadıysa asaldır.

    }


}
