using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public class DefaultPractice
    {
        private const string message = "I didn't specify a class name";

        public static void printClassName(string name = message)
        {
            Console.WriteLine(name);
        }
    }
}
