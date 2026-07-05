public class CountWords
{
    public static void Run()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"Number of Words = {words.Length}");
    }
}