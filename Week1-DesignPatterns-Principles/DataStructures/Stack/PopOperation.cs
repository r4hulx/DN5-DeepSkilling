using System.Collections.Generic;

public class PopOperation
{
    public static void Run()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Removed Element = {stack.Pop()}");

        Console.WriteLine("\nRemaining Elements:");

        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }
}