using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public static class ExtensionMethods
    {
        public static string toStars(this int value)
        {
            StringBuilder sb = new StringBuilder();

            while (value > 0)
            {
                sb.Append("*");
                value--;
            }
            return sb.ToString();
        }
    }
}
