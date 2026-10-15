using System;
public class Palindrome
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check its palindrome or not: ");
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
        if(sum==temp){
            Console.WriteLine("The given Number "+temp+" is a Palindrome Number");
        }
        else
        {
            Console.WriteLine("The given Number "+temp+" is not Palindrome Number");
        }
    }
}