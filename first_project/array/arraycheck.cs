using System;

public class CheckSimilar
{
    public static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt16(Console.ReadLine());
        int[] arr = new int[n];

        Console.Write("Enter " + n + " elements: ");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt16(Console.ReadLine());

        int[] copy = (int[])arr.Clone();
        bool similar = true;
        if (arr.Length != copy.Length)
            similar = false;
        else
            for (int i = 0; i < n; i++)
                if (arr[i] != copy[i])
                {
                    similar = false;
                    break;
                }
        if (similar)
            Console.WriteLine("Both arrays are similar.");
        else
            Console.WriteLine("Both arrays are NOT similar.");
    }
}   