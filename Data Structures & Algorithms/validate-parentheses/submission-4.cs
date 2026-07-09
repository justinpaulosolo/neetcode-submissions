public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;
        Dictionary<char, char> dict = new();
        Stack<char> stack = new();

        dict.Add(']', '[');
        dict.Add(')', '(');
        dict.Add('}', '{');

        foreach(var pair in s)
        {
            if (dict.ContainsKey(pair))
            {
                if (stack.Count > 0 && stack.Peek() == dict[pair])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(pair);
            }
        }
        return stack.Count == 0;
    }
}
