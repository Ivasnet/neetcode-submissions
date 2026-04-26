public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for (int i = 0; i < numbers.Length; i++)
        {
            var need = target - numbers[i];
            var left = 0;
            var right = numbers.Length - 1;
            if (need >= numbers[i])
            {
                left = i + 1;
            }
            else
            {
                right = i - 1;
            }

            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (numbers[mid] == need) return [i+1, mid+1];
                if (numbers[mid] > need) right = mid - 1;
                else left = mid + 1;
            }
        }

        return [0, 1];
    }
}
