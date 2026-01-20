using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace _05_operatorler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atama ve İşlemli Atama Operatörleri:");
        // Atama ve işlemli atama operatörleri

        int a = 10;
        a += 5; // a = a + 5
        Console.WriteLine($"a: {a}");
        a -= 5; // a = a - 5
        Console.WriteLine($"a: {a}");
        a /= 5; // a = a / 5
        Console.WriteLine($"a: {a}");
        a *= 5; // a = a * 5
        Console.WriteLine($"a: {a}");
        a %= 3; // a = a % 3
        Console.WriteLine($"a: {a}");

        Console.WriteLine("Mantıksal Operatörler:");
        // Mantıksal operatörler
        // &&, ||, !

        bool isSuccess = true;
        bool isCompleted = false;

        if (isSuccess && isCompleted)
            Console.WriteLine("Perfect!");  //her iki koşul da true ise çalışır. isCompleted false olduğu için çalışmaz.

        if (isSuccess || isCompleted)
            Console.WriteLine("Great!"); //bir koşulun true olması yeterlidir. isSuccess true olduğu için çalışır.

        if (isSuccess && !isCompleted)  //isCompleted'in false olması durumunda ! değilse ile true yapar.
            Console.WriteLine("Fine!"); 

        Console.WriteLine("İlişkisel Operatörler:");
        // İlişkisel operatörler
        // <, >, <=, >=, ==, != 

        int a1 = 3;
        int a2 = 4;
        bool sonuc = a1 < a2;
        Console.WriteLine(sonuc);  // true
        sonuc = a1 > a2;
        Console.WriteLine(sonuc); // false
        sonuc = a1 >= a2;
        Console.WriteLine(sonuc); // false
        sonuc = a1 <= a2;
        Console.WriteLine(sonuc); // true
        sonuc = a1 == a2;
        Console.WriteLine(sonuc); // false
        sonuc = a1 != a2;
        Console.WriteLine(sonuc); // true

        Console.WriteLine("Aritmetik Operatörler:");
        // Aritmetik operatörler
        // /, *, +, -, %

        int sayi1 = 10;
        int sayi2 = 5;
        int sayi3 = 12;

        int sonuc1 = sayi1 / sayi2;
        Console.WriteLine(sonuc1); // 2
        sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1); // 50
        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1); // 15
        sonuc1 = sayi1 - sayi2;
        Console.WriteLine(sonuc1); // 5
        sonuc1 = sayi1 % sayi2;
        Console.WriteLine(sonuc1); // 0 kalan sıfır  MOD alma işlemi
        int sonuc2 = sayi3 % sayi2;
        Console.WriteLine(sonuc2); // 2 kalan iki
        sayi3++;
        Console.WriteLine(sayi3); // 13
        sayi3--;
        Console.WriteLine(sayi3); // 12


    }
}
