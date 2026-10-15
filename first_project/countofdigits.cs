using System;
public class CountofDigits
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check its sum of digits: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int temp=num;
        int sum=0;
        int Count=0;
        while (num > 0)
        {
            Count++;
            sum+=num%10;
            num=num/10;
        }
        Console.WriteLine("The sum of the digits present in the given number "+temp+" is: "+Count);
       
    }
}