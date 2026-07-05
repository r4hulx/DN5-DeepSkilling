int[] numbers = { 10, 20, 30, 40, 50 };

Console.Write("Enter number to search: ");
int target = Convert.ToInt32(Console.ReadLine());

bool found = false;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == target)
    {
        Console.WriteLine($"Found at index {i}");
        found = true;
        break;
    }
}

if (!found)
{
    Console.WriteLine("Number not found");
}