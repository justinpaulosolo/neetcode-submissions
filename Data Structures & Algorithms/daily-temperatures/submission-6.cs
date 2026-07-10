public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] answer = new int[temperatures.Length];
        Stack<int[]> stack = new();
        for(int i = 0; i < temperatures.Length; i++)
        {
            var t = temperatures[i];
            while(stack.Count > 0 && t > stack.Peek()[0])
            {
                var pair = stack.Pop();
                answer[pair[1]] = i - pair[1];
            }
            stack.Push([t, i]);
        }
        return answer;
    }
}
