using System;
public class SpyDigits
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check it is Spy or not: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int temp=num;
        int sum=0;
        int prd=1;
        while (num > 0)
        {
            sum+=num%10;
            prd*=num%10;
            num=num/10;
        }
        if(sum==prd)
            Console.WriteLine("The given number "+temp+" is a spy number");
        else    
            Console.WriteLine("The given number "+temp+" is a not a spy number");
    }
}