using System;
public class Fact
{
    public static void Main(String[] args)
    {
        //Factorial of an num
        Console.Write("Enter a number for finding the factorial: ");
        int numf=Convert.ToInt32(Console.ReadLine());
            if(numf==0||numf==1){
                Console.WriteLine("Factorial of "+numf+" is: 1");
            }
            else
            {
                int factorial=1;
                for(int j = 1; j <= numf; j++)
                {
                    factorial*=j;
                }
                Console.WriteLine("Factorial of "+numf+" is: "+factorial);
            }
    }
}