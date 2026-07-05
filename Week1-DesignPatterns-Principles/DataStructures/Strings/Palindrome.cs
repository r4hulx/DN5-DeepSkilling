public class Palindrome
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        string reverse = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            reverse += text[i];
        }

        if (text == reverse)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a Palindrome");
    }
}