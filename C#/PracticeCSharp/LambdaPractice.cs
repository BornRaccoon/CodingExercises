using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class LambdaPractice
    {

        public static bool CheckFunction(RecyclingBin myBin)
        {
            return (myBin.GetName() == "Garage");
        }


    }
}
