using System;
using System.Transactions;
public class StrongNum
{
    public static void Main(String[] args)
    {
        Console.Write("Enter an number to check whether it is a Strong Number or Not: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int temp=num;
        int sum=0;
        while (num > 0)
        {
            int fact=1;
            int rem=num%10;
            for(int i=1;i<=rem;i++)
            {
                fact=fact*i;
            }
            sum+=fact;
            num=num/10;
        }
        if(sum==temp){
            Console.WriteLine("The given Number "+temp+" is Strong Number");
        }
        else
        {
            Console.WriteLine("The given Number "+temp+" is not Strong Number");
        }
    }   
}