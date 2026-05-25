namespace _16_2_sinif;

class Program
{
    static void Main(string[] args)
    {
        //Constructor (Yapıcı Metot) Kavramı
        //Constructor, bir sınıfın nesneleri oluşturulurken otomatik olarak çağrılan özel bir metottur. Constructor, nesnelerin başlangıç durumunu belirlemek için kullanılır. Constructor, sınıfın adıyla aynı adı taşımalı ve geri dönüş tipi olmamalıdır. Constructor, nesnelerin oluşturulması sırasında gerekli olan işlemleri gerçekleştirmek için kullanılır. Constructor, nesnelerin oluşturulması sırasında gerekli olan işlemleri gerçekleştirmek için kullanılır. Constructor, nesnelerin oluşturulması sırasında gerekli olan işlemleri gerçekleştirmek için kullanılır.
        //Söz dizim
        //class SinifAdi
        //{
        //    [Erişim Belirleyicisi] SinifAdi([Parametreler])
        //    {
        //        //Constructor'un içeriği
        //    }
        //}

        Calisan calisan1 = new Calisan(23425634, "Ahmet", "Yılmaz", "İnsan Kaynakları");
        Calisan calisan2 = new Calisan(23425635, "Deniz", "Arda", "Satınalma");

        Console.WriteLine("Çalışan 1 Bilgileri:");
        calisan1.CalisanBilgileri();
        Console.WriteLine("Çalışan 2 Bilgileri:");
        calisan2.CalisanBilgileri();
        



    }
}

class Calisan
{
    public int Id;
    public string Ad;
    public string Soyad;
    public string Departman;

    public Calisan(int id, string ad, string soyad, string departman)
    {
        this.Id = id;
        this.Ad = ad;
        this.Soyad = soyad;
        this.Departman = departman;
    }

    public Calisan()
    {
    
    }



    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Numarası: {0}", Id);
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
    }
}


