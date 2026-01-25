namespace _08_2_switch_case;

class Program
{
    static void Main(string[] args)
    {
        //switch case yapısı


        // Kullanıcıdan bir gün numarası alalım ve buna göre gün adını yazdıralım.  
        // Switch Case Örneği
        int day = Convert.ToInt32(Console.ReadLine().Trim());

        switch (day)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz gün numarası");
                break;
        }

            //break: her case bloğunun sonunda kullanılır ve programın switch ifadesinden çıkmasını sağlar.
            //default: Hiçbir case bloğu eşleşmediğinde çalıştırılacak kodu belirtir.
            //case: Her bir durumu temsil eder ve belirli bir değere karşılık gelen kod bloğunu içerir.
            //switch: Bir değişkenin değerine göre farklı kod bloklarını çalıştırmak için kullanılır. 

            //case ifadeleri sadece sabit değerler (sabitler, sabit ifadeler, enum üyeleri) içerebilir; değişkenler veya aralıklar kullanılamaz.
            //case ifadeleri benzersiz olmalıdır; aynı değere sahip birden fazla case tanımlanamaz.
            //switch ifadesi, null değerler için de kullanılabilir, ancak case ifadeleri null ile eşleşemez.
            //switch ifadesi, yalnızca belirli veri türleriyle (örneğin, int, char, string, enum) kullanılabilir; karmaşık veri türleri desteklenmez.
            //switch ifadesi, performans açısından bazı durumlarda if-else yapısına göre daha verimli olabilir, ancak bu her zaman geçerli değildir.
            //switch ifadesi, C# 8.0 ve sonrasında "switch ifadeleri" (switch expressions) olarak da kullanılabilir, bu da daha kısa ve daha okunabilir kod yazmayı sağlar.
        
            
            // Switch Case Örneği

            int month = DateTime.Now.Month;

            //Expression uzun yolu  

            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız.");
                    break;      
                case 5:
                    Console.WriteLine("Mayıs ayındasınız.");
                    break;
                case 6:
                    Console.WriteLine("Haziran ayındasınız.");
                    break;
                case 7:
                    Console.WriteLine("Temmuz ayındasınız.");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındasınız.");
                    break;
                case 9:
                    Console.WriteLine("Eylül ayındasınız.");
                    break;
                case 10:
                    Console.WriteLine("Ekim ayındasınız.");
                    break;
                case 11:
                    Console.WriteLine("Kasım Ayındasınız.");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay numarası");
                    break;
            }

        //Expression kısa yolu

        switch (month)
        {
            case 12:
            case 1:
            case 2:               
            Console.WriteLine("Kış ayındasınız.");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar ayındasınız.");
                break;
            case 6:
            case 7:
            case 8: 
                Console.WriteLine("Yaz ayındasınız.");
                break;
            case 9:
            case 10:        
            case 11:
                Console.WriteLine("Sonbahar ayındasınız.");
                break;
            default:
                Console.WriteLine("Geçersiz ay numarası");
                break;
        }


        //switch expression örneği
        string season = month switch
        {
            12 or 1 or 2 => "Kış ayındasınız.",
            3 or 4 or 5 => "İlkbahar ayındasınız.",
            6 or 7 or 8 => "Yaz ayındasınız.",
            9 or 10 or 11 => "Sonbahar ayındasınız.",
            _ => "Geçersiz ay numarası"
        };

        Console.WriteLine(season);
        Console.WriteLine("Program sonlandı. Ana menüye dönmek için bir tuşa basınız...");
        Console.ReadKey();

        
    }
}
