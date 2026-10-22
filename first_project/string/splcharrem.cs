using System;

public class RemoveSpecial
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLetterOrDigit(str[i]))
                result += str[i];
        }

        Console.WriteLine("Output: " + result);
    }
}   