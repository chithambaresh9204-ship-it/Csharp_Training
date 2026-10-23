using System;

public class RemoveVowels
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine().ToLower();
        int n=str.Length;
        string result = "";
        for (int i = 0; i < n; i++)
        {
            char ch = char.ToLower(str[i]);
            if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u')
                result += str[i];
        }

        Console.WriteLine("Output: " + result);
    }
}   