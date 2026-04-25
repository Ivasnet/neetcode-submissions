public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        var hashset = nums.ToHashSet();
        var maxLength = 0;
        var currentLength = 1;

        foreach (var el in hashset)
            if (!hashset.Contains(el - 1))
            {
                var tmp = el;
                while (hashset.Contains(++tmp)) currentLength++;
                if (currentLength > maxLength) maxLength = currentLength;
                currentLength = 1;
            }

        return maxLength;
    }
}
