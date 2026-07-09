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
            if (pair == '[' || pair == '(' || pair == '{')
            {
                stack.Push(pair);
            }
            else
            {
                if(stack.Count == 0)
                    return false;
                var closing = stack.Pop();

                if (closing != dict[pair])
                    return false;
            }
        }
        return stack.Count == 0;
    }
}
