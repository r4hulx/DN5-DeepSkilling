int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };

Console.Write("Enter number to search: ");
int target = Convert.ToInt32(Console.ReadLine());

int left = 0;
int right = numbers.Length - 1;
bool found = false;

while (left <= right)
{
    int mid = (left + right) / 2;

    if (numbers[mid] == target)
    {
        Console.WriteLine($"Found at index {mid}");
        found = true;
        break;
    }
    else if (target < numbers[mid])
    {
        right = mid - 1;
    }
    else
    {
        left = mid + 1;
    }
}

if (!found)
{
    Console.WriteLine("Number not found");
}