namespace _07_1_try_catch;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //Hata Yönetimi ve Kod İzleme
        //Exception Handling
        // Hata: Programın çalışması sırasında oluşan beklenmedik durumlar
        // Hatalar, programın çökmesine veya beklenmedik davranışlara neden olabilir
        // Hata yönetimi, bu hataların kontrol altına alınması ve programın düzgün çalışmaya devam etmesini sağlar


        // Try-Catch-Finally Blokları
        // Hata yönetimi için kullanılır
        // Try bloğu içinde hata oluşabilecek kodlar yazılır
        // Catch bloğu, try bloğunda hata oluştuğunda çalışır ve hatayı yakalar
        // Finally bloğu ise hata oluşsa da oluşmasa da her durumda çalışır
        // Örnek:
        Console.WriteLine("***** Try-Catch-Finally *****");
        try
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayı: " + sayi);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Hata: Geçersiz format! Lütfen bir sayı giriniz.");
            Console.WriteLine("Detaylar: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Hata: Sayı çok büyük veya çok küçük!");
            Console.WriteLine("Detaylar: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Beklenmeyen bir hata oluştu.");
            Console.WriteLine("Detaylar: " + ex.Message);
        }
        finally // Opsiyonel
        {
            Console.WriteLine("İşlem tamamlandı.");
        }

        // Belirli Hata Türlerini Yakalama
        Console.WriteLine("***** Belirli Hata Türlerini Yakalama *****");

        try
        {
            int a = int.Parse(null);
        }
        catch (ArgumentNullException ex)
        {
            // Belirli bir hata türünü yakalama ve işleme
            Console.WriteLine("Boş değer girdiniz: " + ex.Message);
            Consıole.WriteLine(ex);
        }
        finally
        {
            // Her durumda çalışacak kodlar
            Console.WriteLine("İşlem tamamlandı.");
        }

        
        //Hata Bilgilerini Kullanma
        Console.WriteLine("***** Hata Bilgilerini Kullanma *****"); 
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // Hata: Dizi sınırları dışında erişim
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Hata: Dizi sınırları dışında erişim!");
            Console.WriteLine("Hata Mesajı: " + ex.Message);
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
        }
        finally
        {
            Console.WriteLine("İşlem tamamlandı.");
        }


        // Hata türlerini anlamak ve yönetmek, yazılım geliştirme sürecinin önemli bir parçasıdır.
        // Doğru hata yönetimi, uygulamanızın güvenilirliğini ve kullanıcı deneyimini artırır.
        // Hata yönetimi stratejilerini uygulayarak, beklenmedik durumlarla başa çıkabilir ve uygulamanızın kesintisiz çalışmasını sağlayabilirsiniz.
        // Hata yönetimi, yazılım geliştirme sürecinde dikkate alınması gereken kritik bir konudur.
        // Hataları doğru bir şekilde yakalamak, işlemek ve gerektiğinde kullanıcıya anlamlı geri bildirimler sağlamak, uygulamanızın kalitesini artırır.
        // Hata yönetimi stratejilerini uygulayarak, beklenmedik durumlarla başa çıkabilir ve uygulamanızın kesintisiz çalışmasını sağlayabilirsiniz.
        // Complex uygulamalarda, hata yönetimi daha da önem kazanır. Hataların doğru bir şekilde ele alınması, uygulamanızın güvenilirliğini ve kullanıcı memnuniyetini artırır.
        // Hata yönetimi stratejilerini uygulayarak, beklenmedik durumlarla başa çıkabilir ve uygulamanızın kesintisiz çalışmasını sağlayabilirsiniz.
        // Derleyici (Compile-time) ve çalışma zamanı (Run-time) hatalarını anlamak, yazılım geliştirme sürecinde önemli bir adımdır.
        // Derleyici hataları, kod yazılırken ortaya çıkar ve genellikle sözdizimi veya tür uyumsuzlukları gibi sorunlardan kaynaklanır.
        // Çalışma zamanı hataları ise program çalışırken ortaya çıkar ve genellikle beklenmedik durumlar veya hatalı girdilerden kaynaklanır.
        // Derleyici uyarılarını dikkate almak, kodunuzu daha güvenli ve hatasız hale getirebilir.



    }
}
