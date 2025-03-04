using System;
using System.Collections;
using System.Linq;

//Given two strings s and t, return true if t is an anagram of s, false otherwise.
public class Easy1
{
    public static Boolean CheckAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        else
        {
            int l = s.Length;
            Dictionary<char, int> sCounts = new Dictionary<char, int>();
            Dictionary<char, int> tCounts = new Dictionary<char, int>();

            for (int i = 0; i < l; i++)
            {
                if (!sCounts.ContainsKey(s[i]))
                {
                    sCounts.Add(s[i], 0);
                }
                if (!tCounts.ContainsKey(t[i]))
                {
                    tCounts.Add(t[i], 0);
                }
                sCounts[s[i]] = 1 + sCounts[s[i]];
                tCounts[t[i]] = 1 + tCounts[t[i]];
            }
            foreach(char c in t)
            {
                if (!sCounts.ContainsKey(c))
                {
                    return false;
                }
                else if(!tCounts.ContainsKey(c))
                {
                    return false;
                }
                if (sCounts[c] != tCounts[c])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
