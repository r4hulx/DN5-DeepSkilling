int[] numbers = { 64, 25, 12, 22, 11 };

Console.WriteLine("Before Sorting:");

foreach (int num in numbers)
{
    Console.Write(num + " ");
}

for (int i = 0; i < numbers.Length - 1; i++)
{
    int minIndex = i;

    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[j] < numbers[minIndex])
        {
            minIndex = j;
        }
    }

    int temp = numbers[i];
    numbers[i] = numbers[minIndex];
    numbers[minIndex] = temp;
}

Console.WriteLine("\n\nAfter Selection Sort:");

foreach (int num in numbers)
{
    Console.Write(num + " ");
}