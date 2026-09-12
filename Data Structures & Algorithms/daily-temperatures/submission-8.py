class Solution:
    def dailyTemperatures(self, f: List[int]) -> List[int]:
        ans = [0]*len(f)
        stack = []

        for i, t in enumerate(f):
            while stack and t > stack[-1][0]:
                stackT, stackInd = stack.pop()
                ans[stackInd] = (i - stackInd)
            stack.append([t, i])
        return ans
        