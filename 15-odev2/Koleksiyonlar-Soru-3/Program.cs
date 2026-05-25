namespace _15_3_odev2;

class Program
{
    static void Main(string[] args)
    {
        // Soru - 3: 
        // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

        Console.WriteLine("Lütfen bir cümle giriniz:");
        string cumle = Console.ReadLine();

        cumle = cumle.ToLower(); // Büyük harfleri küçük harfe çeviriyoruz

        char[] sesliHarfler = new char[] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'ä', 'ë', 'ï'};

        List<char> bulunanSesliHarfler = new List<char>();

        foreach (char harf in cumle)
        {
            if(sesliHarfler.Contains(harf))
            {
                bulunanSesliHarfler.Add(harf);
            }
        }
        bulunanSesliHarfler.Sort(); // Sesli harfleri sıraladık

        Console.WriteLine("Cümledeki sesli harfler:");

        if (bulunanSesliHarfler.Count > 0)
        {
            foreach (char sesliHarf in bulunanSesliHarfler)
        {
            Console.Write(sesliHarf + " ");
        }
        }
        else
        {
            Console.WriteLine("Cümlede sesli harf bulunmamaktadır.");
        }


        

        
        
        


    }
}
