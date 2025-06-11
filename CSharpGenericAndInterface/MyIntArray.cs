using System;
using System.Collections.Generic;
using System.Linq;


namespace CSharpGenericAndInterface
{

    public class MyIntArray
    {
        private int[] _items;
        private int _count;

        public int this[int index]
        {
            get
            {
                if(index<0 || index >= _count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return _items[index];
                }
            }

            set
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    _items[index] = value;
                }
            }
        }

        public MyIntArray(int capacity = 10)
        {
            _items = new int[capacity];
            _count = 0;
        }

        public void Add(int item)
        {
            if (_count >= _items.Length)
            {
                Resize();
            }
            _items[_count++] = item;
        }

        private void Resize()
        {
            int[] newArray = new int[_items.Length * 2];
            for (int i = 0; i < _items.Length; i++)
            {
                newArray[i] = _items[i];
            }
            _items = newArray;
        }

        public void PrintAll()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }

        public void Sort()
        {
            // 冒泡排序
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = 0; j < _count - i - 1; j++)
                {
                    if (_items[j] > (_items[j + 1]))
                    {
                        (_items[j], _items[j + 1]) = (_items[j + 1], _items[j]);
                    }
                }
            }
        }


    }

}
