using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_DIP_examples
{
    // low level module/class 
    internal class ElectricEngine : IEngine
    {
        public int CurrentSpeed { get; set; }
        public void Start()
        {
            CurrentSpeed = 200;
        }

    }
}
