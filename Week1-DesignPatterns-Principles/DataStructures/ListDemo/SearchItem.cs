public class SearchItem
{
    public static void Run()
    {
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        if (numbers.Contains(20))
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not Found");
    }
}