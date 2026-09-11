class Solution:
    def isValid(self, s: str) -> bool:
        if len(s) == 1:
            return False

        stack = []

        dict = {
            "[" : "]",
            "(" : ")",
            "{" : "}",
        }

        for bracket in s:
            if bracket in dict:
                stack.append(bracket)
            else:
                if len(stack) == 0:
                    return False
                
                curr = stack[-1]
                if bracket == dict[curr]:
                    stack.pop()
                else:
                    return False

        if len(stack) != 0:
            return False
        else:
            return True