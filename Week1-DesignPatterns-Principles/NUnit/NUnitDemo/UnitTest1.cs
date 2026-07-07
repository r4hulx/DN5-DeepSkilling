namespace NUnitDemo;

public class Tests
{
    private Calculator calculator;

    [OneTimeSetUp]
    public void GlobalSetup()
    {
        Console.WriteLine("Started all tests...");
    }

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
        Console.WriteLine("Setup before each test");
    }

    [Test]
    public void IsEven_ReturnsTrue()
    {
        Assert.That(calculator.IsEven(10), Is.True);
    }

    [Test]
    public void IsEven_ReturnsFalse()
    {
        Assert.That(calculator.IsEven(9), Is.False);
    }

    [Test]
    public void GetName_ReturnsNotNull()
    {
        Assert.That(calculator.GetName(true), Is.Not.Null);
    }

    [Test]
    public void GetName_ReturnsNull()
    {
        Assert.That(calculator.GetName(false), Is.Null);
    }

    [Test]
    public void GetSubjects_ReturnsNotEmpty()
    {
        Assert.That(calculator.GetSubjects(), Is.Not.Empty);
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() =>
        {
            calculator.Divide(10, 0);
        });
    }

    [TearDown]
    public void Cleanup()
    {
        Console.WriteLine("Cleanup after each test");
    }

    [OneTimeTearDown]
    public void GlobalCleanup()
    {
        Console.WriteLine("Finished all tests...");
    }
}