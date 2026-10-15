using System;
public class SpaceAlphaadvPattern
{
    public static void Main(String[] args)
    {
        char A='a';
        for(int i = 1; i <=4 ; i++)
        {

            for(int j = 1; j <= i; j++)
            {
                Console.Write(A+" ");
                A++;
            }
            
            Console.WriteLine();
        }
    }
}