using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_LSP_examples
{
    internal class Car : Product // this is right LSP implementation
    {
        public int Speed { get; set; }

    }
}
