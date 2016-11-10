using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.KK.StackQueue
{
    public class Stack
    {

        int[] _items;

        private  int Top { get; set; }

        int _size;

        public Stack()
        {
            _items = new int[0];
        }

        public void Push(int item)
        {
            if(_size==_items.Length)
            {
                _size = _size == 0 ? 4 : _size * 2;

                int[] _newArray = new int[_size];

                _items.CopyTo(_newArray, 0);
                _size = _items.Length;
                _items = _newArray;
                _items[_size] = item;
                _size++;
            }
            else
            {
                _items[_size] = item;
                _size++;
            }

        }
        public int Pop()
        {
            int value = 0;
            if(_size>=0)
            {
                value = _items[_size-1];
                _items[_size-1] = 0;
                _size--;
                return value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range exception");
            }

        }

        public int Peek()
        {
            if (_size >= 0)
            {
                return _items[_size];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range exception");
            }
        }

        public int Length
        {
            get
            {
                return _size;
            }
        }

    }
}
