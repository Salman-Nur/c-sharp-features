using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_DIP_examples
{
    internal class Car   // high level module/class
    {
        public IEngine Engine { get; set; }
        public int Speed { get; set; }


        public Car(IEngine engine)
        {
            Engine = engine;
        }
        public void Start()
        {
            Engine.Start();
        }

        public void IncreaseSpeed(int speed)
        {
            Speed += speed;
        }
    }



    //internal class Car : TurboEngine 
    //{
    //    public int Speed { get; set; }
    //    public TurboEngine turbo = new TurboEngine();

    //    public void Start(TurboEngine turboEngine)
    //    {
    //        turbo = turboEngine;
    //    }

    //    public void IncreaseSpeed(int speed)
    //    {
    //        Speed += speed;
    //    }
    //}
}
