using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    internal class PointWithConstraint<T, V>
        where T : class,  new()
        where V : struct
    {
        public T X { get; set; }
        public V Y { get; set; }

    }
}
