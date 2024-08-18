using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    internal  class Math
    {
        public int Sum(params int[] array)
        {
            int result = 0;
            for(int i = 0; i < array.Length; i++)
            {
                result+= array[i];
            }
            return result;
        }

        public void ChangeValue(out int value)
        {
            value = 1000;
        }
        
    }
}
