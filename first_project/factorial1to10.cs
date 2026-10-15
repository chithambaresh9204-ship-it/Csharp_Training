using System;
public class Factloop
{
    public static void Main(String[] args)
    {
        int num=1;
        for(int j=num;j<=10;j++){
            if(j==0||j==1){
                Console.WriteLine("Factorial of "+j+" is: 1");
            }
            else
            {
                int factorial=1;
                for(int k = 1; k <= j; k++)
                {
                    factorial*=k;
                }
                Console.WriteLine("Factorial of "+j+" is: "+factorial);
            }
        }
    }
}