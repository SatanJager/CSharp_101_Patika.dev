namespace plus_minus;

class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal positives = 0;
        decimal negatives = 0;
        decimal zeros = 0;
        decimal length = arr.Count;

        foreach (int num in arr)
        {
            if (num > 0)
            {
                positives++;
            }
            else if (num < 0)
            {
                negatives++;
            }
            else
            {
                zeros++;
            }
        }

        Console.WriteLine($"{positives / length:F6}");  // Format to 6 decimal places
        Console.WriteLine($"{negatives / length:F6}");
        Console.WriteLine($"{zeros / length:F6}");
    }   
}


class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
