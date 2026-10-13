using System;
public class Odd
{
    public static void Main(String[] args)
    {
        //Printing all odd nums between 1 and 50;
        for(int i = 1; i <= 50; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("Odd Numbers Are: "+i);
            }
        }
    }
}