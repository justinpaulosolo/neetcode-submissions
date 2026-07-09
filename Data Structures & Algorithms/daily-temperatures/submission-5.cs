public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] answer = new int[temperatures.Length];;
        int counter = 0;
        for(int i = 0; i < temperatures.Length; i++)
        {
            counter = 0;
            for(int j = i+1; j < temperatures.Length; j++)
            {
                counter++;
                if (temperatures[j]>temperatures[i])
                {
                    answer[i] = counter;
                    counter = 0;
                    break;
                }
        
            }
        }
        return answer;
    }
}
