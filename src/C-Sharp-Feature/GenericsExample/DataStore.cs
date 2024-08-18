using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class DataStore<T>
    {
        public T Data { get; set; }
        public T[] arr = new T[10];   // generics arr


        // generics methods
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }





    }

    public class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }




    // a non generic class can contain generic methods
    public class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);


        }
    }




    //
    class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }

    }
}
