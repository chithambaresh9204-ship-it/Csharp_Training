using System;
public class Prime
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check whether it is prime or not: ");
        int num=Convert.ToInt16(Console.ReadLine());
        bool isprime=true;
        if (num == 1 || num == 2)
        {
            Console.WriteLine(num+" is a prime number");
        }
        for(int i = 2; i < Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isprime=false;
            }
        }
        if (isprime)
        {
            Console.WriteLine(num+" is a Prime Number");
        }
        else
        {
        Console.WriteLine(num+" is a Composite Nummber");
        }
    }
}