using System;
public class Tableloop
{
    public static void Main(String[] args)
    {
        int num=1;
        for(int j=num;j<=5;j++){
            Console.WriteLine("Table of "+j);
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+"*"+j+":"+(j*i));
            }
        }
    }
}