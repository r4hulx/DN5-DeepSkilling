public class UpdateItem
{
    public static void Run()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "Rahul");

        students[101] = "Rahul Das";

        Console.WriteLine(students[101]);
    }
}