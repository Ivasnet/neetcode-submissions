public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var hashS = new Dictionary<char, int>();
        var hashT = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            if (hashS.ContainsKey(s[i]))
            {
                hashS[s[i]]++;
            }
            else
            {
                hashS.Add(s[i], 0);
            }

            if (hashT.ContainsKey(t[i]))
            {
                hashT[t[i]]++;
            }
            else
            {
                hashT.Add(t[i], 0);
            }
        }

        foreach (var i in hashS)
        {
            if (!hashT.TryGetValue(i.Key, out var val) || val != i.Value)
            {
                return false;
            }
        }

        return true;
    }
}
