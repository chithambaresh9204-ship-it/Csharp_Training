                    
using System;
public class CharPattern
{
    public static void Main(String[] args)
    {
       
        for(int i = 1; i <= 4; i++)
        {
             char A='a';
            for(int j = 1; j <= i; j++)
            {
                Console.Write(A+" ");
                A++;
            }
            Console.WriteLine();
        }
    }
}