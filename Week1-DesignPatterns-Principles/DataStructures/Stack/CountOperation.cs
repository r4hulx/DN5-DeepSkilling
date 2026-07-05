using System.Collections.Generic;

public class CountOperation
{
    public static void Run()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Total Elements = {stack.Count}");
    }
}