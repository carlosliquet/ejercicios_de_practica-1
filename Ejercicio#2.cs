using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entrar numero:");
        string input = Console.ReadLine();

        // Extract numbers from mixed input (handles no spaces, mixed separators, etc.)
        var numbers = Regex.Matches(input, @"\d+")
                           .Cast<Match>()
                           .Select(m => int.Parse(m.Value)) // Convert matches to integers
                           .OrderBy(n => n) // Sort numbers in ascending order
                           .ToArray();

        Console.WriteLine("numero ordenado (con la sustitucion de 'X'):");
        foreach (var num in numbers)
        {
            Console.Write(num == 7 ? "x " : num + " ");
        }

        Console.WriteLine();
    }
}



