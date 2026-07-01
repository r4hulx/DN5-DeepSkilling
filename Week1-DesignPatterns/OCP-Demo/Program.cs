Shape rectangle = new Rectangle(10, 5);
Shape circle = new Circle(7);
Shape triangle = new Triangle(10, 8);

AreaCalculator calculator = new AreaCalculator();

Console.WriteLine($"Rectangle Area : {calculator.Calculate(rectangle)}");
Console.WriteLine($"Circle Area    : {calculator.Calculate(circle)}");
Console.WriteLine($"Triangle Area : {calculator.Calculate(triangle)}");
