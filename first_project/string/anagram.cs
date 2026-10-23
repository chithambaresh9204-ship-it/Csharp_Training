using System;
using Microsoft.VisualBasic;

public class CheckAnagram
{
    public static void Main(String[] args)
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();
        string S1=s1.ToLower();
        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();
        string S2=s2.ToLower();

        char[] a = S1.ToCharArray();
        char[] b = S2.ToCharArray();
        Array.Sort(a);
        Array.Sort(b);

        if (new string(a) == new string(b))
            Console.WriteLine("Anagrams");
        else
            Console.WriteLine("Not Anagrams");
    }
}   