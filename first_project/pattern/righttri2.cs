using System;
public class Right
{
    public static void Main(String[] args)
    {
        for(int i = 2; i <= 8; i+=2)
        {
            for(int j = 2; j <= i; j+=2)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
    }
}