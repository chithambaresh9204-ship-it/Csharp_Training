                    
using System;
public class SeqPattern
{
    public static void Main(String[] args)
    {
       int n=1;
        for(int i = 1; i <= 4; i++)
        {
             
            for(int j = 1; j <= i; j++)
            {
                Console.Write(n+" ");
                n++;
            }
            Console.WriteLine();
        }
    }
}