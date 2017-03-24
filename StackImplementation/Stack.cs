using System;
using System.Collections;

namespace StackImplementation
{
    public class Stack
    {
        private readonly ArrayList _list = new ArrayList();
        private int _index = -1;

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Null can not be pushed to Stack");
            }
            _list.Add(obj);
            _index++;
        }

        public object Pop()
        {
            if (_index == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            var top = _list[_index];
            _list.RemoveAt(_index);
            _index--;
            return top;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public ArrayList ViewStack()
        {
            return _list;
        }
    }
}