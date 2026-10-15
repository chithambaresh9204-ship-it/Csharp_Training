using System;
public class Harshad
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check it is Harshad or not: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int temp=num;
        int sum=0;
        while (num > 0)
        {
            sum+=num%10;
            num=num/10;
        }
        if(temp%sum==0)
            Console.WriteLine("The given number "+temp+" is a Harshad Number");
        else
            Console.WriteLine("The given number "+temp+" is a not a Harshad Number");
    }
}