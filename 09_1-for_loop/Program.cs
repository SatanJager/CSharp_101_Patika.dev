namespace _09_1_for_loop;

class Program
{
    static void Main(string[] args)
    {
        //For Loop ve Break Continue Ifadeleri
        // 1'den 10'a kadar olan sayıları yazdıran bir for döngüsü oluşturalım  
        // Ancak 4 sayısına gelindiğinde döngüyü sonlandırmak yerine o sayıyı atlayalım
        // ve devam edelim.
        // break ve continue ifadelerinin farkını gösterelim
        // break ifadesi döngüyü tamamen sonlandırır
        // continue ifadesi ise o anki döngüyü atlar ve bir sonraki adıma geçer

        
        for (int i = 1; i <= 10; i++)
        {
            if (i == 4)
            {
                //break; //Döngüyü tamamen sonlandırır
                continue; //O anki döngüyü atlar ve bir sonraki adıma geçer
            }
            Console.WriteLine(i);
        }

// for loop yapısı
// for döngüsü, belirli bir koşul sağlandığı sürece tekrarlanan bir kod bloğunu çalıştırmak için kullanılır.
// for döngüsünün temel yapısı şu şekildedir:   
// for (başlatma; koşul; artış/değişim)
// {
//     // Tekrarlanacak kod bloğu
// }
// Başlatma: Döngü değişkeninin başlangıç değeri burada tanımlanır.
// Koşul: Döngünün devam edip etmeyeceğini belirleyen bir koşuldur. Eğer bu koşul true (doğru) ise, döngü çalışmaya devam eder; eğer false (yanlış) ise, döngü sona erer.
// Artış/Değişim: Döngü değişkeninin her döngü turundan sonra nasıl değişeceğini belirtir. Genellikle bu, değişkenin artırılması veya azaltılmasıdır.   


        // Ekrana girilen sayıya kadar olan tek sayıları yazdıran bir for döngüsü oluşturalım.

        Console.WriteLine("Bir sayı girin:");
        int sayac = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 1; i <= sayac; i++)
        {
            if (i % 2 != 0) // Tek sayılar için kontrol
            {
                Console.WriteLine(i);
            }
        }

    // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamını hesaplayan bir for döngüsü oluşturalım.
    int tekToplam = 0;
    int ciftToplam = 0;

        for (int i = 0; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                ciftToplam += i;
            }
            else
            {
                tekToplam += i;
            }
        }
        Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
        Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);

    // break ve continue ifadelerinin kullanımı
    // break ifadesi, döngüyü tamamen sonlandırmak için kullanılır.
    // continue ifadesi ise, o anki döngüyü atlayıp bir sonraki adıma geçmek için kullanılır.
    // Aşağıdaki örneklerde bu iki ifadenin kullanımını gösterelim.
    Console.WriteLine("Break ve Continue örnekleri:");
    
    Console.WriteLine("Break ile: 5'te duracak");
    for (int i = 1; i <= 10; i++)
    {
        if (i == 5)
        {
            break; // Döngüyü tamamen sonlandırır
        }
        Console.WriteLine("Break ile: " + i);
    }

    Console.WriteLine("Continue ile: 5 atlanacak");
    for (int i = 1; i <= 10; i++)
    {
        if (i == 5)
        {
            continue; // O anki döngüyü atlar ve bir sonraki adıma geçer
        }
        Console.WriteLine("Continue ile: " + i);
    }


    }
}
