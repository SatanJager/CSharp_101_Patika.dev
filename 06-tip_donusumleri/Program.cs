namespace _06_tip_donusumleri;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");

        // Implicit Conversion (Bilinçsiz Dönüşüm)
        // Küçük veri tiplerinin büyük veri tiplerine dönüştürülmesi
        // byte, sbyte, short -> int -> long -> float -> double -> decimal
        // Dönüşüm işlemi otomatik olarak gerçekleşir
        // Örnekler:
        Console.WriteLine("***** Implicit Conversion *****");
        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a + b + c;
        Console.WriteLine("int d: " + d);

        long h = d;
        Console.WriteLine("long h: " + h);

        float i = h;
        Console.WriteLine("float i: " + i);

        // string, char, object türleri de implicit conversion'a tabidir
        // Örnekler:
        string e = "Emre";
        char f = 'k';
        object g = e + f + d;
        Console.WriteLine("object g: " + g);

        // Explicit Conversion (Bilinçli Dönüşüm)
        // Büyük veri tiplerinin küçük veri tiplerine dönüştürülmesi
        // double, float, long -> int -> short -> sbyte, byte
        // Dönüşüm işlemi parantez içinde belirtilir
        // Dönüşüm sırasında veri kaybı yaşanabilir
        // Convert sınıfı da explicit conversion için kullanılabilir
        // Parse metodu da string ifadeleri sayısal ifadelere dönüştürmek için kullanılabilir
        // Örnekler:
        Console.WriteLine("***** Explicit Conversion *****");
        int x = 10;
        int y = 20;
        int z = x + y;
        Console.WriteLine("z: " + z);

        double a1 = 10.5;
        int b1 = (int)a1;
        Console.WriteLine("int b1: " + b1);

        float c1 = 10.5f;
        byte d1 = (byte)c1; 
        Console.WriteLine("byte d1: " + d1);

        string e1 = "20";
        int f1 = Convert.ToInt32(e1);
        Console.WriteLine("int f1: " + f1);

        // Convert Sınıfı
        // Farklı veri tipleri arasında dönüşüm yapmak için kullanılır
        // Örnekler:
        Console.WriteLine("***** Convert Sınıfı *****");
        string g1 = "10.5";
        double h1 = Convert.ToDouble(g1);
        Console.WriteLine("double h1: " + h1);

        // Parse Metodu
        // string ifadeleri sayısal ifadelere dönüştürmek için kullanılır
        // Örnekler:
        Console.WriteLine("***** Parse Metodu *****");
        
        string i1 = "100";
        byte j1 = byte.Parse(i1);
        Console.WriteLine("byte j1: " + j1);

        //Parse Metodu ile Diğer Veri Tiplerine Dönüşüm
        string k1 = "200.5";
        float l1 = float.Parse(k1);
        Console.WriteLine("float l1: " + l1);
        
        //Parse Metodu ile Diğer Veri Tiplerine Dönüşüm - int
        string m1 = "300";
        int n1 = int.Parse(m1);
        Console.WriteLine("int n1: " + n1);

        //Parse Metodu ile Diğer Veri Tiplerine Dönüşüm - double
        string o1 = "400.75";
        double p1 = double.Parse(o1);
        Console.WriteLine("double p1: " + p1);

        //Parse Metodu ile Diğer Veri Tiplerine Dönüşüm - decimal
        string q1 = "500.99";
        decimal r1 = decimal.Parse(q1);
        Console.WriteLine("decimal r1: " + r1);

        //Parse Metodu ile Diğer Veri Tiplerine Dönüşüm - long
        string s1 = "6000";
        long t1 = long.Parse(s1);
        Console.WriteLine("long t1: " + t1);
        
        //Parse Metodu ile Diğer Veri Tiplerine Dönüşüm - short
        string u1 = "700";      
        short v1 = short.Parse(u1);
        Console.WriteLine("short v1: " + v1);

        // ToString Metodu
        // Sayısal veri tiplerini string veri tipine dönüştürmek için kullanılır
        // Örnekler:
        Console.WriteLine("***** ToString Metodu *****");
        int k = 10;
        string l = k.ToString();    
        Console.WriteLine("string l: " + l);
        float m = 12.5f;
        // string n = Convert.ToString(m);
        // veya
        // string n = 12.5f.ToString();
        string n = m.ToString();
        Console.WriteLine("string n: " + n);

        // Parse ile Convert Arasındaki Farklar
        // Parse metodu sadece string ifadeleri sayısal ifadelere dönüştürür
        // Convert sınıfı ise farklı veri tipleri arasında dönüşüm yapabilir
        Console.WriteLine("***** Parse ile Convert Arasındaki Farklar *****");
        string o = "256";
        int p = int.Parse(o);
        Console.WriteLine("int p: " + p);       
        string q = "512";
        int r = Convert.ToInt32(q);
        Console.WriteLine("int r: " + r);

        // Parse Metodu Kullanımı
        ParseMetodu();
    
        //ParseMetodu ile Convert Sınıfının Hata Yönetimi
        Console.WriteLine("***** Parse Metodu ile Convert Sınıfının Hata Yönetimi *****");
        string s = "1000a";
        try
        {
            int t = int.Parse(s);
            Console.WriteLine("int t: " + t);
        }
        catch (FormatException)
        {
            Console.WriteLine("Parse Metodu Hatası: Geçersiz format.");
        }   

        //Parse Metodu ile Convert Sınıfının Hata Yönetimi - Convert
        try
        {
            int u = Convert.ToInt32(s);
            Console.WriteLine("int u: " + u);
        }
        catch (FormatException)
        {
            Console.WriteLine("Convert Sınıfı Hatası: Geçersiz format.");
        }

        // Nullable Tip Dönüşümleri
        Console.WriteLine("***** Nullable Tip Dönüşümleri *****");
        int? nullableInt = null;    

        // Nullable tipten normal tipe dönüşüm
        int normalInt = nullableInt ?? 0; // null ise 0 atanır
        Console.WriteLine("normalInt: " + normalInt);

        

        // Çıkış
        Console.WriteLine("İşlemler tamamlandı.");

        string ornek1 = "240";
        byte ornek2 = byte.Parse(ornek1);
        Console.WriteLine("sbyte ornek2: " + ornek2);
        byte ornek3 = Convert.ToByte(ornek1);
        Console.WriteLine("byte ornek3: " + ornek3);
        decimal ornek4 = decimal.Parse(ornek1);
        Console.WriteLine("decimal ornek4: " + ornek4);
        decimal ornek5 = Convert.ToDecimal(ornek1);
        Console.WriteLine("decimal ornek5: " + ornek5); 

        //datetime dönüşümü
        string tarih1 = "2024-06-15";   
        DateTime dt1 = DateTime.Parse(tarih1);
        Console.WriteLine("DateTime dt1: " + dt1);
        DateTime dt2 = Convert.ToDateTime(tarih1);
        Console.WriteLine("DateTime dt2: " + dt2);
        


    }

    public static void ParseMetodu()
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam1;
        double double1;
        rakam1 = int.Parse(metin1);
        double1 = double.Parse(metin2);

        Console.WriteLine("int rakam1: " + rakam1);
        Console.WriteLine("double double1: " + double1);

    }

}
