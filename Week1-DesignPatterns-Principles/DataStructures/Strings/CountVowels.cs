public class CountVowels
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        int count = 0;

        foreach (char ch in text.ToLower())
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                count++;
            }
        }

        Console.WriteLine($"Number of Vowels = {count}");
    }
}