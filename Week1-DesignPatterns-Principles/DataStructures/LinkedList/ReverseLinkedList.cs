using System.Collections.Generic;

public class ReverseLinkedList
{
    public static void Run()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);

        Console.WriteLine("Reverse Order:");

        var node = list.Last;

        while (node != null)
        {
            Console.WriteLine(node.Value);
            node = node.Previous;
        }
    }
}