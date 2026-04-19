public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();
        for (var i = 0; i < strs.Length; i++)
        {
            var w = strs[i];
            var count = new char[26];

            for (var j = 0; j < w.Length; j++)
            {
                count[w[j]-'a']++;
            }

            var str = new string(count);
            if (result.TryGetValue(str, out var set))
            {
                set.Add(strs[i]);
            }
            else
            {
                result.Add(str, [strs[i]]);
            }
        }

        return result.Values.ToList();
    }
}
