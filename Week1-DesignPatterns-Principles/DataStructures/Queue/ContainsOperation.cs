using System.Collections.Generic;

public class ContainsOperation
{
    public static void Run()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine(queue.Contains(20)
            ? "Element Found"
            : "Element Not Found");
    }
}