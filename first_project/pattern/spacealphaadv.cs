using System;
public class SpaceAlphaadvPattern
{
    public static void Main(String[] args)
    {
        char A='a';
        for(int i = 1; i <=4 ; i++)
        {for(int k = 1; k <=i-1; k++)
            {
                Console.Write("  ");
            } 

            for(int j = i; j <= 4; j++)
            {
                Console.Write(A+" ");
                A++;
            }
            
            Console.WriteLine();
        }
    }
}