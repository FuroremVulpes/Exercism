using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var phraseClean = new string(phrase.Where(c => (char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-')).ToArray());

        return string.Join(string.Empty, phraseClean.ToUpper().Split(new[] {' ', '-'}, StringSplitOptions.RemoveEmptyEntries).Select(s => s[0]));

    }
}