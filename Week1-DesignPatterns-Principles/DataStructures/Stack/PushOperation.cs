using System.Collections.Generic;

public class PushOperation
{
    public static void Run()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Elements after Push:");

        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }
}