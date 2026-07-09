public class DynamicArray {
    private int[] _arr;
    private int _count;
    private int _length;

    public DynamicArray(int capacity) {
        _length = capacity;
        _arr = new int[_length];
        _count = 0;
    }

    public int Get(int i) {
        return _arr[i];
    }

    public void Set(int i, int n) {
        _arr[i] = n;
    }

    public void PushBack(int n) {
        if (_count == _arr.Length)
        {
            this.Resize();
        }
        _arr[_count] = n;
        _count++;
    }

    public int PopBack() {
        var num = _arr[_count-1];
        _count--;
        return num;
    }

    private void Resize() {
        var temp = _arr;
        _length = _length*2;
        _arr = new int[_length];
        for(int i = 0; i < temp.Length; i++)
        {
            _arr[i] = temp[i];
        }
    }

    public int GetSize() {
        return _count;
    }

    public int GetCapacity() {
        return _length;
    }
}
