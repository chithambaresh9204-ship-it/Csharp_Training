using System;
public class Amstrong
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check its Amstrong or not: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int temp=num;
        double sum=0;
        int rem=0;
        while (num > 0)
        {
            rem=num%10;
            sum+=Math.Pow(rem,3);
            num=num/10;
        }
        if(sum==temp){
            Console.WriteLine("The given Number "+temp+" is Amstrong Number");
        }
        else
        {
            Console.WriteLine("The given Number "+temp+" is not Amstrong Number");
        }
    }
}