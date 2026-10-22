using System;

public class MagicProgram
{
    public static void Main()
    {
        int[] numbers = { 91,87,73,64,235};

        for (int num=0;num<numbers.Length;num++)
        {
            int sum = numbers[num];
            while (sum > 9)
            {
                int temp = sum;
                sum = 0;
                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
            }
            if (sum == 1)
            {
                Console.WriteLine(numbers[num] +" is a Magic number.");
            }
        }
    }
}