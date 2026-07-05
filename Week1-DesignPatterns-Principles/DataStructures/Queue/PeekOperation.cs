using System.Collections.Generic;

public class PeekOperation
{
    public static void Run()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine($"Front Element = {queue.Peek()}");
    }
}