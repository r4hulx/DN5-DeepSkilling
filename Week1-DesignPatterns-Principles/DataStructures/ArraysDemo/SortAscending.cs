public class SortAscending
{
    public static void Run()
    {
        int[] numbers = { 30, 10, 50, 20, 40 };

        Array.Sort(numbers);

        Console.WriteLine("Ascending Order:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}