public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();

        for(int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if (dict.ContainsKey(complement))
            {
                return [dict[complement], i];
            }
            dict[nums[i]] = i;
        }
        return [];
    }
}
