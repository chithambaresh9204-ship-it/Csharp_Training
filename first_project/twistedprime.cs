using System;
public class TwistedPrime
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a Prime number to check its twistedprime or not: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int temp=num;
        double sum=0;
        int rem=0;
        while (num > 0)
        {
            rem=num%10;
            sum=sum*10+rem;
            num=num/10;
        }
         bool isprime=true;
        if (sum == 1 || sum == 2)
        {
            Console.WriteLine(num+" is a prime number");
        }
        for(int i = 2; i < Math.Sqrt(sum); i++)
        {
            if (sum % i == 0)
            {
                isprime=false;
            }
        }
        if (isprime)
        {
            Console.WriteLine(temp+" is a TwistedPrime Number");
        }
        else
        {
        Console.WriteLine(temp+" is not a Twistedprime Nummber");
        }
    }
}