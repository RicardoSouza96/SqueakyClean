using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder newString = new StringBuilder();
        char ch;
        for (int i = 0; i < identifier.Length; i++)
        {
            ch = identifier[i];

            if (ch == ' ')
                ch = '_';

            newString.Append(ch);
        }
        return newString.ToString();
    }
}


