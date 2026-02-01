namespace _10_1_tanimlama;

class Program
{
    static void Main(string[] args)
    {
       //Tanımlama, Erişim ve Döngülerle Dizi Kullanımı

       //Dizi Tanımlama
         int[] sayilar = new int[5];         

            //Dizi Elemanlarına Değer Atama
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;
            sayilar[4] = 50;


            //Dizi Elemanlarına Erişim ve Yazdırma
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Dizi Elemanı " + i + ": " + sayilar[i]);
            }   

            //Dizi Tanımlama ve Başlatma
            string[] meyveler = new string[] { "Elma", "Muz", "Çilek", "Portakal" };
            //Dizi Elemanlarına Erişim ve Yazdırma
            for (int i = 0; i < meyveler.Length; i++)
            {
                Console.WriteLine("Meyve " + i + ": " + meyveler[i]);
            }


//diziler index numarası 0 dan başlar.
//örneğin 5 elemanlı bir dizide son elemanın index numarası 4 tür.

//Dizilerde Length özelliği, dizinin toplam eleman sayısını verir.
//örneğin, sayilar dizisi için sayilar.Length ifadesi 5 döner.
//Dizilere erişim için döngüler sıklıkla kullanılır, özellikle for döngüsü.
//Yukarıdaki örneklerde dizilerin elemanlarına erişmek ve yazdırmak için for döngüsü kullanılmıştır.
//Dizilerde veri türü sabittir, yani bir dizi sadece tek bir veri türünden elemanlar içerebilir.
//Diziler bellekte ardışık olarak saklanır, bu da hızlı erişim sağlar.
//Diziler referans tiplerdir, bu nedenle bir dizi değişkeni başka bir dizi değişkenine atandığında, her iki değişken de aynı diziye işaret eder.
//Dizilerde sınır kontrolü yapılır; geçersiz bir index numarasına erişmeye çalışmak bir hata oluşturur.
//Diziler, çok boyutlu (örneğin, 2D diziler) olarak da tanımlanabilir.
//Diziler, koleksiyonlar ve listeler gibi daha gelişmiş veri yapılarının temelini oluşturur.
//Diziler, C# programlamada veri yönetimi için temel ve önemli bir yapıdır.
//Diziler, aynı türden birden çok değeri tek bir değişkende saklamanızı sağlar.
//Diziler, sabit boyutludur; bir kez tanımlandıktan sonra boyutları değiştirilemez.
//Diziler, indeksleme yoluyla elemanlara hızlı erişim sağlar.
//Diziler, bellekte ardışık olarak saklanır, bu da performansı artırır.
//Diziler, döngülerle birlikte kullanılarak veri işleme işlemlerini kolaylaştırır.
//Diziler, referans tiplerdir; bu nedenle, bir dizi değişkeni başka bir dizi değişkenine atandığında, her iki değişken de aynı diziye işaret eder.
//Diziler, koleksiyonlar ve listeler gibi daha gelişmiş veri yapılarının temelini oluşturur.

// Örnek:

        string[] renkler = new string[5];

        string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Balık", "Kaplumbağa" };

        int[] dizi1;
        dizi1 = new int[5];

//Dizilere değer atama ve erişim
        renkler[0] = "Kırmızı";
        renkler[1] = "Mavi";
        renkler[2] = "Yeşil";
        renkler[3] = "Sarı";
        renkler[4] = "Mor";

        Console.WriteLine("Renkler Dizisi:");
        for (int i = 0; i < renkler.Length; i++)
        {
            Console.WriteLine("Renk: " + renkler[i]);
        }

        Console.WriteLine("Hayvanlar Dizisi:");
        for (int i = 0; i < hayvanlar.Length; i++)
        {
            Console.WriteLine("Hayvan: " + hayvanlar[i]);
        }

        dizi1[0] = 1;
        dizi1[1] = 2;   
        dizi1[2] = 3;
        dizi1[3] = 4;
        dizi1[4] = 5;
        
        Console.WriteLine("Dizi1 Elemanları:");
        for (int i = 0; i < dizi1.Length; i++)
        {
            Console.WriteLine("Dizi1 Elemanı " + i + ": " + dizi1[i]);
        }


        //Konsoldan gelen sayıları bir diziye atayıp ortalamasını hesaplama
        Console.WriteLine("Kaç adet sayı gireceksiniz?");
        int diziUzunlugu = 0;
        try
        {
            diziUzunlugu = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Lütfen geçerli bir sayı girin.");
            return;
        }
       


        int[] kullaniciSayilari = new int[diziUzunlugu];
        try
        {
            for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.WriteLine(i + 1 + ". sayıyı girin:");
            kullaniciSayilari[i] = int.Parse(Console.ReadLine());
        }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lütfen geçerli bir sayı girin.");
            Console.WriteLine("Hata mesajı: " + ex.Message);
            return;
        }

        //Ortalama hesaplama
        int toplam = 0;
        foreach(var sayi in kullaniciSayilari)
        {
            toplam += sayi;
        }
        Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);
    }
}
