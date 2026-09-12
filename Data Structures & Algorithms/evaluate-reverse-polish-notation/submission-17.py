class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack = []

        for token in tokens:
            if token == "+":
                b = stack.pop()
                a = stack.pop()
                stack.append(a+b)
            elif token == "*":
                b = stack.pop()
                a = stack.pop()
                stack.append(int(a*b))
            elif token == "-":
                b = stack.pop()
                a = stack.pop()
                stack.append(a-b)
            elif token == "/":
                b = stack.pop()
                a = stack.pop()
                result = a / b if b != 0 else 0
                stack.append(int(a/b))
            else:
                stack.append(int(token))

        return stack.pop()
        