using System;

public class Automorphic
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        double square = Math.Pow(num,2);
        string numStr = num.ToString();
        string squareStr = square.ToString();

        if (squareStr.EndsWith(numStr))
            Console.WriteLine(num + " is an Automorphic number.");
        else
            Console.WriteLine(num + " is NOT an Automorphic number.");
    }
}   