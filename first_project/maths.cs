using System;

public class Maths
{
    static double FindPower(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    static int GetAbsolute(int num)
    {
        return Math.Abs(num);
    }

    static void FindMaxMin(int a, int b)
    {
        Console.WriteLine("Max: " + Math.Max(a, b));
        Console.WriteLine("Min: " + Math.Min(a, b));
    }

    static double RoundValue(double num)
    {
        return Math.Round(num);
    }

    static double CalculateCompoundInterest(double principal, double rate, int time)
    {
        return principal * Math.Pow((1 + rate / 100), time) - principal;
    }

    static double CalculateBMI(double weight, double height)
    {
        return weight / Math.Pow(height, 2);
    }

    static double GetDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double ConvertTemp(double celsius)
    {
        return Math.Round((celsius * 9 / 5) + 32, 2);
    }

    static void RandomCircleArea()
    {
        Random rnd = new Random();
        double radius = rnd.NextDouble() * 10 + 1;
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Radius: " + Math.Round(radius, 2));
        Console.WriteLine("Area:   " + Math.Round(area, 2));
    }

    static void FindQuadraticRoots(double a, double b, double c)
    {
        double disc = b * b - 4 * a * c;
        if (disc > 0)
        {
            double r1 = (-b + Math.Sqrt(disc)) / (2 * a);
            double r2 = (-b - Math.Sqrt(disc)) / (2 * a);
            Console.WriteLine("Root1: " + r1);
            Console.WriteLine("Root2: " + r2);
        }
        else if (disc == 0)
            Console.WriteLine("Both roots: " + (-b / (2 * a)));
        else
        {
            double real = -b / (2 * a);
            double imag = Math.Sqrt(-disc) / (2 * a);
            Console.WriteLine("Root1: " + real + " + " + imag + "i");
            Console.WriteLine("Root2: " + real + " - " + imag + "i");
        }
    }

    static void FindLogs(double num)
    {
        Console.WriteLine("Log10: " + Math.Log10(num));
        Console.WriteLine("Log(e): " + Math.Log(num));
    }
    static void ShowTrigValues(double angle)
    {
        Console.WriteLine("Sin: " + Math.Sin(angle));
        Console.WriteLine("Cos: " + Math.Cos(angle));
        Console.WriteLine("Tan: " + Math.Tan(angle));
    }
    static void RoundingComparison(double num)
    {
        Console.WriteLine("Floor:   " + Math.Floor(num));
        Console.WriteLine("Ceiling: " + Math.Ceiling(num));
        Console.WriteLine("Round:   " + Math.Round(num));
    }
    static double PopulationGrowth(double initial, double rate, int years)
    {
        return initial * Math.Exp(rate * years);
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("1. Power: " + FindPower(2, 10));
        Console.WriteLine("2. Absolute: " + GetAbsolute(-7));
        Console.WriteLine("3. MaxMin:");
        FindMaxMin(15, 9);
        Console.WriteLine("4. Rounded: " + RoundValue(7.89));
        Console.WriteLine("5. Compound Interest: " + CalculateCompoundInterest(10000, 5, 3));
        Console.WriteLine("6. BMI: " + CalculateBMI(70, 1.75));
        Console.WriteLine("7. Distance: " + GetDistance(0, 0, 3, 4));
        Console.WriteLine("8. Fahrenheit: " + ConvertTemp(37));
        Console.WriteLine("9. Circle Area:");
        RandomCircleArea();
        Console.WriteLine("10. Quadratic Roots:");
        FindQuadraticRoots(1, -5, 6);
        Console.WriteLine("11. Logs:");
        FindLogs(100);
        Console.WriteLine("12. Trig:");
        ShowTrigValues(0);
        Console.WriteLine("13. Rounding:");
        RoundingComparison(5.678);
        Console.WriteLine("14. Population: " + PopulationGrowth(1000, 0.05, 10));
    }
}   