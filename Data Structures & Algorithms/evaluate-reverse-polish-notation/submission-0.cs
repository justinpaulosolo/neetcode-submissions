public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new();

        for(int i = 0; i < tokens.Length; i++)
        {
            var token = tokens[i];

            switch(token)
            {
                case "+":
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                    stack.Push(second+first);
                    break;
                }
                case "-":
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                    stack.Push(second-first);
                    break;
                }
                case "*":
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                    stack.Push(second*first);
                    break;
                }
                case "/":
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                    stack.Push(second/first);
                    break;
                }
                default:
                {
                    stack.Push(int.Parse(token));
                    break;
                }
            }

        }
        return stack.Pop();
    }
}
