using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_DIP_examples_2
{
    internal class SpaceShip
    {
        public double CurrentPower { get; set; }  
        public IEngine Engine { get; set; }
        public SpaceShip(IEngine engine)
        {
            Engine = engine;
        }

        public void InitializeEngine()
        {
            Engine.InitializeEngine();
        }
        public void BoostPower(int percentage)
        {
            CurrentPower += CurrentPower * ((double)percentage / 100);
        }
    }
}
