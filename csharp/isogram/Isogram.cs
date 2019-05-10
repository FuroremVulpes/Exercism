using static System.Char;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var lettersInWord = word.ToUpper().Where(ch => IsLetter(ch));
        var distinctLettersInWord = lettersInWord.Distinct();

        return lettersInWord.Count().Equals(distinctLettersInWord.Count());
    }
}
