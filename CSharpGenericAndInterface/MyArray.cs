using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericAndInterface
{

    public class MyArray<T> where T : IMyComparable<T>
    {
        private T[] _items;
        private int _count;

        public MyArray(int capacity = 10)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count >= _items.Length)
            {
                Resize();
            }
            _items[_count++] = item;
        }

        private void Resize()
        {
            T[] newArray = new T[_items.Length * 2];
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
                    if (_items[j].CompareTo(_items[j + 1]) > 0)
                    {
                        (_items[j], _items[j + 1]) = (_items[j + 1], _items[j]);

                    }
                }
            }
        }
      
    }

}
