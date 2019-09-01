using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public class BinarySearch
    {
        int[] array;
        public BinarySearch(int[] values)
        {
            array = values;
        }

        public int search(int value)
        {
     
            int max = array.Length - 1;
            int min = 0;
            int start = 0;

            while (max >= 0 && min <= array.Length)
            {
                start = Math.Abs((max + min)/2);

                if (array[start] == value)
                {
                    return start;
                }
                else if (array[start] > value)
                {
                    max = max - start;                   
                } else
                {
                    min = min + start;
                }
            }

            return 0;
        }
    }
}
