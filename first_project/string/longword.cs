using System;
public class LongestWord
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string[] words = str.Split(' ');
        string longest = words[0];
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
                longest = words[i];
        }
        Console.WriteLine("Longest word: " + longest);
    }
}   