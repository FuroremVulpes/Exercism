using static System.Char;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var alphabet = new List<char>();
        for (char letter = 'A'; letter <= 'Z'; letter++) alphabet.Add(letter);

        var distinctLettersFromInput = new HashSet<char>(input.ToUpper()).Where(ch => IsLetter(ch));

        return alphabet.Count().Equals(distinctLettersFromInput.Count());
    }
}
