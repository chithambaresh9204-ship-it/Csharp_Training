using System;
public class Scholarship
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your 12th grade percentage: ");
        double percentage = Convert.ToDouble(Console.ReadLine());
        int totalfees = 100000;
        double scholarshipfees=0;
        if(percentage >= 90)
        {
            scholarshipfees=totalfees/2;
            Console.WriteLine("You are eligible for a scholarship of 50% of the total fees. Your scholarship amount is: " + scholarshipfees);
        }       
    }
}