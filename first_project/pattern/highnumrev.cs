using System;
public class HighNumRev
{
    public static void Main(String[] args)
    {
        int n=15;
        for(int i = 1; i <= 5; i++)
        {
            for(int j = 5; j >= i; j--)
            {
                Console.Write(n+" ");
                 n--;
            }
            
            Console.WriteLine();
        }
    }
}