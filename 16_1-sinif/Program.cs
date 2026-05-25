namespace _16_1_sinif;

class Program
{
    static void Main(string[] args)
    {
        //Sınıf Kavramı
        //Sınıf, nesnelerin özelliklerini ve davranışlarını tanımlayan bir yapıdır. Sınıflar, nesnelerin ortak özelliklerini ve davranışlarını tanımlamak için kullanılır. Sınıflar, nesnelerin oluşturulması için bir şablon sağlar.   
        //Sınıf Tanımlama
        //Sınıf tanımlamak için class anahtar kelimesi kullanılır. Sınıf tanımlarken, sınıfın adını ve içeriğini belirtiriz. Sınıfın içeriği, özellikler (fields) ve davranışlar (methods) olabilir.
        //Sınıf Örneği Oluşturma    
        //Sınıf tanımladıktan sonra, o sınıftan nesneler oluşturabiliriz. Nesne oluşturmak için new anahtar kelimesi kullanılır. Nesne oluştururken, sınıfın adını ve parantezleri kullanırız.
        //Sınıfın Özellikleri ve Davranışları   
        //Sınıfın özellikleri, sınıfın içinde tanımlanan değişkenlerdir. Sınıfın davranışları ise, sınıfın içinde tanımlanan metotlardır. Özellikler, nesnelerin durumunu tutarken, davranışlar nesnelerin hareketlerini tanımlar.
        //Sınıfın Erişim Belirleyicileri
        //Sınıfın erişim belirleyicileri, sınıfın üyelerine (özellikler ve davranışlar) erişimi kontrol eder. Erişim belirleyicileri, public, private, protected ve internal gibi anahtar kelimelerle belirtilir. Public üyeler, her yerden erişilebilirken, private üyeler sadece sınıf içinde erişilebilir. Protected üyeler, sınıfın kendisi ve alt sınıfları tarafından erişilebilirken, internal üyeler aynı assembly içinde erişilebilir.
        //Sınıfın Yapıcı Metotları (Constructor)
        //Sınıfın yapıcı metotları, sınıfın nesneleri oluşturulurken otomatik olarak çağrılan özel metotlardır. Yapıcı metotlar, nesnelerin başlangıç durumunu belirlemek için kullanılır. Yapıcı metotlar, sınıfın adıyla aynı adı taşımalı ve geri dönüş tipi olmamalıdır.


        //Söz dizim
        //class SinifAdi
        //{
        //    [Erişim Belirleyicisi] [Veri Tipi] ÖzellikAdi;
        //    [Erişim Belirleyicisi] [Geri Dönüş Tipi] MetotAdi([Parametreler])
        //    {
        //        //Metotun içeriği
        //    }
        //}

        //Erişim Belirleyicileri
        //Erişim belirleyicileri, sınıf üyelerine erişimi kontrol etmek için kullanılır. Erişim belirleyicileri, public, private, protected ve internal gibi anahtar kelimelerle belirtilir. 
        //Erişim belirleyicileri, sınıf üyelerinin güvenliğini sağlamak ve sınıfın iç yapısını korumak için önemlidir. Erişim belirleyicileri, sınıf üyelerinin nasıl kullanılacağını ve erişileceğini kontrol etmek için kullanılır. Erişim belirleyicileri, sınıf üyelerinin görünürlüğünü ve erişilebilirliğini belirler. Erişim belirleyicileri, sınıf üyelerinin güvenliğini sağlamak ve sınıfın iç yapısını korumak için önemlidir.

        // Public üyeler, her yerden erişilebilirken, 
        // private üyeler sadece sınıf içinde erişilebilir. 
        // Protected üyeler, sınıfın kendisi ve alt sınıfları tarafından erişilebilirken, 
        // internal üyeler aynı assembly içinde erişilebilir. 

        Calisan calisan1 = new Calisan();
        calisan1.Id = 23425634;
        calisan1.Ad = "Ahmet";
        calisan1.Soyad = "Yılmaz";  
        calisan1.Departman = "İnsan Kaynakları";

        Console.WriteLine("Çalışan 1 Bilgileri:");
        calisan1.CalisanBilgileri();

        Calisan calisan2 = new Calisan();
        calisan2.Id = 23425635;
        calisan2.Ad = "Deniz";
        calisan2.Soyad = "Arda";  
        calisan2.Departman = "Satınalma";

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

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Numarası: {0}", Id);
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
    }
}
