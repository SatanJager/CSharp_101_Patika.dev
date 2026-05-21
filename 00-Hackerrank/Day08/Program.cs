using System;
using System.Collections.Generic;
using System.IO;

namespace Day08;

class Solution
{
    static void Main(string[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int n = int.Parse(Console.ReadLine());

        var telBook = new Dictionary<string, string>();  // int kullanılmadı çünkü telefon numarası 0 ile başlayabilir ve bu durumda int olarak saklanamaz. veya çok büyük olabilir.

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string name = input[0];
            string phoneNumber = input[1];

            telBook.Add(name, phoneNumber);

            //telBook[name] = phoneNumber;  // Dictionary'de aynı anahtar varsa, yeni değeri atar. Yoksa yeni bir anahtar-değer çifti ekler.
        } 

        string query;
        while ((query = Console.ReadLine()) != null)
        {
            if (telBook.ContainsKey(query))
            {
                Console.WriteLine(query + "=" + telBook[query]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        
    }
}
