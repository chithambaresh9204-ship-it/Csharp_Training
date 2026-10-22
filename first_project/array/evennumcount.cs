using System;

public class Evencount
{
    public static void Main()
    {
        int[] numbers = { 4, 7, 11, 28, 9, 2 };
        int evenCount = 0;

        for (int i=0;i<numbers.Length;i++)
        {
            if (i % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine("Total Even Numbers Count: "+evenCount);
    }
}