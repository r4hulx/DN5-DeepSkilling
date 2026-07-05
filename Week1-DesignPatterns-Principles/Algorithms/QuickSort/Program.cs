using System;

class Program
{
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int swap = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swap;

        return i + 1;
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static void Main()
    {
        int[] numbers = { 10, 7, 8, 9, 1, 5 };

        Console.WriteLine("Before Sorting:");

        foreach (int num in numbers)
            Console.Write(num + " ");

        QuickSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("\n\nAfter Quick Sort:");

        foreach (int num in numbers)
            Console.Write(num + " ");
    }
}