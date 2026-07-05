public class Substring
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        Console.Write("Starting Index: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        string result = text.Substring(start, length);

        Console.WriteLine($"Substring = {result}");
    }
}