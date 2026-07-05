int[] numbers = { 50, 20, 40, 10, 30 };

Console.WriteLine("Before Sorting:");

foreach (int num in numbers)
{
    Console.Write(num + " ");
}

for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = 0; j < numbers.Length - i - 1; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

Console.WriteLine("\n\nAfter Bubble Sort:");

foreach (int num in numbers)
{
    Console.Write(num + " ");
}