using System;

public class ArrayCopy
{
       public static void Main()
    {
        int[] Array1 = { 10, 20, 30, 40, 50 };
        int n=Array1.Length;
        int[] Array2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            Array2[i] = Array1[i];
        }
        for (int i=0;i<Array2.Length;i++)
        {
            Console.Write(Array2[i] + " ");
        }
    }
}