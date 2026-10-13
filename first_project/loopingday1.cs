using System;
using System.ComponentModel;
public class Loop
{
    public static void Main(String[] args)
    {
        /*Console.Write("Enter the Start Value: ");
        int StartValue=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the End Value: ");
        int EndValue=Convert.ToInt32(Console.ReadLine());
        if(StartValue<EndValue){
            for(int i = StartValue; i <= EndValue; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                     Console.WriteLine("FISSBZZ");
                }
                else if (i % 3 == 0)
                {
                     Console.WriteLine("FISS");
                }else if (i % 5 == 0)
                {
                     Console.WriteLine("BUZZ");
                }
                else
                {
                     Console.WriteLine(i);
                }
            }
        }*/
        int Sum=0;
        for(int i = 100; i <= 150; i++)
        {
            if (i % 9 == 0)
            {
                Sum+=i;
            }
        }
        Console.WriteLine(Sum);
    }
}