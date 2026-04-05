namespace Day16;

class Solution
{
    public static void Main(string[] args)
    {
        string S = Console.ReadLine();

        try
        {
            var i = int.Parse(S);
            Console.WriteLine(i);
        }
        catch (Exception)
        {
            Console.WriteLine("Bad String");
        }
    }
}
