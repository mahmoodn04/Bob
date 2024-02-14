using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        string cleanstatement = Regex.Replace(statement, @"[^\w\d\s]", "");
        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        if (cleanstatement.Length == 0)
        {
            return "Fine. Be that way!";
        }

        if (cleanstatement.Any(char.IsLetter) && cleanstatement.ToUpper() == cleanstatement)
        {
            if (statement.EndsWith("?"))
            {
                return "Calm down, I know what I'm doing!";
            }

            return "Whoa, chill out!";
        }

        if (statement.Trim().EndsWith('?'))
        {
            return "Sure.";
        }

        return "Whatever.";
    }
}
