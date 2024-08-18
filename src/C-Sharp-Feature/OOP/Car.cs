using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car 
    {
        public IEngine Engine { get; set; }
        public Wheel[] wheels { get; set; }
        public int Speed { get; set; }  
        public Car(IEngine engine)
        {
            Engine = engine;
            wheels = new Wheel[4];
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
}
