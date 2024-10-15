using ConsoleApps.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.Classes
{
    public class StackWithArray : ICustomStack
    {
        private int[] stack;
        private int top;
        private int maxSize;

        public StackWithArray(int size)
        {
            stack = new int[size];
            maxSize = size;
            top = -1;
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow! No elements to pop.");
                return -1;
            }
            int value = stack[top];
            top--;
            Console.WriteLine(value + " popped from stack.");
            return value;

        }

        public void Push(int pushingValue)
        {
            if (top == maxSize - 1)
            {
                // overflow
                Console.WriteLine("Stack overflow!");

            }
            top++;
            stack[top] = pushingValue;
            Console.WriteLine(pushingValue + " pushed onto stack.");
        }

        public void Display()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack elements:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
