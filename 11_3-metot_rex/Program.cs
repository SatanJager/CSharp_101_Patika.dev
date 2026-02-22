using System.Reflection;

namespace _11_3_metot_rex;

class Program
{
    static void Main(string[] args)
    {
        // Rekürsif Metotlar ve Extension Metotlar

        // Rekürsif Metotlar - Özyinelemeli Metotlar
        // Rekürsif metotlar, bir metotun kendisini çağırmasıyla oluşan bir yapıdır. Bu tür metotlar, genellikle bir problemi daha küçük parçalara bölerek çözmek için kullanılır. Rekürsif metotların doğru çalışabilmesi için bir durdurma koşulu (base case) içermesi gerekir, aksi takdirde sonsuz döngüye girebilirler.
        // Örnek olarak, bir sayının faktöriyelini hesaplayan rekürsif bir metot yazalım:
        
        //For döngüsüyle
        // 3^4 == 3*3*3*3

        int result = 1;
        for (int i =1; i < 5; i++)
        result = result * 3;
        Console.WriteLine(result);

        // Rekürsif metotla
        Islemler instance = new();
        Console.WriteLine(instance.Expo(3,4));

        //Extension Metotlar (Genişletilmiş Metotlar)
        // Extension metotlar, mevcut bir sınıfa yeni metotlar eklemek için kullanılan bir özelliktir. Bu metotlar, sınıfın orijinal tanımını değiştirmeden, o sınıfa ait nesneler tarafından çağrılabilirler. Extension metotlar, genellikle statik sınıflar içinde tanımlanır ve "this" anahtar kelimesi kullanılarak hangi sınıfa ait oldukları belirtilir.
        // Örnek olarak, string sınıfına bir extension metot ekleyelim:

        string ifade = "Taylan Alp Mühür";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);

        if(sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }

        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());


        // int örnek

        int[] diziOrnek = {9,3,6,2,1,5,0};

        diziOrnek.SortArray();
        Console.WriteLine();

        Console.WriteLine("Sıralanmış Dizi:");
        diziOrnek.WriteLineArray();

        Console.WriteLine("Sayi=5 Çift Mi?");
        int sayi = 5;
        Console.WriteLine(sayi.IstEvenNumber());

        Console.WriteLine("İlk Karakteri Nedir?: Handy");
        string karakter = "Handy";
        Console.WriteLine(karakter.GetFirstChar());

    }
}

public class Islemler
{
    public int Expo(int number, int power)
    {
        if(power<2)
            return number;
        return Expo(number, power-1) * number;
    }
    //Expo(3,4)
    //Expo(3,3) * 3;
    //Expo(3,2) * 3 * 3;
    //Expo(3,1) * 3 * 3 * 3;
    // 3 * 3 * 3 * 3 = 3^4 = 81


}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);

    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void WriteLineArray(this int[] param)
    {
        foreach(int item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IstEvenNumber(this int param)
    {
        return param%2 == 0;
    }

    public static string GetFirstChar(this string param)
    {
        return param.Substring(0,1);

    }

}