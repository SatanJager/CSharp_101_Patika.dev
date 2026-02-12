namespace Day07;

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        ReversePrint(arr);
    }

    public static void ReversePrint(List<int> arr)
    {
        int lengt = arr.Count;

        for(int i= lengt-1; i >= 0; i--)
        {
            if(i != 0)
            {
                Console.Write(arr[i] + " ");
            }
            else
            {
                Console.Write(arr[i]);
            }
        }

    }
}
