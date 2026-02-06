using System.Buffers;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json.Serialization;

namespace _10_2_array;

class Program
{
    static void Main(string[] args)
    {
        //Array Metodları:

        //Sort:

        int[] sayiDizisi = {23,12,4,86,72,3,11,17}; //8 elamanlı max 7 indexi var.

        Console.WriteLine("***** Sırasız Dizi Listesi *****");
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        
        Console.WriteLine("***** Sıralı Dizi Listesi - Array.Sort *****");

        Array.Sort(sayiDizisi);

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }


        //Clear
        Console.WriteLine("***** Array.Clear *****");

        Array.Clear(sayiDizisi, 2, 2);   // 2. index'den başlayarak 2 elemana 0 değeri atar
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Reverse
        Console.WriteLine("***** Array.Reverse *****");

        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //IndexOf
        Console.WriteLine("***** Array.IndexOf *****");

        Console.WriteLine(Array.IndexOf(sayiDizisi, 23) );

        //Resize
        Console.WriteLine("***** Array.Resize *****");

        Array.Resize<int>(ref sayiDizisi, 9);
        sayiDizisi[8] = 99;

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);    
        }

        



    }
}
