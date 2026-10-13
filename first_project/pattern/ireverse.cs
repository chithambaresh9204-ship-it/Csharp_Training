using System;
public class revPattern
{
    public static void Main(String[] args)
    {//Square
        for(int i = 1; i <= 5; i++)
        {
            for(int j = i; j >= 1; j--)
            {
                Console.Write(j+" ");
                
            }
            Console.WriteLine();
        }
    }
}