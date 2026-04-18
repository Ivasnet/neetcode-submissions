public class Solution {
    public bool IsPalindrome(string s)
    {
        if (s.Length is 0 or 1) return true;

        var sl = s.ToLower();
        var l = -1;
        var r = sl.Length;
        do
        {
            l++;
        } while (l < sl.Length && (sl[l] < 48 || (sl[l] > 57 && sl[l] < 97) || sl[l] > 122));

        do
        {
            r--;
        } while (r > -1 && (sl[r] < 48 || (sl[r] > 57 && sl[r] < 97) || sl[r] > 122));

        while (l <= r)
        {
            if (sl[r] != sl[l]) return false;

            do
            {
                l++;
            } while (l < sl.Length && (sl[l] < 48 || (sl[l] > 57 && sl[l] < 97) || sl[l] > 122));

            do
            {
                r--;
            } while (r > -1 && (sl[r] < 48 || (sl[r] > 57 && sl[r] < 97) || sl[r] > 122));
        }

        return true;
    }
}
