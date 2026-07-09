public class MinStack {
    List<int> _stack;

    public MinStack() {
        _stack = new();
    }
    
    public void Push(int val) {
        _stack.Add(val);
    }
    
    public void Pop() {
        _stack.RemoveAt(_stack.Count-1);
    }
    
    public int Top() {
        return _stack[_stack.Count-1];
    }
    
    public int GetMin() {
        int myInfiniteValue = _stack[0];
        foreach(var num in _stack)
        {
            if (num < myInfiniteValue)
                myInfiniteValue = num;
        }
        return myInfiniteValue;
    }
}
