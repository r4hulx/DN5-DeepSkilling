public class ReverseString
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        char[] arr = text.ToCharArray();

        Array.Reverse(arr);

        string reverse = new string(arr);

        Console.WriteLine($"Reversed String = {reverse}");
    }
}