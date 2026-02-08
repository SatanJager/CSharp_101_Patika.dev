namespace migratory_birds;

class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    
    public static int migratoryBirds(List<int> arr)
    {
        
        int[] counter = new int[6];

        foreach(var bird in arr)
        {
            counter[bird]++;
        }

        int maxCount = 0;
        int resultId = 0;

        for(int i =1; i <= 5; i++)
        {
            if(counter[i] > maxCount)
            {
                maxCount = counter[i];
                resultId = i;
            }
        }
        return resultId;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
