public class Employee : IPrototype<Employee>
{
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";

    public Employee Clone()
    {
        return new Employee
        {
            Name = this.Name,
            Department = this.Department
        };
    }

    public void Display()
    {
        Console.WriteLine($"Name       : {Name}");
        Console.WriteLine($"Department : {Department}");
    }
}