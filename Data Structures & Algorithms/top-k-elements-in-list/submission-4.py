class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        n = len(nums)
        count = [[] for _ in range(n+1)]
        freq = {}
        for num in nums:
            freq[num] = freq.get(num, 0) + 1

        for num, f in freq.items():
            count[f].append(num);

        answer = []
        for i in reversed(count):
                for j in i:
                    answer.append(j)
                    if len(answer) == k:
                        return answer

        return answer 