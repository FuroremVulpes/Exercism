using System.Collections.Generic;
using System.Linq;
using static System.Char;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        var lettersInInput = input.ToUpper().Where(ch => IsLetter(ch));
        var generalScore = 0;

        foreach (var letter in lettersInInput)
        {
            generalScore += LetterScore(letter);
        }
        return generalScore;
    }

    private static int LetterScore(char letter)
    {
        var scoreMapping = new Dictionary<char, int>()
            {
                // One point
                { 'E', 1 }, { 'A', 1 }, { 'I', 1 }, { 'O', 1 },
                { 'R', 1 }, { 'T', 1 }, { 'S', 1 }, { 'U', 1 },
                { 'L', 1 }, { 'N', 1 },

                // Two points
                { 'D', 2 }, { 'G', 2 },

                // Three points
                { 'B', 3 }, { 'C', 3 }, { 'M', 3 }, { 'P', 3 }, 

                // Four points
                { 'F', 4 }, { 'W', 4 }, { 'Y', 4 }, { 'H', 4 },
                { 'V', 4 },

                // Five points
                { 'K', 5 },

                // Eight points
                { 'X', 8 }, { 'J', 8 },

                // Ten pints
                { 'Q', 10 }, { 'Z', 10 }
            };
        return scoreMapping[letter];
    }
}