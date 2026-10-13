using System;
using System.Globalization;
public class lastPattern
{
    public static void Main(String[] args)
    {
        int x=1;
        for(int i = 5; i >= 1; i--)
        {
            for(int j = x; j <=5; j++)
            {
                Console.Write(j+" ");
            }
            x++;
            Console.WriteLine();
        }
    }
}