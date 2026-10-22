using System;

public class VowelsConsonants
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int vowels = 0, consonants = 0;
        string vowelStr = "aeiouAEIOU";

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLetter(str[i]))
            {
                if (vowelStr.IndexOf(str[i]) == 1)
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine("Vowels = " + vowels);
        Console.WriteLine("Consonants = " + consonants);
    }
}   