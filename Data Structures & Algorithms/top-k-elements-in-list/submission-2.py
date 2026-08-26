class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        my_dict = {}

        for num in nums:
            if my_dict.get(num):
                my_dict[num] += 1
            else:
                my_dict[num] = 1
        sorted_dict = dict(sorted(my_dict.items(), key=lambda item: item[1], reverse = True))

        return list(sorted_dict)[:k]
        