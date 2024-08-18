using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_LSP_examples
{
    internal class Clock : Product // is a Relation but We cannot inheritance cause it Break the LS design principle 
    {
        public DateTime Time { get; set; }

        // This clock is not for sale. Maybe it only for count the running time of the server. If we inheritance from Product,
        // its Price Property will show with the instance of Clock. But Clock doesn't have a property like this.
    }
}
