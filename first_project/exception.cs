using System;

static class StringExtensions
{
    public static int CountSentence( this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        string[] Sentence = text.Split(
            new char[] { '.' },
            StringSplitOptions.RemoveEmptyEntries
        );

        return Sentence.Length;
    }
}

class exceptionProgram
{
    static void Main()
    {
        string name = """A paragraph is a self-contained unit of discourse in writing that deals with a particular point or idea, or starts a line of dialogue. It is conventionally defined as a section of text composed of one or more sentences that are unified and coherent around a single controlling idea.""";

        int count = name.CountSentence();

        Console.WriteLine("Text: " + name);
        Console.WriteLine("Sen Count: " + count);
    }
}
