namespace _04_degisken;

class Program
{
    static void Main(string[] args)
    {
        //int: -2,147,483,648 ile 2,147,483,647 arasında değer alabilir
        //4 byte = 32 bit
        int deger;
        deger = 5;

        Console.WriteLine(deger);
        Console.ReadLine();

        string isim = "Ahmet";
        Console.WriteLine(isim);
        Console.ReadLine();

        //byte: 0 ile 255 arasında değer alabilir
        //1 byte = 8 bit
        byte sayi = 255;
        Console.WriteLine(sayi);

        
        //-128 ile 127 arasında değer alabilir
        //Hata: 256 değeri byte veri tipinin alabileceği aralığın dışında
        //1 byte = 8 bit
        sbyte sayi2 = 0; 

        //-32,768 ile 32,767 arasında değer alabilir
        //2 byte = 16 bit
        short sayi3 = 32767;

        //0 ile 65,535 arasında değer alabilir
        //2 byte = 16 bit   
        ushort sayi4 = 65535;

        //-32,768 ile 32,767 arasında değer alabilir
        //2 byte = 16 bit
        Int16 sayi5 = 32767; //short ile aynı

        //-2,147,483,648 ile 2,147,483,647 arasında değer alabilir
        //4 byte = 32 bit   
        Int32 sayi6 = 2147483647; //int ile aynı

        //-9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasında değer alabilir
        //8 byte = 64 bit
        Int64 sayi7 = 9223372036854775807; //long ile aynı
        
        //-9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasında değer alabilir
        //8 byte = 64 bit
        long sayi8 = 9223372036854775807;

        //0 ile 18,446,744,073,709,551,615 arasında değer alabilir
        //8 byte = 64 bit
        ulong sayi10 = 18446744073709551615;

        //0 ile 4,294,967,295 arasında değer alabilir
        //4 byte = 32 bit
        uint sayi9 = 4294967295; 

        //float: yaklaşık ±1.5 x 10−45 ile ±3.4 x 10^38 arasında değer alabilir
        //7 basamağa kadar hassasiyet
        //4 byte = 32 bit
        float ondalikliSayi = 5.75f; //4 byte = 32 bit

        //double: yaklaşık ±5.0 x 10−324 ile ±1.7 x 10^308 arasında değer alabilir
        //15-16 basamağa kadar hassasiyet
        //8 byte = 64 bit
        double ondalikliSayi2 = 19.99d; //8 byte = 64 bit
        Console.WriteLine(ondalikliSayi2);

        //decimal: yaklaşık ±1.0 x 10−28 ile ±7.9 x 10^28 arasında değer alabilir
        //28-29 basamağa kadar hassasiyet           
        //16 byte = 128 bit
        decimal ondalikliSayi3 = 19.99m; //16 byte = 128 bit
        Console.WriteLine(ondalikliSayi3);


        //string: metin veri tipidir
        //Sınırsız uzunlukta karakter dizisi tutabilir
        //Referans tip
        string sehir = "Ankara";

        //char: tek bir karakter tutar
        //2 byte = 16 bit
        char karakter = 'A';

        //bool: true veya false değerini alabilir
        //1 byte = 8 bit
        //Mantıksal veri tipi
        //true(Doğru) veya false(Yanlış) değerini alabilir
        bool dogruMu = true; //false

        //DateTime: tarih ve saat bilgilerini tutar
        //8 byte = 64 bit
        //Şu anki tarih ve saat bilgisi
        DateTime tarih = DateTime.Now;
        Console.WriteLine(tarih);
        Console.ReadLine();

        //object: Tüm veri tiplerinin temelidir
        //Her türden veri tipini tutabilir  
        object deger1 = "Ahmet";
        object deger2 = 4.5f;
        object deger3 = 25; 
        
        //string ifadeler
        string str1 = "20";
        string str2 = string.Empty;

        string ad = "Ahmet";
        Console.WriteLine(ad);
        string soyad = "Yılmaz";
        Console.WriteLine(soyad);
        string tamIsim = ad + " " + soyad;
        Console.WriteLine(tamIsim); // çıktısı: Ahmet Yılmaz
        Console.ReadLine();

        //interger tanımlama şekilleri
        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;
        Console.WriteLine(integer3);    
        Console.ReadLine();

        //boolean ifadeler
        bool bool1 = 10>2;
        Console.WriteLine(bool1);    
        Console.ReadLine();

        //string ifadeyi integer'a dönüştürme
        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger);   //çıktısı: 2020
        Console.ReadLine();

        //integer ifadeyi string'e dönüştürme
        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); //çıktısı: 40
        Console.ReadLine();

        int int22 = int20 + int.Parse(str20);
        Console.WriteLine(int22); //çıktısı: 40
        Console.ReadLine();

        //datetime
        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);    
        Console.ReadLine();
        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
        Console.ReadLine();
        
    }   
}
