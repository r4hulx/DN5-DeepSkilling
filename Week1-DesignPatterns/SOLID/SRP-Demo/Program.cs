Employee emp = new Employee("Rahul", 50000);

SalaryCalculator calculator = new SalaryCalculator();

Console.WriteLine($"Employee : {emp.Name}");
Console.WriteLine($"Monthly Salary : {emp.BasicSalary}");
Console.WriteLine($"Annual Salary : {calculator.CalculateAnnualSalary(emp)}");