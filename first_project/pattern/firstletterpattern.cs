using System;
public class First
{
    public static void Main(String[] args)
    {
        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= 3; j++)
            {
                if (i==1||i==4||j==1)
                {
                    Console.Write("c ");
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