public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        if (s.Length is 0 or 1) return s.Length;

        var resultDict = new Dictionary<char, int>(28);
        var left = 0;
        var right = 0;
        var maxLength = 0;
        var currentLength = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (!resultDict.TryGetValue(s[i], out var value))
            {
                resultDict.Add(s[i], i);
                right = i;
            }
            else
            {
                if (value >= left)
                {
                    currentLength = right - left + 1;
                    maxLength = currentLength > maxLength ? currentLength : maxLength;
                    left = value + 1;
                }

                right = i;
                resultDict[s[i]] = i;
            }
        }

        currentLength = right - left + 1;
        return currentLength > maxLength ? currentLength : maxLength;
    }
}