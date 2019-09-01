using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public class Stack
    {
        private int[] stack;
        private int rear;
        private int max;
        
        public Stack()
        {
            max = 10;
            stack = new int[max];
            rear = 0;
        }

        public bool isEmpty()
        {
            return (rear == 0);
        }

        public bool isFull()
        {
            return (rear == max - 1);
        }

        public void push(int value)
        {
            if (isFull())
                Console.WriteLine("Stack full");
            else
            {
                stack[rear] = value;
                rear++;
            }
        }

        public int pop()
        {
            int returnValue = stack[rear];
            rear--;
            return returnValue;
        }

        public void print()
        {
            for (int digit = rear - 1; digit >= 0; digit--)
            {
                Console.WriteLine(stack[digit]);
            }
        }

    }
}
