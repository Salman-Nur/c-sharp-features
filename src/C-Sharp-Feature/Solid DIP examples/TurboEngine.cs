using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_DIP_examples
{
    // high level module/class 
    internal class TurboEngine : IEngine   
    {
        public int CurrentSpeed { get; set; }
        public void Start()
        {
            CurrentSpeed = 100;
        }
    }


    //internal class TurboEngine 
    //{
    //    public int CurrentSpeed { get; set; }
    //    public void Start()
    //    {
    //        CurrentSpeed = 100;
    //    }
    //}
}
