using System;
using System.IO.Compression;
public class hollowinversePattern
{
    public static void Main(String[] args)
    {
        
        for(int i = 1; i <=4 ; i++)
        {
            char A=(Char)('A'-2);
            for(int k = 1; k <=i-1; k++)
            {
                Console.Write("  ");
            } 

            for(int j = i; j <= 4; j++)
            {
                A=(Char)(A+2);
                if (i == 2 && j == 3)
                {
                    Console.Write("  ");
                }
                else
                {
                
                Console.Write(A+" ");
                }
                
            }
            
            Console.WriteLine();
        }
    }
}