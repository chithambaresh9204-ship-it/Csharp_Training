using System;
public class Convert
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Console.WriteLine("Lowercase: " + str.ToLower());
        Console.WriteLine("Uppercase: " + str.ToUpper());
    }
}   