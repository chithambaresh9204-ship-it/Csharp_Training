using System;
public class Salary
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your basic salary: ");
        double basicSalary = Convert.ToDouble(Console.ReadLine());
        int TotalWorkingDay=26;
        Console.Write("Enter the Number of Days Worked : ");
        int WorkedDay=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Number of Years of Experience : ");
        int Experience=Convert.ToInt32(Console.ReadLine());
        double OneDaySalary=basicSalary/TotalWorkingDay;
        double FinalSalary=OneDaySalary*WorkedDay;
        if(Experience>5)
        {
            FinalSalary = FinalSalary+(0.1*basicSalary);
        }
        else if(Experience>3 && Experience<=5)
        {
            FinalSalary = FinalSalary+(0.05*basicSalary);
        }
        else if(Experience>1 && Experience <= 3)
        {
            FinalSalary = FinalSalary+(0.01*basicSalary);
        }
        else
        {
            FinalSalary = FinalSalary;
        }
        Console.WriteLine("Total Salary: "+basicSalary);
        Console.WriteLine("Total Working Days: "+TotalWorkingDay);
        Console.WriteLine("Number of Days Worked: "+WorkedDay);
        Console.WriteLine("Final Salary for Worked Days: "+ FinalSalary);
    }
}