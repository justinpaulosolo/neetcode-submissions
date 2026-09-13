class Solution:
    def search(self, nums: List[int], target: int) -> int:
        length = len(nums)

        left, right = 0, length-1

        while (left <= right):
            mid = int((left + right) / 2)

            if target == nums[mid]:
                return int(mid)
            elif nums[mid] < target:
                left = mid + 1
            elif nums[mid] > target:
                right = mid - 1
        
        return -1
        