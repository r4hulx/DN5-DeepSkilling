public class ReverseList
{
    public static void Run()
    {
        List<int> numbers = new List<int>()
        {
            10,
            20,
            30,
            40
        };

        numbers.Reverse();

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}