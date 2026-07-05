using System.Collections.Generic;

public class TraverseLinkedList
{
    public static void Run()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);

        foreach (int item in list)
            Console.WriteLine(item);
    }
}