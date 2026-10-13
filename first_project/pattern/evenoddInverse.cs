using System;
public class EvenOddInverse
{
    public static void Main(String[] args)
    {
        for(int i = 4; i >= 1; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                if(j%2==0){
                    Console.Write("0 ");
                }
                else
                {
                    Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
    }
}