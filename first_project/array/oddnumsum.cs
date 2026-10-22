using System;

public class OddSum
{
    public static void Main()
    {
        int[] numbers = { 4, 7, 11, 28, 9, 2 };
        int oddSum = 0;

        for (int num=0;num<numbers.Length;num++)
        {
            if (num % 2 != 0)
            {
                oddSum += num;
            }
        }

        Console.WriteLine("Total Odd Numbers Sum: "+oddSum);
    }
}