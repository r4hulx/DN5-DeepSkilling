public class SearchElement
{
    public static void Run()
    {
        int[] numbers = {10,20,30,40,50};

        Console.Write("Enter number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for(int i=0;i<numbers.Length;i++)
        {
            if(numbers[i]==target)
            {
                found=true;
                break;
            }
        }

        Console.WriteLine(found ? "Element Found" : "Element Not Found");
    }
}