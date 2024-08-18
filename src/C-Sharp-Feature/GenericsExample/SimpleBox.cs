using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    internal class SimpleBox 
    {
        Item[] _item;             // akta private + T type er Array declare korlam
        int _index;
        public SimpleBox()            // akta constructor rakhlam
        {
            _index = 0;          // by default jdio 0 thakbe taw initialize korei rakhlam
            _item = new Item[100];  // _item k 100 diye initialize korlam
        }

        public SimpleBox(int size)      // r akta constructor thakuk jeitai kina size bole dite chai
        {
            _index = 0;
            _item = new Item[size];

        }

        public void Add(Item item)
        {
            if (_index < _item.Length)
                _item[_index++] = item;

        }


        public Item Get(int index)
        {
            if (index < _item.Length)
            {
                return _item[_index];
            }
            else
            {
                return null;
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
    }
}
