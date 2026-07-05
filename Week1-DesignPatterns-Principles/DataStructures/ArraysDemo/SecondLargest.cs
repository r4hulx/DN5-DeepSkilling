public class SecondLargest
{
    public static void Run()
    {
        int[] numbers = { 30, 10, 50, 20, 40 };

        Array.Sort(numbers);

        int secondLargest = numbers[numbers.Length - 2];

        Console.WriteLine($"Second Largest = {secondLargest}");
    }
}