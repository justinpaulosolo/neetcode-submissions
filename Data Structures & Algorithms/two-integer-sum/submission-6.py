class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        pmap = {}
        for i, num in enumerate(nums):
            diff = target - num
            if diff in pmap:
                return [pmap[diff], i]
            pmap[num] = i


        