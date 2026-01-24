namespace _07_2_debug;

class Program
{
    static void Main(string[] args)
    {
        // Debugging, Watch ve Variables Pencereleri
        // Debugging: Kodun adım adım çalıştırılarak hataların bulunması ve düzeltilmesi süreci
        // Watch ve Variables pencereleri, değişkenlerin ve ifadelerin değerlerini izlemek için kullanılır
        Console.WriteLine("***** Debugging, Watch ve Variables *****");

        int x = 10;
        int y = 0;  
        int result = 0;
        try
        {
            result = x / y; // Hata oluşturacak kod
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
            Console.WriteLine("Detaylar: " + ex.Message);
        }

        // Breakpoints Kullanımı
        // Breakpoint: Kodun belirli bir noktasında duraklama noktası
        Console.WriteLine("***** Breakpoints Kullanımı *****"); 
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i değeri: " + i); // Buraya breakpoint ekleyebilirsiniz
        }

        // Örnek:
        Console.WriteLine("***** Debugging Örneği *****");

        try
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());  //Buraya breakpoint ekleyebilirsiniz
            Console.WriteLine("Girdiğiniz sayı: " + sayi);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Hata: Geçersiz format! Lütfen bir sayı giriniz.");
            Console.WriteLine("Detaylar: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("İşlem tamamlandı.");
        }



        // Debugging İpuçları
        // 1. Adım Adım İlerleme: Kodunuzu adım adım çalıştırarak hataları bulun.
        // 2. Değişken İzleme: Watch ve Variables pencerelerini kullanarak değişkenlerin değerlerini izleyin.
        // 3. Breakpoint Kullanımı: Kodun belirli noktalarında duraklama noktaları ekleyin.
        // 4. Hata Mesajlarını Anlama: Hata mesajlarını dikkatlice okuyun ve anlamaya çalışın.
        // 5. Kod İnceleme: Kodunuzu dikkatlice inceleyin ve potansiyel hataları bulun.
        

    }
}
