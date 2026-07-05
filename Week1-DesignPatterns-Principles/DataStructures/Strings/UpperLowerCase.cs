public class UpperLowerCase
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        Console.WriteLine($"Upper Case = {text.ToUpper()}");
        Console.WriteLine($"Lower Case = {text.ToLower()}");
    }
}