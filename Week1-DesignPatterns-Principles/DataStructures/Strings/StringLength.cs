public class StringLength
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        Console.WriteLine($"Length = {text.Length}");
    }
}