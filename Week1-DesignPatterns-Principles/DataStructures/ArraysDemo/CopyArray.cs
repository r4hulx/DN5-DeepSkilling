public class CopyArray
{
    public static void Run()
    {
        int[] original={10,20,30,40,50};
        int[] copy=new int[original.Length];

        for(int i=0;i<original.Length;i++)
        {
            copy[i]=original[i];
        }

        Console.WriteLine("Copied Array:");

        foreach(int item in copy)
        {
            Console.WriteLine(item);
        }
    }
}