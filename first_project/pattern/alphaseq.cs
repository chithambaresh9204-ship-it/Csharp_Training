                    
using System;
public class AlphaSeq
{
    public static void Main(String[] args)
    {
       char n='a';
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