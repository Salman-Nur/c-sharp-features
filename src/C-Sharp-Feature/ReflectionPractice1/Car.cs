using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractice1
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public void Start()
        {
            Speed = 100;
        }
        public void IncreaseSpeed()
        {
            Speed += 10;
        }
        public void Stop()
        {
            Speed= 0;
        }
    }
}
