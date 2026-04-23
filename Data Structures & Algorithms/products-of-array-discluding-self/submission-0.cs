public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var allPow = 1;
        bool anyNull = false, moreOneNull = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) 
            {
                if (anyNull) moreOneNull = true;
                anyNull = true;
            }
            else allPow *= nums[i];
        }

        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (moreOneNull) result[i] = 0;
            else if (anyNull && nums[i] != 0) result[i] = 0;
            else if (nums[i] == 0) result[i] = allPow;
            else result[i] = allPow / nums[i];
        }

        return result;
    }
}