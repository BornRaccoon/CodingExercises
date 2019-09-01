using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    abstract class Bin
    {
        protected string binName;
        protected int binSize;

        public Bin(string name, int size)
        {
            binName = name;
            binSize = size;
        }
       
    }
}
