using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    internal class Box<T>
        where T : Item
    {
        T[] _item;             // akta private + T type er Array declare korlam
        int _index;
        public Box()            // akta constructor rakhlam
        {
            _index = 0;          // by default jdio 0 thakbe taw initialize korei rakhlam
            _item = new T[100];  // _item k 100 diye initialize korlam
        }

        public Box(int size)      // r akta constructor thakuk jeitai kina size bole dite chai
        {
            _index = 0;
            _item = new T[size];

        }

        public void Add(T item)
        {
            if (_index < _item.Length)
                _item[_index++] = item;

        }

        public T Get(int index)
        {
            if (index < _item.Length)
            {
                return _item[_index];
            }
            else
            {
                return default(T);
            }

        }

        public void Clear()
        {
            _index = 0;
            for (int i = 0; i < _item.Length; i++)
            {
                _item[i] = null;
            }
        }



        // method e generic 
        public K GetItems<K>() 
            where K : ICollection<T> , new()
        {
            var items = new K();
            foreach (var item in _item)
            {
                items.Add(item);

            }
            return items;


        }


    }
}
