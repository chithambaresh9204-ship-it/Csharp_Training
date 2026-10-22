using System;
public class RemoveDigits
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (!char.IsDigit(str[i]))
                result += str[i];
        }
        Console.WriteLine("Output: " + result);
    }
}   