public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);

        if (nums.Length != set.Count)
            return true;

        return false;
    }
}