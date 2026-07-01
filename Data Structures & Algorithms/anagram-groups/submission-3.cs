public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary <string, List<string>> dict = new();

        foreach(var s in strs)
        {
            var count = new int[26];
            foreach(var c in s)
            {
                count[c - 'a'] += 1;
            }

            string result = string.Join(",", count);

            if(dict.TryGetValue(result, out List<string> value))
            {
                value.Add(s);
            } else
            {
                dict.Add(result, [s]);
            }
        }
        return [..dict.Values];
    }
}
