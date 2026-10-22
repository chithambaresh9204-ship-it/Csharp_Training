using System;

public class ArraySum
{
    public static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt16(Console.ReadLine());
        int[] arr = new int[n];
        Console.Write("Enter " + n + " elements: ");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt16(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += arr[i];
        Console.WriteLine("Sum = " + sum);
    }
}               