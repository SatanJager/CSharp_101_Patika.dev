namespace _11_2_metot_overload;

class Program
{
    static void Main(string[] args)
    {
        // Metot Overloading

        //out parametreler

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
