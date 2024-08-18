using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    internal class Scale<T> 
    {
        public T Weight { get; set; }
        public T MeasureWeight(object item)
        {
            return Weight * (dynamic)item;
        }
    }
}
