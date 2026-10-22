using System;

public class SortArray
{
    public static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt16(Console.ReadLine());
        int[] arr = new int[n];

        Console.Write("Enter " + n + " elements: ");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt16(Console.ReadLine());
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

        Console.WriteLine("Ascending: ");
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
    }
}   