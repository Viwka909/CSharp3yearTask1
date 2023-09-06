using System;

public class IntArrayList
{
    int[] _container;
    int _count;
    int _buff;
    readonly int true_buff = 2;

    public IntArrayList()
    {
        _container = new int[true_buff];
        _buff = _container.Length;
    }
    public IntArrayList(int count)
    {
        _container = new int[count];
        _buff = _container.Length;
    }
    public IntArrayList(int[] container)
    {
        _container = container;
        _buff = _container.Length;
    }

    public int Count
    {
        get => _count;
    }
    public int Capacity
    {
        get => _buff;
    }
    public int GetFrom_buff(int index)
    {
        return _container[index];
    }
    public void PushBack(int value)
    {
        if (_count >= _buff)
        {
            _buff *= 2;
            int[] _newcontainer = new int[_buff];
            for (int i = 0; i < _buff; i++)
            {
                _newcontainer[i] = _container[i];
            }
            _container = _newcontainer;

        }
        _container[_count] = value;
        _count++;
    }
    public void PopBack()
    {
        if (_count >= 1)
        {
            _container[_count] = 0;
            _count--;
        }
    }
    public bool TryInsert(int index, int value)
    {
        if (index <= _count)
        {
            _container[index] = value;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool TryErase(int index)
    {
        if (index <= _count && index >= 0)
        {
            _container[index] = 0;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool TryGetAt(int index, out int result)
    {
        if (index <= _buff && index >= 0)
        {
            result = _container[index];
            return true;
        }
        else
        {
            result = 0;
            return false;
        }
    }
    public void Clear()
    {
        for (int i = 0; i < _count; i++)
        {
            _container[i] = 0;
        }
    }
    public bool TryForceCapacity(int NewCapacity)
    {
        if (NewCapacity >= 0)
        {
            _buff = NewCapacity;
            int[] _newcontainer = new int[_buff];
            for (int i = 0; i < _buff; i++)
            {
                _newcontainer[i] = _container[i];
            }
            _container = _newcontainer;
            return true;
        }
        else
        {
            return false;
        }
    }
    public int Find(int value){
        for (int i = 0; i < _buff; i++)
            {
                if (_container[i] == value)
                {
                    return i;
                }
            }
            return -1;
    }

}