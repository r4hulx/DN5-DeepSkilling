public class ContainsKeyDemo
{
    public static void Run()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "Rahul");

        Console.WriteLine(students.ContainsKey(101));
    }
}