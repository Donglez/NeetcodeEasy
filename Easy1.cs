using System;
using System.Linq;

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
            int cnt = 0;
            foreach (char cT in t)
            {
                if (s.Contains(cT))
                {
                    cnt++;
                }
            }
            if (cnt == s.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
