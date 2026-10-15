using System;
public class PerfectNum
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check whether it is perfect or not: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int sum=0;
        for(int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum+=i;
            }
        }
        if (sum==num)
        {
            Console.WriteLine(num+" is a perfect number");
        }
        else
        {
        Console.WriteLine(num+" is not a perfect number");
        }
    }
}