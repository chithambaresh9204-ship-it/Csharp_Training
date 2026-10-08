using System;
public class Grade
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the marks you scored for 5 subjects: ");
        double MarksScored=Convert.ToDouble(Console.ReadLine());
        int TotalMarks=500;
        double Percentage=(MarksScored/TotalMarks)*100;
        if (Percentage > 90)
        {
            Console.WriteLine("Your Grade is A");
        }else if (Percentage > 80 && Percentage<=90)
        {
            Console.WriteLine("Your Grade is B");
        }else if (Percentage > 70 && Percentage<=80)
        {
            Console.WriteLine("Your Grade is C");
        }else if (Percentage > 60 && Percentage<=70)
        {
            Console.WriteLine("Your Grade is D");
        }
        else
        {
            Console.Write("Your Grade is E");
        }

    }
}