public class RemoveDuplicates
{
    public static void Run()
    {
        int[] numbers = { 10, 20, 30, 20, 10, 40, 50 };

        int[] unique = numbers.Distinct().ToArray();

        Console.WriteLine("After Removing Duplicates:");

        foreach (int num in unique)
        {
            Console.WriteLine(num);
        }
    }
}