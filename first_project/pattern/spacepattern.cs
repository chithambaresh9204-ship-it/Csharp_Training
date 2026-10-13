using System;
public class SpacePattern
{
    public static void Main(String[] args)
    {
        for(int i = 1; i <= 4; i++)
        {
            for(int j = i; j <= 4; j++)
            {
                Console.Write("  ");
            }
            for(int k = 1; k <=i; k++)
            {
                Console.Write(k+" ");
            } 
            Console.WriteLine();
        }
    }
}