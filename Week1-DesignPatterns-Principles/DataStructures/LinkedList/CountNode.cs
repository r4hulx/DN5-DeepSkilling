using System.Collections.Generic;

public class CountNodes
{
    public static void Run()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);

        Console.WriteLine($"Count = {list.Count}");
    }
}