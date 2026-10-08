using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
public class Placement
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your Aptitude Round Marks: ");
        double AptiMark=Convert.ToDouble(Console.ReadLine());
        double Marks=AptiMark;
        bool placed=false;
        if (AptiMark > 70)
        {
            Console.WriteLine("You are Eligible for Technical Round!");
            Console.Write("Enter your Technical Round Mark: ");
            double TechMark=Convert.ToDouble(Console.ReadLine());
            Marks=Marks+TechMark;
            if (TechMark > 80){
                 Console.WriteLine("You are Eligible for HR Round!");
                Console.Write("Enter your HR Round Mark: ");
                double HRMark=Convert.ToDouble(Console.ReadLine());
                Marks=Marks+HRMark;
                if (HRMark > 80)
                {
                     Console.WriteLine("Congragulations You are PLaced!");
                     placed=true;
                }
                else
                {
                     Console.WriteLine("Sorry You are Eliminated!");
                }
            }else{
                Console.WriteLine("Sorry You are Eliminated!");
                
            }
        }
        else
        {
             Console.WriteLine("Sorry You are Eliminated!");
        }if(placed){
            if(Marks>280 && Marks <= 300)
            {
                Console.WriteLine("Your Salary will be 25k per Month");
            }else if(Marks>250 && Marks <= 280)
            {
                Console.WriteLine("Your Salary will be 20k per Month");
            }else{
                Console.WriteLine("Your Salary will be 15k per Month");
            }
        }
    }
}