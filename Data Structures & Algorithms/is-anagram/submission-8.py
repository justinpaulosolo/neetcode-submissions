class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        
        dict, dict2 = {}, {}

        for i in range(len(s)):
            dict[s[i]] = 1 + dict.get(s[i], 0)
            dict2[t[i]] = 1 + dict2.get(t[i], 0)

        return dict == dict2

        

        