using System;
public class PerfectNumloop
{
    public static void Main(String[] args)
    {
        int num=1;
        
        for(int j = num; j <= 100; j++)
        {
            int sum=0;
        
            for(int i = 1; i < j; i++)
            {
                if (j % i == 0)
                {
                    sum+=i;
                }
            }
            if (sum==j)
            {
                Console.WriteLine(j+" is a perfect number");
            }

        }
    }
}