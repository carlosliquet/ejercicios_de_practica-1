
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        string reversed = ReverseText(input);
        Console.WriteLine($"Reversed Text: {reversed}");

        Console.WriteLine("Letter Positions:");
        foreach (char c in reversed)
        {
            int position = GetAlphabetPosition(c);
            if (position > 0)
                Console.WriteLine($"{c} -> {position}");
        }
    }

    static string ReverseText(string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int GetAlphabetPosition(char c)
    {
        c = char.ToLower(c);
        if (c >= 'a' && c <= 'z')
            return c - 'a' + 1;
        return -1; 
    }
}

