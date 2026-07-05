public class ReverseArray
{
    public static void Run()
    {
        int[] numbers={10,20,30,40,50};

        Console.WriteLine("Reverse Array:");

        for(int i=numbers.Length-1;i>=0;i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}