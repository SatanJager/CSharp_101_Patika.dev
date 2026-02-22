using System.Security.Cryptography.X509Certificates;

namespace _11_1_metotlar;

class Program
{
    static void Main(string[] args)
    {
        // Metot Tanımlama

        //erişim_belirtici geri_donustipi metot_adi(paramereListesi/arguman)
        //{
            //komutlar
            //return
        //}

        //erişim_belirtici: public, private, internal, protected
        //geri_donustipi: void, int, string vs.
        //paramereListesi/arguman: metot çalışırken kullanacağı değişkenler
        //arguamanlar, parametreler metot çağırılırken gönderilen değerlerdir. Metot tanımlanırken parametreler belirtilir, metot çağırılırken ise argümanlar gönderilir.
        //metot çağırma: metotAdi(argumanlar)
        //metot çağırma işlemi, metot tanımlandıktan sonra yapılır. Metot tanımlanmadan önce çağrılırsa hata alınır.
        //metot imzası: metotAdı + parametre sayısı + parametre türü
        

        int a = 2;
        int b = 3;

        Console.WriteLine(a+b); //5

        int sonuc = Topla(a,b);
        Console.WriteLine(sonuc); //5

        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc)); // 5

        int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
        ornek.EkranaYazdir(Convert.ToString(sonuc2));  //7
        ornek.EkranaYazdir(Convert.ToString(a+b));  //7  --> referans değer ile global değişkeni değiştirmiş oluyor
    

    }
    static int Topla(int deger1, int deger2)
    {
        return (deger1 + deger2);
    }
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public int ArttirVeTopla(ref int deger1, ref int deger2)  //ref  --> referans değer ile global değişkeni değiştirmiş oluyor
    {
        deger1 +=1;
        deger2 +=1;
        return (deger1 + deger2);
    }

}

