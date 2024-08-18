using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IndexerExample
{
    internal class Keyboard
    {


        // char value er jonne <------------------------------------------>
        private char[] _chars = new char[32];

        public char this[int index]
        {
            get
            {
                return _chars[index];
            }

            set
            {
                _chars[index] = value;
            }
        }



        // bool er jonne <----------------------------->
        //private bool[] x = new bool[10];

        //public bool this[int i]
        //{
        //    get
        //    {
        //        return x[i];
        //    }
        //    set
        //    {
        //        x[i] = value;
        //    }
        //}



        // double er jonne <------------------------->
        //private double[] arr = new double[33];

        //public double this[int index]
        //{
        //    get
        //    {
        //        return arr[index];
        //    }

        //    set
        //    {
        //        arr[index] = value;
        //    }
        //}





        //string value er jonne <---------------------------------------->
        //private string[] str = new string[3];

        //public string this[int index]
        //{
        //    get
        //    {
        //        return str[index];

        //    }
        //    set
        //    {
        //        str[index] = value;
        //    }
        //}



        



    }
}
