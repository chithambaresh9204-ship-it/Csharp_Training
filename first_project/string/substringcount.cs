using System;

public class CountSubstring
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();

        int count = 0;
        for (int i = 0; i <= str.Length - sub.Length; i++)
        {
            if (str.Substring(i, sub.Length) == sub)
                count++;
        }

        Console.WriteLine("Occurrences: " + count);
    }
}   