public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        var hashset = nums.ToHashSet();
        var hashsetStart = new HashSet<int>();
        for (var i = 0; i < hashset.Count; i++)
        {
            var el = hashset.ElementAt(i);
            if (!hashset.Contains(el - 1))
                hashsetStart.Add(el);
        }

        var maxLength = 0;
        var currentLength = 1;
        foreach (var el in hashsetStart)
        {
            var tmp = el;
            while (hashset.Contains(++tmp)) currentLength++;
            if (currentLength > maxLength) maxLength = currentLength;
            currentLength = 1;
        }

        return maxLength;
    }
}
