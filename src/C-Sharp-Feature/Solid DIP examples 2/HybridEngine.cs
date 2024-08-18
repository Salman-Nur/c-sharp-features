using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_DIP_examples_2
{
    internal class HybridEngine : IEngine
    {
        public int InitializedPower { get; set; }

        public void InitializeEngine()
        {
            InitializedPower = 1000;
        }
    }
}
