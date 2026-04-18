public class Solution {
    public bool IsPalindrome(string s)
    {
        if (s.Length is 0 or 1) return true;

        for (int l = 0, r = s.Length - 1; l <= r; )
        {
            if (!char.IsLetterOrDigit(s[l]))
            {
                l++;
                continue;
            }
            
            if (!char.IsLetterOrDigit(s[r]))
            {
                r--;
                continue;
            }
            
            if (char.ToLower(s[l++]) != char.ToLower(s[r--])) return false;
        }

        return true;
    }
}
