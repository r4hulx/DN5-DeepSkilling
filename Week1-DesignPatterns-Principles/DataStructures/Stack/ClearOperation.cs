using System.Collections.Generic;

public class ClearOperation
{
    public static void Run()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        stack.Clear();

        Console.WriteLine($"Elements after Clear = {stack.Count}");
    }
}