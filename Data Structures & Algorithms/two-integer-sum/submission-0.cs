public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var pair = target - nums[i];
            if (hash.ContainsKey(pair))
            {
                return [hash[pair], i];
            }
            
            hash.Add(nums[i], i);
        }

        return [0, 1];
    }
}
