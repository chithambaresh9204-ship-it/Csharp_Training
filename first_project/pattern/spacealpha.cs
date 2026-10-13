using System;
public class SpaceAlphaPattern
{
    public static void Main(String[] args)
    {
        char A='a';
        for(int i = 1; i <= 4; i++)
        {
            for(int j = i; j <= 4; j++)
            {
                Console.Write("  ");
            }
            for(int k = 1; k <=i; k++)
            {
                Console.Write(A+" ");
                A++;
            } 
            Console.WriteLine();
        }
    }
}