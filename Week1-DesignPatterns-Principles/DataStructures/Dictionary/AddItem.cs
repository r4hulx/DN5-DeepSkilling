public class AddItem
{
    public static void Run()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "Rahul");
        students.Add(102, "Amit");
        students.Add(103, "Riya");

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} : {student.Value}");
        }
    }
}