public class SortList
{
    public static void Run()
    {
        List<int> numbers = new List<int>()
        {
            40,
            10,
            30,
            20
        };

        numbers.Sort();

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}