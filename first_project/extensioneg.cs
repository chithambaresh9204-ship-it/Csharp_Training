using System;

static class VowelStringExtensions
{
    public static int CountVowel( this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        text.ToLower();
        char[] s=text.ToCharArray();
        int count=0;
        foreach (char i in s)
        {
            if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
            {
                count++;
            }
        }
        

        return count;
    }
}

class extensionProgram
{
    static void Main()
    {
        string name = "aeiou";

        int count = name.CountVowel();

        Console.WriteLine("Text: " + name);
        Console.WriteLine("Vowel Count: " + count);
    }
}
