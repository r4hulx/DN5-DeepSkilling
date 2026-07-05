public class ReplaceWord
{
    public static void Run()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        Console.Write("Word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("New word: ");
        string newWord = Console.ReadLine();

        string result = text.Replace(oldWord, newWord);

        Console.WriteLine(result);
    }
}