using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    ///internal class Point
    //{
    //    public object X { get; set; }
    //    public object Y { get; set; }
    //}


    /// IF we want to keep the item same type
    //internal class Point<T>
    //{
    //    public T X { get; set; }
    //    public T Y { get; set; }
    //}



    internal class Point<T, V>
    {
        public T X { get; set; }
        public V Y { get; set; }
    }

    internal class PointFInal<T> 
    {
        public T X { get; set; }
        public T Y { get; set; }


        public PointFInal<T> Sum(T x, T y)
        {
            var newItem = new PointFInal<T>();
            newItem.X = x;
            newItem.Y = y;
            // Error : T result = newItem.X + newItem.Y;
            return newItem;

        }
    }



}
