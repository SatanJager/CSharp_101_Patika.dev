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
        //TKey'ler iki kere kullanılmaz, yani aynı anahtar birden fazla kez eklenemez. Eğer aynı anahtar tekrar eklenmeye çalışılırsa, bir hata oluşur. Bu nedenle, Dictionary koleksiyonunda her anahtar benzersiz olmalıdır. Compile time'da hata verir, yani derleme aşamasında bu hatayı tespit eder ve programın çalışmasını engeller. Bu, Dictionary'nin anahtarların benzersiz olmasını sağlamak için tasarlanmış bir özelliktir.

        // Dictionary kullanarak bir örnek:
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("book", "kitap");

        // Dictionary'den bir değere erişmek için anahtarı kullanabilirsiniz:
        string value = dictionary["book"];

        Dictionary<int , string> kullanicilar = new Dictionary<int, string>();
        


    }
}
