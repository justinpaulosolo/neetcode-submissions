public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int len = nums.Length;

        List<List<int>> answer = new ();
        HashSet<string> seen = new();
        Array.Sort(nums);
        int idx = 0;
        while (idx <= nums.Length-1)
        {
            int left  = idx + 1;
            int right = len - 1;
            while (left < right)
            {
                var target = nums[idx];
                var add = target + nums[left] + nums[right];
                if (add == 0)
                {
                    var key = string.Join(",", new[] { target, nums[left], nums[right] }.OrderBy(x => x));
                    if (seen.Add(key)) // returns false if already present
                    {
                        answer.Add([target, nums[left], nums[right]]);
                    }
                }

                if (add < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            idx++;
        }

        return answer;
    }
}
