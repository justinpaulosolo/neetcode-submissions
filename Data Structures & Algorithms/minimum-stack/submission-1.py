class MinStack:

    def __init__(self):
        self._stack = []
        self._minStack = []

    def push(self, val: int) -> None:
        if len(self._minStack) == 0:
            self._minStack.append(val)
            self._stack.append(val)
        else:
            self._minStack.append(min(val, self._minStack[-1]))
            self._stack.append(val)
            

    def pop(self) -> None:
        self._stack.pop()
        self._minStack.pop()
        

    def top(self) -> int:
        return self._stack[-1]
        

    def getMin(self) -> int:
        return self._minStack[-1]
        
