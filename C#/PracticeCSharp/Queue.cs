using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public class Queue
    {
        private int[] queue;
        private int max;
        private int rear;
        private int start;
        public Queue()
        {
            max = 10;
            rear = -1;
            start = 0;
            queue = new int[max];
        }

        public int dequeue()
        {
            int temp = queue[start];
            start++;
            return temp;
        }

        public void enqueue(int value)
        {
            rear++;
            queue[rear] = value;
        }

        public void print()
        {
            for (int i = start; i <= rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }

    }
}
