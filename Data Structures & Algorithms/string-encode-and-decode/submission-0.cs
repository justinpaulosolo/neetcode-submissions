public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(var s in strs)
        {
            var length = s.Length;
            var newString = length.ToString() + "#" + s;
            sb.Append(newString);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> strings = new();

        int idx = 0;

        while (idx < s.Length)
        {
            var delimeterIdx = s.IndexOf('#', idx);
            var length = s.Substring(idx, delimeterIdx-idx);
            var str = s.Substring(delimeterIdx + 1, int.Parse(length));
            strings.Add(str);
            idx = int.Parse(length)+delimeterIdx+1;
        }
        return strings;
   }
}
