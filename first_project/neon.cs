using System;
public class NeonDigits
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check it is neon or not: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int temp=num*num;
        int sum=0;
        while (temp > 0)
        {
            sum+=temp%10;
            temp=temp/10;
        }
        if(sum==num)
            Console.WriteLine("The given number "+num+" is a neon number");
        else    
            Console.WriteLine("The given number "+num+" is a not a neon number");
    }
}