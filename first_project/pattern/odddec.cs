                    
using System;
using System.Security.Cryptography.X509Certificates;
public class OddDec
{
    public static void Main(String[] args)
    {
    
        for(int i = 1; i <=5; i++)
        {
            int x=9;
            for(int j = 1; j <= i; j++)
            {
                Console.Write(x+" ");
                x-=2;
            }
            Console.WriteLine();
        }
    }
}