using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Example of an interface in use
/// </summary>


namespace PracticeCSharp
{
    class RecyclingBin : Bin, IBin
    {
        public bool isEmpty = false;

        public RecyclingBin(string name, int size) : base(name, size)
        {

        }

        public string GetName()
        {
            return base.binName;
        }
      

        public void Empty()
        {
            isEmpty = true;
        }

        public bool IsEmpty()
        {
            return isEmpty;
        }
    }
}
