public class SortDescending
{
    public static void Run()
    {
        int[] numbers = { 30, 10, 50, 20, 40 };

        Array.Sort(numbers);
        Array.Reverse(numbers);

        Console.WriteLine("Descending Order:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}