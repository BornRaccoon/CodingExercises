using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public class FormHandler
    {
        public FormHandler()
        {
            Program.FormSubmitted += Submit;
        }

        private void Submit()
        {
            Console.WriteLine("Form has been submitted!");
        }

    }
}
