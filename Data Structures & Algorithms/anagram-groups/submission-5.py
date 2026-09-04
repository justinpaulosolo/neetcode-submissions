class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        d = {}
        for index, value in enumerate(strs):
            key = [0] * 26
            for letter_index, letter in enumerate(value):
                key[ord(letter) - ord('a')] += 1

            keyStr = str(key)

            if keyStr in d:
                d[keyStr].append(value)
            else:
                d[keyStr] = [value]
        return list(d.values())
        