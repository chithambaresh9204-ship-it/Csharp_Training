                    
using System;
public class CharInverse
{
    public static void Main(String[] args)
    {
       
        for(int i = 4; i >= 1; i--)
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