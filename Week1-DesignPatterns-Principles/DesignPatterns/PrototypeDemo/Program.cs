Employee original = new Employee
{
    Name = "Rahul",
    Department = "Engineering"
};

Employee cloned = original.Clone();

Console.WriteLine("Original Employee");
original.Display();

Console.WriteLine();

Console.WriteLine("Cloned Employee");
cloned.Display();