using System;
public class Pattern
{
    public static void Main(String[] args)
    {//Square
        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= 4; j++)
            {
                Console.Write("*"+" ");
            }
            Console.WriteLine();
        }
    }
}