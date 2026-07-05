public class RemoveItem
{
    public static void Run()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "Rahul");
        students.Add(102, "Amit");

        students.Remove(101);

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} : {student.Value}");
        }
    }
}