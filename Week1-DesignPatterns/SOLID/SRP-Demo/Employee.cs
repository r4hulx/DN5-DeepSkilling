public class Employee
{
    public string Name { get; set; }
    public double BasicSalary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        BasicSalary = salary;
    }
}