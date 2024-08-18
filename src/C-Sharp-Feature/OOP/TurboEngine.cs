using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class TurboEngine : IEngine
    {
        public int CurrentSpeed { get; set; }
        public void Start()
        {
            CurrentSpeed = 100;
        }
    }
}
