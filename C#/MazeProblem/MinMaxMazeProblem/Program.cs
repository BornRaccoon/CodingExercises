using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1) Provided with any size MxN matrix.
/// 2) Find all the routes from top left square to bottom right:
///     ---------
///     | 8 | 3 | 
///     ---------   Potential routes (8-5-4 or 8-3-4)
///     | 5 | 4 | 
///     ---------
/// 3) Of those routes found, find the minimum value on each route. 
///    For the example above this would be: 4 and 3 respectively.
/// 4) Out of these minimum values find the maximum.
///    For the example above this would be: 4 (as 4 > 3).
///    
/// TODO: implement dynamic programming (memoization)
/// </summary>


namespace MinMaxMazeProblem
{
    public class Program
    {
        public static int displayPath(List<int> path, int last, int max)
        {
            int minimum = path[0];
            path.Add(last);
            foreach (int step in path)
            {
                if (step < minimum)
                    minimum = step;

                Console.Write(step + "\t");
            }
            Console.WriteLine();

            if (minimum > max)
                max = minimum;

            path.RemoveAt(path.Count - 1);
            return max;
        }

        //Recursive function
        public static int possiblePaths(int x, int y, int[,] m, int rowCount, int colCount, int max, List<int> path)
        {
            if (x == (rowCount - 1) && y == (colCount - 1))
            {
                max = displayPath(path, m[x,y], max);
                return max;
            }

            path.Add(m[x, y]);

            if ((x >= 0 && x < rowCount  && y + 1 >= 0 && y + 1 < colCount))
            {
                max = possiblePaths(x,y+1,m,rowCount,colCount,max,path);
            }

            if ((x + 1 >= 0 && x + 1 < rowCount && y >= 0 && y < colCount))
            {
                max = possiblePaths(x+1,y, m, rowCount, colCount,max,path);
            }

            path.RemoveAt(path.Count() - 1);
            return max;
        }

        static void Main(string[] args)
        {
            List<int> path = new List<int>();
            int currentMaximum = 0;
            int x = 0, y = 0;
            int rowCount = 0, colCount = 0;
            int[,] m = {   { 7, 11, 1 }, 
                           { 9, 2, 12 }, 
                           { 1, 43, 10 }};

            rowCount = m.GetLength(0);
            colCount = m.GetLength(1);
            currentMaximum = possiblePaths(x, y, m, rowCount, colCount, currentMaximum, path);
            Console.WriteLine("Maximum of the minimums: " + currentMaximum);
            Console.ReadKey(); 
        }
    }
}
