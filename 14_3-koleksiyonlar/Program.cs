using System.Collections;

namespace _14_3_koleksiyonlar;

class Program
{
    static void Main(string[] args)
    {
        // ArrayList Koleksiyonu
        // ArrayList, System.Collections namespace'inde bulunan bir koleksiyon türüdür. ArrayList, dinamik olarak boyutlandırılabilen ve sıralı bir koleksiyondur. Ancak, ArrayList, generik olmayan bir koleksiyon türüdür, bu nedenle herhangi bir türdeki nesneleri saklayabilir. Bu durum, boxing ve unboxing işlemlerine neden olabilir ve performans açısından maliyetli olabilir.
        // ArrayList kullanarak bir koleksiyon oluşturabilir ve bu koleksiyona eleman ekleyebilir, silebilir ve erişebilirsiniz. ArrayList ayrıca birçok kullanışlı yöntem ve özellik sunar, örneğin Add(), Remove(), Count, Contains() gibi.
        //Örnek: Bir ArrayList oluşturma ve kullanma

        ArrayList sayiListesi = new ArrayList();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);       

        //içerisindeki elemanlara erişim / index yönetimi
        
        Console.WriteLine(sayiListesi[0]); // 23
        Console.WriteLine(sayiListesi[3]); // 5
        Console.WriteLine("sayiListesi Elemanları:");
        foreach (var sayi in sayiListesi)
        {
            Console.WriteLine(sayi);
        }


        ArrayList degisikListe = new ArrayList();
        degisikListe.Add("Ayşe"); 
        degisikListe.Add(2);
        degisikListe.Add(true);
        degisikListe.Add('A');

        //içerisindeki elemanlara erişim
        Console.WriteLine("degisikListe Elemanları:");
        foreach (var sayi in degisikListe)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("***** AddRange *****");
        //AddRange() metodu ile birden fazla eleman ekleme
        ArrayList renklerListesi = new ArrayList();

        string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
        renklerListesi.AddRange(renkler); 

        List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};

        renklerListesi.AddRange(sayilar);

        Console.WriteLine("renklerListesi Elemanları:");
        foreach (var item in renklerListesi)
        {
            Console.WriteLine(item);
        }

        // Sort() metodu ile sıralama yapma        
        Console.WriteLine("***** Sort *****");

        // renklerListesi.Sort();  // --> compile time'da çalışır patmalamaz ama runtime'da patlar. Sıralamak için hep içinde aynı tip veri olmalı.

        ArrayList siraList = new ArrayList();

        siraList.Add(2);
        siraList.Add(1);
        siraList.Add(13);
        siraList.Add(133);
        siraList.Add(45);
        siraList.Add(23);

        Console.WriteLine("siraList sıralanmamış hali");
        foreach (var item in siraList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("siraList sıralanmış hali");
        siraList.Sort();

        foreach (var item in siraList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("***** BinarySearch() *****");
        //Binary Search --> sıralı liste ve Array Listlerde çalışır. --> kaçıncı eleman (index) olduğunu getirir.
        
        Console.WriteLine("133'ün index numarası:");
        Console.WriteLine(siraList.BinarySearch(133));  // 5

        // Reverse() Metodu      --> sıralanmış listeyi sondan başa aynalar
        Console.WriteLine("***** Reverse() *****");

        siraList.Reverse();
        foreach (var item in siraList)
        {
            Console.WriteLine(item);
        }

        //Clear() listeyi temizler
        Console.WriteLine("***** Clear() *****");

        siraList.Clear();
        Console.WriteLine("siraList elaman sayısı Clear() metodundan sonra: {0}", siraList.Count);
        foreach (var item in siraList)
        {
            Console.WriteLine(item);
        }




    }
}
