namespace Day03;

class Program
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        if(N % 2 == 1 || (N >= 6 && N <= 20))
        {
            Console.WriteLine("Weird");
        }
        else
        {
            Console.WriteLine("Not Weird");
           
        }

    }
}
