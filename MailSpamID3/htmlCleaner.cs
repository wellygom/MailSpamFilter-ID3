using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public static class htmlCleaner
{

    public static string StripTagsRegex(string source)
    {
        return Regex.Replace(source, "<.*?>", string.Empty);
    }

    static Regex _htmlRegex = new Regex("<.*?>", RegexOptions.Compiled);

    public static string StripTagsRegexCompiled(string source)
    {
        return _htmlRegex.Replace(source, string.Empty);
    }

    public static string StripTagsCharArray(string source)
    {
        char[] array = new char[source.Length];
        int arrayIndex = 0;
        bool inside = false;

        for (int i = 0; i < source.Length; i++)
        {
            char let = source[i];
            if (let == '<')
            {
                inside = true;
                continue;
            }
            if (let == '>')
            {
                inside = false;
                continue;
            }
            if (!inside)
            {
                array[arrayIndex] = let;
                arrayIndex++;
            }
        }
        return new string(array, 0, arrayIndex);
    }

    public static string GetFirstParagraph(string source)
    {
        Match m = Regex.Match(source, @"<p>\s*(.+?)\s*</p>");
        if (m.Success)
        {
            return m.Groups[1].Value;
        }

        else
        {
            return "";
        }
    }
}

