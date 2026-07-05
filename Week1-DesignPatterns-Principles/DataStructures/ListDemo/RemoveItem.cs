public class RemoveItem
{
    public static void Run()
    {
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        numbers.Remove(20);

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}