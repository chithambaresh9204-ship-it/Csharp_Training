using System;

public class Calci
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first num: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the second num: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the operation to be performed: ");
        string operations = Console.ReadLine();

        switch (operations)
        {
            case "a":
                Console.WriteLine(num1 + num2);
                break;
            case "s":
                Console.WriteLine(num1 - num2);
                break;
            case "m":
                Console.WriteLine(num1 * num2);
                break;
            case "d":
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("End");
                break;
        }
    }
}