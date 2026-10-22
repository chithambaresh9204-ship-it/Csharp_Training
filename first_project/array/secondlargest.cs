using System;

public class SecondLargest
{
    public static void Main()
    {
        int[] arr = { 12, 35, 1, 10, 34, 187 };
        int firstlargest = int.MinValue;
        int secondlargest = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > firstlargest)
            {
                secondlargest = firstlargest;
                firstlargest = arr[i];
            }
            else if (arr[i] > secondlargest && arr[i] != firstlargest)
            {
                secondlargest = arr[i];
            }
        }
        if (secondlargest == int.MinValue)
            Console.WriteLine("No second largest element");
        else
            Console.WriteLine("Second largest: " + secondlargest);
    }
}   