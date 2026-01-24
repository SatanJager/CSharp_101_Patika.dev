using System.Diagnostics.CodeAnalysis;

namespace Day01;

class Program
{
    static void Main(string[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        int i1;
        double d1;
        string s1;

        // Read and save an integer, double, and String to your variables.
        i1 = int.Parse(Console.ReadLine());
        d1 = double.Parse(Console.ReadLine());
        s1 = Console.ReadLine()!;

        // Print the sum of both integer variables on a new line.
        int intSum = i + i1;
        Console.WriteLine(intSum);
        
        // Print the sum of the double variables on a new line.
        double doubleSum = d + d1;
        Console.WriteLine(doubleSum.ToString("F1"));

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        string stringSum =  s + s1;
        Console.WriteLine(stringSum);



    }
}
