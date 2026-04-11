namespace _14_2_koleksiyonlar;

class Program
{
    static void Main(string[] args)
    {
        //List<T> Koleksiyonu
        //List<T>, dinamik olarak boyutlandırılabilen ve sıralı bir koleksiyondur. T, koleksiyonun saklayacağı veri türünü belirtir.
        // T --> int, string, custom class vs. olabilir.
        // List<T> kullanarak bir koleksiyon oluşturabilir ve bu koleksiyona eleman ekleyebilir, silebilir ve erişebilirsiniz. List<T> ayrıca birçok kullanışlı yöntem ve özellik sunar, örneğin Add(), Remove(), Count, Contains() gibi.
        // T -> object türünde ise, boxing ve unboxing işlemleri gerçekleşebilir. Boxing, değer türlerinin (örneğin int, double) referans türlerine (object) dönüştürülmesi işlemidir. Unboxing ise, referans türünden değer türüne dönüşüm işlemidir. Bu işlemler performans açısından maliyetli olabilir, bu yüzden mümkün olduğunda generik koleksiyonlar kullanmak daha iyidir.
        
        //Örnek: Bir List<int> oluşturma ve kullanma   

        List<int> sayiListesi = new List<int>();

        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Yeşil");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Siyah");

        //Count özelliği, koleksiyondaki eleman sayısını döndürür.
        Console.WriteLine("Count ile koleksiyonlardaki eleman sayısı:");
        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);

        //foreach döngüsü ile koleksiyon elemanlarına erişim
        Console.WriteLine("foreach döngüsü ile koleksiyonlardaki elemanlara erişim:");    
        foreach (var sayi in sayiListesi)
        {
            Console.WriteLine(sayi);
        }
        
        foreach (var renk in renkListesi)
        {
            Console.WriteLine(renk);
        }

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

        //Listeden eleman silme
        Console.WriteLine("Listeden eleman silme:");
        sayiListesi.Remove(4); // Değer ile silme
        renkListesi.Remove("Yeşil"); // Değer ile silme
        
        Console.WriteLine("Sayı Listesi elamanları:");
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        Console.WriteLine("Renk Listesi elamanları:");
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        sayiListesi.RemoveAt(0); // İndeks ile silme
        Console.WriteLine("Sayı Listesi elamanları:");
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.RemoveAt(1); // İndeks ile silme        
        Console.WriteLine("Renk Listesi elamanları:");
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Listeden eleman arama
        Console.WriteLine("Listeden eleman arama:");

        if (sayiListesi.Contains(10))
        {
            Console.WriteLine("10 sayısı listede bulundu.");
        }
        else
        {
            Console.WriteLine("10 sayısı listede bulunamadı.");
        }

        //Eleman ile index'e erişmek
        Console.WriteLine("Eleman ile index'e erişmek:");

        Console.WriteLine(renkListesi.IndexOf("Sarı")); // Elemanın indeksini döndürür, eğer eleman bulunamazsa -1 döner.

        //BinarySearch ile sıralı listelerde arama yapma
        Console.WriteLine("BinarySearch ile sıralı listelerde arama yapmak:");
        sayiListesi.Sort(); // BinarySearch kullanmadan önce listeyi sıralamak gerekir.
        int index = sayiListesi.BinarySearch(92);
        Console.WriteLine("92 sayısı, sıralı listede {0}. indekste bulunmuştur.", index);

        //Diziyi List'e çevirme
        Console.WriteLine("Diziyi List'e çevirme:");
        string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
        List<string> hayvanListesi = new List<string>(hayvanlar);
        Console.WriteLine("Hayvan Listesi elamanları:");
        hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan)); 

        //Listeyi nasıl temizleriz?
        Console.WriteLine("Listeyi temizleme:");
        hayvanListesi.Clear();
        Console.WriteLine("Hayvan Listesi eleman sayısı: {0}", hayvanListesi.Count);

        //Listeden elemanları nasıl diziye çeviririz?
        Console.WriteLine("Listeden elemanları diziye çevirme:");
        string[] renkDizisi = renkListesi.ToArray();
        Console.WriteLine("Renk Dizisi elemanları:");

        foreach (var renk in renkDizisi)
        {
            Console.WriteLine(renk);
        }       

        //List içerisinde nesne tutmak
        Console.WriteLine("List içerisinde nesne tutmak:");

        List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim = "Ayşe";
        kullanici1.Soyisim = "Yılmaz";  
        kullanici1.Yas = 30;

        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim = "Özcan";
        kullanici2.Soyisim = "Çalışkan";  
        kullanici2.Yas = 40;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        foreach (var kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanıcı Adı: {0} {1}, Yaşı: {2}", kullanici.Isim, kullanici.Soyisim, kullanici.Yas);
        }   


        List<Kullanicilar> yeniListe = new List<Kullanicilar>();
        yeniListe.Add(new Kullanicilar() { Isim = "Deniz", Soyisim = "Arda", Yas = 25 });

        foreach (var kullanici in yeniListe)
        {
            Console.WriteLine("Kullanıcı Adı: {0} {1}, Yaşı: {2}", kullanici.Isim, kullanici.Soyisim, kullanici.Yas);
        }

        yeniListe.Clear();

    }
}

public class Kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}
