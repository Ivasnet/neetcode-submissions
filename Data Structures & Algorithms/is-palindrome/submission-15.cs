public class Solution {
    public bool IsPalindrome(string s)
    {
        if (s.Length is 0 or 1) return true;

        var l = -1;
        var r = s.Length;
        do
        {
            l++;
        } while (l < s.Length && !char.IsLetterOrDigit(s[l]));

        do
        {
            r--;
        } while (r > -1 && !char.IsLetterOrDigit(s[r]));

        while (l <= r)
        {
            if (char.ToLower(s[r]) != char.ToLower(s[l]))
            {
                return false;
            }

            do
            {
                l++;
            } while (l < s.Length && !char.IsLetterOrDigit(s[l]));

            do
            {
                r--;
            } while (r > -1 && !char.IsLetterOrDigit(s[r]));
        }

        return true;
    }
}
