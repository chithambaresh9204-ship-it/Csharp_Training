using System;
public class Hollo
{
    public static void Main(String[] args)
    {
        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= 4; j++)
            {
                if (i==1||i==4||j==1||j==4)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
                
            }
            Console.WriteLine();
        }
    }
}