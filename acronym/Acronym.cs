using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] delimiterChars = { ' ', '-', '_' };
        string[] words = phrase.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
        string abbr = "";

        foreach (string word in words)
        {            
            abbr += word[0];
        }

        return abbr.ToUpper();

    }
}