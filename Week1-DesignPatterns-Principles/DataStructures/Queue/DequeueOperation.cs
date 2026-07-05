using System.Collections.Generic;

public class DequeueOperation
{
    public static void Run()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine($"Removed Element = {queue.Dequeue()}");

        Console.WriteLine("\nRemaining Elements:");

        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}