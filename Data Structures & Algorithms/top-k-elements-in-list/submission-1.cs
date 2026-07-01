public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
       Dictionary<int, int> count = new();

       foreach(var num in nums)
       {
            count[num] = count.GetValueOrDefault(num, 0) + 1;
       }

       List<int>[] buckets = new List<int>[nums.Length + 1];
       foreach(var kvp in count)
       {
            if(buckets[kvp.Value] == null)
                buckets[kvp.Value] = new List<int>();
            buckets[kvp.Value].Add(kvp.Key);
       }

       int[] result = new int[k];
       int idx = 0;

       for(int i = buckets.Length - 1; i >= 1 && idx < k; i--)
       {
            if (buckets[i] == null) continue;
            foreach(int n in buckets[i])
            {
                result[idx++] = n;
                if (idx == k) return result;
            }
       }
       return result;
    }
}
