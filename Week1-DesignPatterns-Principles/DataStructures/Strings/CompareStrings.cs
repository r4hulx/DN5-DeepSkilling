public class CompareStrings
{
    public static void Run()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (str1 == str2)
            Console.WriteLine("Both strings are Equal");
        else
            Console.WriteLine("Strings are Not Equal");
    }
}