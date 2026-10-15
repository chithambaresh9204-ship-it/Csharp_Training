using System;
public class PrdofDigits
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check its Product of digits: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int temp=num;
        int prd=1;
        while (num > 0)
        {
            prd*=num%10;
            num=num/10;
        }
        Console.WriteLine("The Product of the digits present in the given number "+temp+" is: "+prd);
       
    }
}