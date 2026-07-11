public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pairs = new int[position.Length][];
        for(int i = 0; i < position.Length; i++)
        {
            pairs[i] = [position[i],speed[i]];
        }

        Array.Sort(pairs, (a, b) => b[0].CompareTo(a[0]));

        Stack<double> stack = new();
        foreach(var p in pairs)
        {
            stack.Push((double)(target-p[0])/p[1]);

            if(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) {
                stack.Pop();
            }
        }
        return stack.Count;
    }
}
