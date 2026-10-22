using System;

public class PrimeCount
{
    public static void Main()
    {
        int[] numbers = { 4, 7, 11, 19, 28, 9, 2 };
        int primeCount = 0;
        for (int num=0;num<numbers.Length;num++)
        {
            if (num <= 1) 
                continue;
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primeCount++;
            }
        }
        Console.WriteLine("Total Prime Numbers Count: "+primeCount);
    }
}