using System;
using System.Collections;

namespace _15_2_odev2;

class Program
{
    static void Main(string[] args)
    {
        // Soru - 2: 
        // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

        int n = 20; // Pozitif tam sayı adedi
        ArrayList sayilarKumesi = new ArrayList();
        
        // Klavyeden pozitif tam sayıları alma
        for (int i = 0; i < n; i++)
        {
            Console.Write((i + 1) + ". sayıyı giriniz: ");

            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilarKumesi.Add(sayi);

            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                i--; // Geçersiz giriş, tekrar deneme hakkı var.
            }
        }

        // Girilen sayıları sıralama
        sayilarKumesi.Sort();

        // En büyük 3 sayı ve en küçük 3 sayıyı alma
        ArrayList enKucukUc = new ArrayList();
        ArrayList enBuyukUc = new ArrayList();

        for (int i = 0; i < 3; i++)
        {
            enKucukUc.Add(sayilarKumesi[i]);
            enBuyukUc.Add(sayilarKumesi[sayilarKumesi.Count - 1 - i]);
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
    static double Ortalama(ArrayList sayilar)
    {
        double toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam / sayilar.Count;
    }


}
