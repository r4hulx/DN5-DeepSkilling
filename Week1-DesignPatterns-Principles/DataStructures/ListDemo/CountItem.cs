public class CountItems
{
    public static void Run()
    {
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        Console.WriteLine($"Count = {numbers.Count}");
    }
}