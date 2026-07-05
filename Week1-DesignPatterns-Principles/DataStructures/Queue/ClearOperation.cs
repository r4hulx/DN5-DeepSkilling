using System.Collections.Generic;

public class ClearOperation
{
    public static void Run()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue.Clear();

        Console.WriteLine($"Elements after Clear = {queue.Count}");
    }
}