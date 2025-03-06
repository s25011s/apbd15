internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Average([1,2,3,4,5,10]));
    }
    private static float Average(int[] values)
    {
        float result = 0;
        foreach (int value in values){
            result += value;
        }
        return result/values.Length;
    }
}