using System;
public class Even
{
    public static void Main(String[] args)
    {
        //Printing all even nums between 1 and 50;
        for(int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Even Numbers Are: "+i);
            }
        }
    }
}