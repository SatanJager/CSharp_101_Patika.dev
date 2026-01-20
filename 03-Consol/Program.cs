using System;
using System.Collections.Generic;

namespace _03_Consol;

class Program
{
    public static void Main(string[] args)
    {
        List<string> strList = new List<string>();
        strList.Add("Deneme");
        strList.Add("VS Code");
        strList.Add(".NET CLI");

        List<int> intList = new List<int>() { 1, 2, 3, 4, 5 };


        foreach (var str in strList)
        {
             Console.WriteLine(str);
        }

        foreach (var number in intList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Hello, World!");
        Console.ReadLine();

        Console.WriteLine("İsminizi giriniz:");
        string name = Console.ReadLine();
        Console.WriteLine("Soyadınızı giriniz:");
        string surname = Console.ReadLine();
        // Console.WriteLine($"Merhaba {name} {surname}, .NET dünyasına hoş geldiniz!"); // farklı bir string interpolation yöntemi
        Console.WriteLine("Merhaba " + name + " " + surname + ", .NET dünyasına hoş geldiniz!");
        Console.ReadLine();
    }
}
