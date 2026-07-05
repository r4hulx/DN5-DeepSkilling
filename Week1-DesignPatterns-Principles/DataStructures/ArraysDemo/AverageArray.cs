public class AverageArray
{
    public static void Run()
    {
        int[] numbers = new int[5];
        int sum = 0;

        Console.WriteLine("Enter 5 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];
        }

        double average = (double)sum / numbers.Length;

        Console.WriteLine($"\nAverage = {average}");
    }
}