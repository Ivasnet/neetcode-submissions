public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var el = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
            if (el.TryGetValue(nums[i], out var value))
            {
                el[nums[i]] = ++value;
            }
            else
            {
                el.Add(nums[i], 1);
            }

        return el.OrderByDescending(kvp => kvp.Value).Take(k).Select(p => p.Key).ToArray();
    }
}
