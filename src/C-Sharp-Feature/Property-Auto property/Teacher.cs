using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Auto_property
{
    internal class Teacher
    {
        private string id;

        public string Id
        {
            get { return id; }
            set 
            { 
                if (value.StartsWith("T-"))
                {
                    id = value;
                }
            }
        }

        public void GenerateNewId()
        {
            id = "T-" + DateTime.Now.Ticks;
        }



    }
}
