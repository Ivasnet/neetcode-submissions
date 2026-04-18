public class Solution {
    public bool IsPalindrome(string s)
    {
        if (s.Length is 0 or 1) return true;

        var l = 0;
        var r = s.Length - 1;
        for (var i = 0; i < s.Length; i++)
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
            
            if (char.ToLower(s[l]) != char.ToLower(s[r])) return false;
            l++;
            r--;
        }

        return true;
    }
}
