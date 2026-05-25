namespace _16_3_sinif;

class Program
{
    static void Main(string[] args)
    {
        //Enkapsülasyon (Encapsulation) Kavramı
        //Enkapsülasyon, bir sınıfın verilerini ve metotlarını bir dışarıdan erişime kapatarak, sadece belirli bir arayüz üzerinden erişim sağlamaktır. Enkapsülasyon, nesnelerin iç durumunu gizleyerek, dışarıdan gelen müdahaleleri engeller ve nesnelerin güvenliğini artırır.
        //Söz dizim
        //class SinifAdi    
        //{
        //    [Erişim Belirleyicisi] VeriTipi OzellikAdi;
        //    [Erişim Belirleyicisi] VeriTipi MetotAdi([Parametreler])
        //    {
        //        //Metot içeriği
        //    }
        //}

        Ogrenci ogrenci1 = new Ogrenci(123, "Ayşe", "Yılmaz", 3);
        ogrenci1.OgrenciBilgileriniGetir();
        ogrenci1.SinifAtlat();
        Console.WriteLine("Sınıf atlatıldı. Sınıf: {0}", ogrenci1.Sinif);
        ogrenci1.SinifDusur();
        Console.WriteLine("Sınıf düşürüldü. Sınıf: {0}", ogrenci1.Sinif);

        Ogrenci ogrenci2 = new Ogrenci(124, "Deniz", "Arda", 1);
        ogrenci2.OgrenciBilgileriniGetir();
        ogrenci2.SinifDusur();
        Console.WriteLine("Sınıf düşürüldü. Sınıf: {0}", ogrenci2.Sinif);

    }
}

class Ogrenci
{
    //private: sadece sınıfın içinde erişilebilir. private değişkenler, sınıfın dışından erişilemez ve değiştirilemez. private değişkenler, sınıfın içindeki metotlar tarafından kullanılabilir ve değiştirebilir. private değişkenler küçük harf yada _ ile başlar.

    private int _id; //Öğrenci numarası
    private string _ad;
    private string _soyad;
    private int _sinif;

    public int Id { get => _id; set => _id = value; }
    public string Ad 
    { 
        get { return _ad;} 
        set { _ad = value; }
    }
    public string Soyad { get => _soyad; set => _soyad = value; }
    public int Sinif 
    { 
        get => _sinif; 
        set
        {
            if(value < 1)
            {
                Console.WriteLine("Sınıf En Az 1 Olabilir!");
                _sinif = 1;
            }
            else
            {
                _sinif = value;      
            }
        } 
    }

    public Ogrenci(){}

    public Ogrenci(int _id, string _ad, string _soyad, int _sinif)
    {
        this.Id = _id;
        this.Ad = _ad;
        this.Soyad = _soyad;
        this.Sinif = _sinif;
    }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("**** Öğrenci Bilgileri ****");
        Console.WriteLine("Öğrenci Numarası  : {0}", this.Id);
        Console.WriteLine("Öğrenci Adı       : {0}", this.Ad);
        Console.WriteLine("Öğrenci Soyadı    : {0}", this.Soyad);
        Console.WriteLine("Öğrenci Sınıfı    : {0}", this.Sinif);
    }
    public void SinifAtlat()
    {
        this.Sinif = this.Sinif + 1;
    }
    public void SinifDusur()
    {
        this.Sinif = this.Sinif - 1;

    }


}
