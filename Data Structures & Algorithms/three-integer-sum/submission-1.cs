public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        var dict = new Dictionary<int, HashSet<int>>();
        for (var i = 0; i < nums.Length; i++)
            if (dict.TryGetValue(nums[i], out var list))
                list.Add(i);
            else
                dict.Add(nums[i], [i]);

        var exists = new HashSet<(int, int, int)>();
        var result = new List<List<int>>();
        for (var i = 0; i < nums.Length - 1; i++)
        for (var j = i + 1; j < nums.Length; j++)
            if (dict.TryGetValue(-nums[i] - nums[j], out var positions))
                foreach (var pos in positions)
                    if (pos != i && pos != j && exists.Add(Sort(nums[i], nums[j], nums[pos])))
                        result.Add([nums[i], nums[j], nums[pos]]);

        return result;

        (int, int, int) Sort(int a, int b, int c)
        {
            if (a <= b && a <= c && c <= b) return (a, c, b);
            if (a <= b && a <= c && c > b) return (a, b, c);
            if (b <= a && b <= c && c > a) return (b, a, c);
            if (b <= a && b <= c && c <= a) return (b, c, a);
            if (c <= a && c <= b && b <= a) return (c, b, a);
            return (c, a, b);
        }
    }
}
