namespace _08_1_if_else;

class Program
{
    static void Main(string[] args)
    {
        // If-Else If-Ternary-If Kullanımı
        // Koşullu ifadeler, programın akışını belirlemek için kullanılır
        // If-Else yapısı, belirli bir koşul doğruysa bir kod bloğunu çalıştırır, yanlışsa başka bir kod bloğunu çalıştırır
        Console.WriteLine("***** If-Else If-Ternary-If Kullanımı *****");

        int number = 25;        
        if (number > 0)
        {
            Console.WriteLine("Sayı pozitiftir.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Sayı negatiftir.");
        }
        else
        {
            Console.WriteLine("Sayı sıfırdır.");
        }

        // Ternary If Kullanımı
        // Koşullu ifadeleri daha kısa bir şekilde yazmak için kullanılır
        Console.WriteLine("***** Ternary If Kullanımı *****");
        string result = (number % 2 == 0) ? "Sayı çifttir." : "Sayı tektir.";
        Console.WriteLine(result);

        // Nested If Kullanımı
        // Bir if bloğunun içinde başka bir if bloğu kullanımı
        
        Console.WriteLine("***** Nested If Kullanımı *****");
        Console.Write("Yaşınızı giriniz: ");

        try
        {
            int age = int.Parse(Console.ReadLine()!);
            if (age >= 18)
            {
                if (age < 65)
                {
                    Console.WriteLine("Yetişkinsiniz.");
                }
                else
                {
                    Console.WriteLine("Emeklisiniz.");
                }
            }
            else
            {
                Console.WriteLine("Çocuksunuz.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
        }

        // Nested If Kullanımı (Hata kontrolü olmadan)
        Console.WriteLine("***** Nested If Kullanımı (Hata kontrolü olmadan) *****");
        Console.Write("Yaşınızı giriniz: ");
        int age1 = int.Parse(Console.ReadLine()!);
        if (age1 >= 18)
        {
            if (age1 < 65)
            {
                Console.WriteLine("Yetişkinsiniz.");
            }
            else
            {
                Console.WriteLine("Emeklisiniz.");
            }
        }
        else
        {
            Console.WriteLine("Çocuksunuz.");
        }

        //Örnek uygulama
        Console.WriteLine("***** Örnek Uygulama *****");

        int time = DateTime.Now.Hour;
        if (time >= 6 && time < 12) 
        {
            Console.WriteLine("Günaydın!");
        }
        else if (time >= 12 && time < 18) 
        {
            Console.WriteLine("İyi günler!");
        }
        else 
        {
            Console.WriteLine("İyi akşamlar!");
        }

        //Ternary If ile aynı uygulama
        Console.WriteLine("***** Ternary If ile Aynı Uygulama *****");
        
        string greeting = (time >= 6 && time < 12) ? "Günaydın!" :
                          (time >= 12 && time < 18) ? "İyi günler!" :
                          "İyi akşamlar!";  
        Console.WriteLine(greeting);


    }
}
