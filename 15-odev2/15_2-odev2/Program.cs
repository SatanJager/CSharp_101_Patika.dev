using System;
using System.Collections;

namespace _15_2_odev2;

class Program
{
    static void Main(string[] args)
    {
        // Soru - 2: 
        // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

        int n = 20; // Tam sayı adedi
        
        int[] sayilarKumesi = new int[n]; // Array kullanarak sayıları saklamak için bir dizi oluşturduk
        
        // Klavyeden pozitif tam sayıları alma
        for (int i = 0; i < n; i++)
        {
            Console.Write((i + 1) + ". sayıyı giriniz: ");

            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilarKumesi.SetValue(sayi, i); // Girilen sayıyı diziye ekleme

            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                i--; // Geçersiz giriş, tekrar deneme hakkı var.
            }
        }

        // Girilen sayıları sıralama
        Array.Sort(sayilarKumesi);

        // En büyük 3 sayı ve en küçük 3 sayıyı alma
        int[] enKucukUc = new int[3];
        int[] enBuyukUc = new int[3];
        
        for (int i = 0; i < 3; i++)
        {
            enKucukUc[i] = (int)sayilarKumesi.GetValue(i);
            enBuyukUc[i] = (int)sayilarKumesi.GetValue(sayilarKumesi.Length - 1 - i);
        }

        double ortalamaEnKucukUc = Ortalama(enKucukUc);
        double ortalamaEnBuyukUc = Ortalama(enBuyukUc);

        // En küçük 3 sayı yazdırma
        Console.WriteLine("En küçük 3 sayı:");  
        foreach (int sayi in enKucukUc)
        {
            Console.WriteLine(sayi);
        }
        
        // En büyük 3 sayı yazdırma
        Console.WriteLine("En büyük 3 sayı:");
        foreach (int sayi in enBuyukUc)
        {
            Console.WriteLine(sayi);
        }
        
        // Ortalamaları ve toplamlarını yazdırma
        Console.WriteLine("En küçük 3 sayının ortalaması: " + ortalamaEnKucukUc);
        Console.WriteLine("En büyük 3 sayının ortalaması: " + ortalamaEnBuyukUc);
        Console.WriteLine("Ortalama toplamı: " + (ortalamaEnKucukUc + ortalamaEnBuyukUc));

    }

    //Ortalama hesaplama metodu
    static double Ortalama(int[] sayilar)
    {
        double toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam / (double)sayilar.Length;
    }


}
