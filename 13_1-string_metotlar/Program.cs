using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace _13_1_string_metotlar;

class Program
{
    static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
        string degisken2 = "dersimiz CSharp, Hoşgeldiniz!";

        // Length
        Console.WriteLine("Karakter Sayısı: " + degisken.Length);

        // ToUpper, ToLower
        Console.WriteLine("Büyük Karakter: " + degisken.ToUpper());
        Console.WriteLine("küçük karakter: " + degisken.ToLower());

        //Concat --> Birleştirme
        Console.WriteLine(String.Concat(degisken, " Merhaba!"));

        //Compare, CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1  --> 0: eşit, 1: ilk string daha büyük, -1: ikinci string daha büyük
        Console.WriteLine(String.Compare(degisken, degisken2, ignoreCase: true)); // 0,1,-1 --> ignoreCase: büyük küçük harf duyarsız karşılaştırma yapar true: büyük küçük harf duyarsız, false: büyük küçük harf duyarlı karşılaştırma yapar. 0,1,-1  --> 0: eşit, 1: ilk string daha büyük, -1: ikinci string daha büyük
        Console.WriteLine(String.Compare(degisken, degisken2, ignoreCase: false)); // 0,1,-1 --> ignoreCase: büyük küçük harf duyarlı karşılaştırma yapar


        // Contains --> Bir string ifadenin, başka bir string ifadeyi içerip içermediğini kontrol eder. Büyük küçük harf duyarlıdır.
        Console.WriteLine(degisken.Contains(degisken2)); // false
        Console.WriteLine(degisken.Contains("CSharp")); // true

        // EndsWith, StartsWith
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); // true
        Console.WriteLine(degisken.StartsWith("Merhaba!")); // false

        //IndexOf, LastIndexOf
        Console.WriteLine(degisken.IndexOf("CS")); // 9 --> CSharp ifadesinin başladığı indexi verir.
        Console.WriteLine(degisken.IndexOf("Taylan")); // -1 --> Taylan ifadesi degisken stringinde bulunamadığı için -1 döner.
        Console.WriteLine(degisken.LastIndexOf("i")); // 26 --> i karakterinin son görüldüğü indexi verir.

        //Insert --> Bir string ifadenin belirli bir indexine, başka bir string ifade ekler.
        Console.WriteLine(degisken.Insert(0, "Merhaba! ")); // 0 indexine "Merhaba! " ifadesini ekler.

        //PadLeft, PadRight --> Bir string ifadenin soluna veya sağına belirli sayıda karakter ekler. Eklenen karakter varsayılan olarak boşluk karakteridir.
        Console.WriteLine(degisken + degisken2.PadLeft(50));  // degisken2 stringinin soluna 30 karakter ekler.
        Console.WriteLine(degisken + degisken2.PadLeft(35, '*')); // degisken2 stringinin soluna 30 karakter ekler ve eklenen karakter '*' olur.
        Console.WriteLine(degisken.PadRight(50) + degisken2); // degisken stringinin sağına 50 karakter ekler.
        Console.WriteLine(degisken.PadRight(50, '-') + degisken2); // degisken stringinin sağına 50 karakter ekler ve eklenen karakter '-' olur.
        Console.WriteLine(degisken + "Bunu ekledim".PadLeft(50, '-')); // "Bunu ekledim" stringinin soluna 50 karakter ekler ve eklenen karakter '-' olur.

        //Remove --> Bir string ifadenin belirli bir indexinden başlayarak, belirli sayıda karakteri siler.
        Console.WriteLine(degisken.Remove(10)); // 10 indexinden başlayarak, sonuna kadar olan karakterleri siler.
        Console.WriteLine(degisken.Remove(5, 3)); // 5 indexinden başlayarak, 3 karakter siler.
        Console.WriteLine(degisken.Remove(0, 1)); // 0 indexinden başlayarak, 1 karakter siler.

        //Replace --> Bir string ifadenin belirli bir karakterini veya karakter dizisini, başka bir karakterle veya karakter dizisiyle değiştirir.
        Console.WriteLine(degisken.Replace("CSharp", "C#")); // degisken stringindeki "CSharp" ifadesini "C#" ifadesiyle değiştirir.
        Console.WriteLine(degisken.Replace(" ", "*")); // degisken stringindeki tüm boşluk karakterlerini "*" karakteriyle değiştirir.

        //Split --> Bir string ifadeyi, belirli bir karaktere veya karakter dizisine göre parçalara ayırır ve bu parçaları bir dizi olarak döner.
        Console.WriteLine(degisken.Split(' ')[1]); // degisken stringini boşluk karakterine göre parçalayarak, ikinci parçayı döner. (CSharp,)
        Console.WriteLine(degisken.Split(' ')[0]); // degisken stringini boşluk karakterine göre parçalayarak, ilk parçayı döner. (Dersimiz)
        Console.WriteLine(degisken.Split(' ')[2]); // degisken stringini boşluk karakterine göre parçalayarak, üçüncü parçayı döner. (Hoşgeldiniz!)

        //Substring --> Bir string ifadenin belirli bir indexinden başlayarak, belirli sayıda karakteri döner.
        Console.WriteLine(degisken.Substring(4)); // 4 indexinden başlayarak, sonuna kadar olan karakterleri döner. (imiz CSharp, Hoşgeldiniz!)
        Console.WriteLine(degisken.Substring(4, 8)); // 4 indexinden başlayarak, 8 karakter döner. (imiz CSharp)


    }
}
