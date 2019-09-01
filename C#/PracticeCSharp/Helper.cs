using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public class Helper
    {
        public void FiveOut(out int myValue)
        {
            myValue = 5;                    
        }

        public void AddFiveRef(ref int myValue)
        {
            int b = myValue + 5;
            myValue = b;
        }
    }
}
