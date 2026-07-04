public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length-1;

        while (left < right)
        {
            char lChar = char.ToLower(s[left]);
            char rChar = char.ToLower(s[right]);
            
            if (!char.IsLetterOrDigit(lChar))
            {
                left++;
                continue;
            }

            if (!char.IsLetterOrDigit(rChar))
            {
                right--;
                continue;
            }

            if(lChar != rChar)
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
