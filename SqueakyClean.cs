using System;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        char[] chars = identifier.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == ' ')
                chars[i] = '_';
        }
        return new string(chars);
    }
}


