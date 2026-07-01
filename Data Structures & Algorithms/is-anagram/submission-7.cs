public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;
            
        Dictionary<int, int> dict = new();

        foreach(var c in s)
        {
            dict[c] = dict.GetValueOrDefault(c, 0) + 1;
        }

        foreach(var c in t)
        {
            var value = dict.GetValueOrDefault(c, 0) - 1;

            if (value < 0) 
                return false;
            dict[c] = value;
        }
        return true;
    }
}
