using System.Collections.Generic;

public class AddNode
{
    public static void Run()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);

        Console.WriteLine("Linked List:");

        foreach (int item in list)
            Console.WriteLine(item);
    }
}