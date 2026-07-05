int[] numbers = { 12, 11, 13, 5, 6 };

Console.WriteLine("Before Sorting:");

foreach (int num in numbers)
{
    Console.Write(num + " ");
}

for (int i = 1; i < numbers.Length; i++)
{
    int key = numbers[i];
    int j = i - 1;

    while (j >= 0 && numbers[j] > key)
    {
        numbers[j + 1] = numbers[j];
        j--;
    }

    numbers[j + 1] = key;
}

Console.WriteLine("\n\nAfter Insertion Sort:");

foreach (int num in numbers)
{
    Console.Write(num + " ");
}