internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Average([1,2,3,4,5,10]));
        Console.WriteLine(Max([1, 2, 3, 4, 5, 10]));
    }
    private static float Average(int[] values)
    {
        float result = 0;
        foreach (int value in values)
        {
            result += value;
        }
        return result / values.Length;
    }
    private static float Max(int[] values)
    {
        float result = values[0];
        foreach (int value in values)
        {
            if(value > result)
            {
                result = value;
            }
        }
        return result;
    }
}