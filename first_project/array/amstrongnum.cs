using System;

public class AmstrngProgram
{
    public static void Main()
    {
        int[] numbers = { 153, 4, 370, 125, 42 };
        for (int num=0;num<numbers.Length;num++)
        {
            if (num < 0) continue;
            int original = num;
            int sum = 0;
            int digits = num.ToString().Length;
            int temp = num;
            while (temp > 0)
            {
                int remainder = temp % 10;
                sum += (int)Math.Pow(remainder, digits);
                temp /= 10;
            }
            if (sum == original)
            {
                Console.WriteLine(original+" is an Armstrong number.");
            }
        }
    }
}