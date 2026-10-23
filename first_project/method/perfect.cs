using System;
public class Perfect
{
    public void perfectnum(int num)
    {
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
    public class Mainclass
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter a number to check whether it is perfect or not: ");
            int num=Convert.ToInt32(Console.ReadLine());
            Perfect per=new Perfect();
            per.perfectnum(num);
        }
    }
}
