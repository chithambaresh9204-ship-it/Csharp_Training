using System;
public class AdundantDeficient
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to check whether it is Adundant or Deficient: ");
        int num=Convert.ToInt16(Console.ReadLine());
        int sum=0;
        for(int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum+=i;
            }
        }
        if (sum>num)
        {
            Console.WriteLine(num+" is a Abundant Number");
        }
        else if(sum<num)
        {
        Console.WriteLine(num+" is a Deficient Number");
        }
        else
        {
            Console.WriteLine(num+"is a Perfect Number");
        }
    }
}