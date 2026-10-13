using System;
public class SpaceAlphasPattern
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
                Console.Write(A+" ");
                
            }
            
            Console.WriteLine();
        }
    }
}