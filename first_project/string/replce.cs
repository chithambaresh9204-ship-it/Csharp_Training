using System;

public class ReplaceDigits
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        int n=str.Length;
        string result = "";
        for (int i = 0; i < n; i++)
        {
            if (char.IsDigit(str[i]))
                result += "*";
            else
                result += str[i];
        }

        Console.WriteLine("Output: " + result);
    }
}   