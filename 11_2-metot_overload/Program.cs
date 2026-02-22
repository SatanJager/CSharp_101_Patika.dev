namespace _11_2_metot_overload;

class Program
{
    static void Main(string[] args)
    {
        // Metot Overloading

        // Metot aşırı yükleme (overloading), aynı isimde ancak farklı parametre listelerine sahip birden fazla metot tanımlama yeteneğidir. Bu, programcıların aynı işlemi gerçekleştiren ancak farklı türlerde veya sayıda parametre alan metotlar oluşturmasına olanak tanır. Derleyici, çağrılan metotun hangi versiyonunun kullanılacağını belirlemek için parametrelerin türüne ve sayısına bakar.
        // Örneğin, bir "EkranaYazdir" metodu, hem string hem de int türünde parametre alacak şekilde aşırı yüklenebilir. Böylece, aynı metot adıyla farklı türlerde verileri ekrana yazdırmak mümkün olur.

        //out parametreler
        //out parametreler, bir metot tarafından geri döndürülen bir değeri temsil eder. Bir metot, out parametreleri kullanarak birden fazla değer döndürebilir. Out parametreler, metot çağrılırken argüman olarak belirtilir ve metot içinde atanır. Metot çağrıldıktan sonra, out parametrenin değeri çağıran tarafa geri döner.
        //out parametreler, özellikle bir metot tarafından hesaplanan bir değeri geri döndürmek istediğinizde kullanışlıdır. Örneğin, bir metot bir işlemi gerçekleştirirken aynı zamanda bir sonucu da hesaplayabilir ve bu sonucu out parametre olarak döndürebilir.
        

        string sayi = "999";

        bool sonuc = int.TryParse(sayi, out int outSayi);

        if(sonuc)
        {
            Console.WriteLine("Başarılı");
            Console.WriteLine(outSayi);
        }
        else 
        {
            Console.WriteLine("Başararısız");
        }

        Metotlar instance = new Metotlar();

        instance.Topla(4, 5, out int toplamSonuc);
        Console.WriteLine(toplamSonuc);


        // Metot Aşırı Yükleme - Overloading

        int ifade = 998;

        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);

        //Metot İmzası
        // metotAdı + parametre sayisi + parametre

        instance.EkranaYazdir("Taylan","Mühür");

    }
}

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }


}
