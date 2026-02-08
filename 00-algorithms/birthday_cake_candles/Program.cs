using System.Runtime.CompilerServices;

namespace birthday_cake_candles;

class Result
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        if(candles == null || candles.Count == null)
        {
            throw new ArgumentException("Candle List cannot be null or empty");
        }

        var tallestCandle = candles.Max();
        
        int countCandle = 0;

        for(int i = 0; i < candles.Count; i++)
        {
            if(tallestCandle == candles[i])
            {
                countCandle++;
            }
        }
        return countCandle;

        // Alternative
        // var candlesCount = candles.Count(c => c == tallestCandle);  
        // return = candlesCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

