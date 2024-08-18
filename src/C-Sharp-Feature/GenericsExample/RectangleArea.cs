using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    internal class RectangleArea
    {
        public static T CalculateRectangleArea<T>(T width, T height)
        {
            return (dynamic)width * (dynamic)height;
        }


    }
}
