namespace _13_2_datetime_math;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("**** DATETIME KÜTÜPHANESİ ****");
        //Sistem setting'in gösterdiği gibi gösterir

        Console.WriteLine(DateTime.Now); // 09.04.2026 13:38:29
        Console.WriteLine(DateTime.Now.Date); // 09.04.2026 00:00:00
        Console.WriteLine(DateTime.Now.Day); //9
        Console.WriteLine(DateTime.Now.Month); //4
        Console.WriteLine(DateTime.Now.Year); //2026
        Console.WriteLine(DateTime.Now.Hour); // 13
        Console.WriteLine(DateTime.Now.Minute); //38
        Console.WriteLine(DateTime.Now.Second); //29

        Console.WriteLine(DateTime.Now.DayOfWeek); //Thursday
        Console.WriteLine(DateTime.Now.DayOfYear); //99

        Console.WriteLine(DateTime.Now.ToLongDateString()); // 9 Nisan 2026 Perşembe
        Console.WriteLine(DateTime.Now.ToShortDateString()); //9.04.2026

        Console.WriteLine(DateTime.Now.ToLongTimeString()); //13:46:34
        Console.WriteLine(DateTime.Now.ToShortTimeString()); //13:46

        // olan tarihe ekleme yapar.
        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddMinutes(30));
        Console.WriteLine(DateTime.Now.AddMonths(4));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(40));

        //DateTime Format:
        Console.WriteLine(DateTime.Now.ToString("dd")); //dd day
        Console.WriteLine(DateTime.Now.ToString("ddd")); //ddd day of week  
        Console.WriteLine(DateTime.Now.ToString("dddd")); //dddd day of week full name
        Console.WriteLine(DateTime.Now.ToString("MM")); //MM month
        Console.WriteLine(DateTime.Now.ToString("MMM")); //MMM month name
        Console.WriteLine(DateTime.Now.ToString("MMMM")); //MMMM month full name
        Console.WriteLine(DateTime.Now.ToString("yy")); //yy year two digit
        Console.WriteLine(DateTime.Now.ToString("yyyy")); //yyyy year
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd")); //yyyy-MM-dd date
        
        Console.WriteLine("**** MATH KÜTÜPHANESİ ****");
        /////MATH Kütüphanesi/////
        //Math kütüphanesi sayısal işlemler yapmamızı sağlar.

        Console.WriteLine(Math.Abs(-25)); // 25 --> mutlak değer
        Console.WriteLine(Math.Sin(10)); // 10 sayısının sinüsü
        Console.WriteLine(Math.Cos(10)); // 10 sayısının kosinüsü
        Console.WriteLine(Math.Tan(10)); // 10 sayısının tanjantı
        
        Console.WriteLine(Math.Ceiling(22.3)); // 23 --> yukarı yuvarlama
        Console.WriteLine(Math.Round(22.3)); // 22 --> en yakın tam sayıya yuvarlama
        Console.WriteLine(Math.Floor(22.3)); // 22 --> aşağı yuvarlama

        Console.WriteLine(Math.Max(2,6)); // 6 --> iki sayıdan büyük olanı verir
        Console.WriteLine(Math.Min(2,6)); // 2 --> iki sayıdan küçük olanı verir

        Console.WriteLine(Math.Pow(3,4)); // 81 --> 3'ün 4. kuvveti POWER
        Console.WriteLine(Math.Sqrt(9)); // 3 --> karekök alma
        Console.WriteLine(Math.Log(9)); // 2.1972245773362196 --> logaritma alma
        Console.WriteLine(Math.Exp(4)); // 54.598150033144236 --> e üzeri 4 üssü alma
        Console.WriteLine(Math.Log10(10)); // 1 --> 10 tabanında logaritma alma


    }
}
