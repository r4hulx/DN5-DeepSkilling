namespace NUnitDemo;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public bool IsEven(int number) => number % 2 == 0;

    public string? GetName(bool exists)
    {
        return exists ? "Rahul" : null;
    }

    public string[] GetSubjects()
    {
        return new[] { "C#", "SQL", "NUnit" };
    }

    public void Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        int result = a / b;
    }
}