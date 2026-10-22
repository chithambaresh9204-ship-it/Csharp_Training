using System;

public class ArrayReverse
{
       public static void Main()
    {
        int[] Array = { 1,4,3,2,5,6,8,7,9,0 };
        int n=Array.Length;
        for(int i = n - 1; i >= 0; i--)
        {
            Console.Write(Array[i]+" ");
        }
    }
}