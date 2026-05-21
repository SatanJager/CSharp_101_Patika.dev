namespace _14_4_koleksiyonlar;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary
        // system.collection.generic de bulunur
        // Key-Value (Anahtar-Değer) yapısına sahip bir koleksiyon türüdür.
        // Her anahtar benzersizdir ve her anahtar bir değere karşılık gelir.
        // Dictionary<TKey, TValue> sınıfı kullanılarak oluşturulur.
        // Anahtarlar ve değerler herhangi bir türde olabilir, ancak genellikle string türü kullanılır.
        // Dictionary, hızlı veri erişimi sağlar ve anahtarlar üzerinden değerleri kolayca bulmanızı sağlar.

        // TKey ve TValue tür parametreleri, anahtar ve değer türlerini belirtir. Örneğin, Dictionary<string, int> bir sözlük oluşturur ve anahtarların string türünde, değerlerin ise int türünde olduğunu belirtir. TKey türü, anahtarların benzersiz olmasını sağlar ve TValue türü, anahtarların hangi türde değerler içerdiğini belirtir.
        //TKey'ler iki kere kullanılmaz, yani aynı anahtar birden fazla kez eklenemez. Eğer aynı anahtar tekrar eklenmeye çalışılırsa, bir hata oluşur. Bu nedenle, Dictionary koleksiyonunda her anahtar benzersiz olmalıdır. 

        // Dictionary kullanarak bir örnek:
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("book", "kitap");

        // Dictionary'den bir değere erişmek için anahtarı kullanabilirsiniz:
        string value = dictionary["book"];

        Console.WriteLine("**** Dictionary oluşturma ve eleman ekleme *****");
        // Dictionary oluşturma ve eleman ekleme
        Dictionary<int , string> kullanicilar = new Dictionary<int, string>();

        kullanicilar.Add(10, "Ayşe Yılmaz");
        kullanicilar.Add(12, "Ahmet Yılmaz");
        kullanicilar.Add(18, "Deniz Arda");
        kullanicilar.Add(20, "Özcan Coşar");

        Console.WriteLine("**** Elemanlarına erişim*****");
        // Elemanlarına erişim
        Console.WriteLine("**** Elemanlarına erişim : 12. index *****");
        Console.WriteLine(kullanicilar[12]);

        Console.WriteLine("**** Elemanlarına erişim : foreach ile hepsi *****");
        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("**** Dictionary Count() *****");
        // Dictionary Count() - Eleman sayısını verir
        Console.WriteLine("Toplam eleman sayısı: {0}", kullanicilar.Count);

        //ContainsKey() - Belirtilen anahtarın sözlükte olup olmadığını kontrol eder
        Console.WriteLine("**** Dictionary ContainsKey() *****");

        if (kullanicilar.ContainsKey(12))
        {
            Console.WriteLine("12 anahtarı sözlükte mevcut.");
        }
        else
        {
            Console.WriteLine("12 anahtarı sözlükte mevcut değil.");
        }

        // ContainsValue() - Belirtilen değerin sözlükte olup olmadığını kontrol eder
        Console.WriteLine("**** Dictionary ContainsValue() *****"); 

        if (kullanicilar.ContainsValue("Deniz Arda"))
        {
            Console.WriteLine("Deniz Arda değeri sözlükte mevcut.");
        }
        else
        {
            Console.WriteLine("Deniz Arda değeri sözlükte mevcut değil.");
        }

        Console.WriteLine("**** Unique olmayan elemanlar *****");
        // Runtime error: Aynı anahtar tekrar eklenemez

        //kullanicilar.Add(12, "Deniz Arda"); // Hata: Aynı anahtar tekrar eklenemez

        Console.WriteLine("**** Eleman silme *****");
        // Remove() - Belirtilen anahtara sahip elemanı siler
        kullanicilar.Remove(18);

        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item);
        }

        // Keys - Sözlükteki tüm anahtarları döndürür
        Console.WriteLine("**** Keys *****");

        foreach (var key in kullanicilar.Keys)
        {
            Console.WriteLine(key);
        }

        // Values - Sözlükteki tüm değerleri döndürür
        Console.WriteLine("**** Values *****");
        foreach (var value2 in kullanicilar.Values)
        {
            Console.WriteLine(value2);
        }
        

    }
}
