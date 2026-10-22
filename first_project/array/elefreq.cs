using System;

public class Frequency
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
        {
            if (i > 0 && arr[i] == arr[i - 1])
                continue;
            int count = 0;
            for (int j = 0; j < n; j++)
                if (arr[j] == arr[i])
                    count++;
            Console.WriteLine(arr[i] + " -> " + count);
        }
    }
}   