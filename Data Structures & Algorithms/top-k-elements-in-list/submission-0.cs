public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new();

        foreach(int num in nums)
        {
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(var kvp in dict)
        {
            if (buckets[kvp.Value] == null)
                buckets[kvp.Value] = new List<int>();
            buckets[kvp.Value].Add(kvp.Key);
        }

        List<int> result = new();
        for(int i = buckets.Length - 1; i >= 1 && result.Count < k; i--)
        {
            if(buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }
        return result.Take(k).ToArray();
    }
}
