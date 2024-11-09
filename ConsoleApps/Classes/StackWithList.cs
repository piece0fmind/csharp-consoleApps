using BenchmarkDotNet.Attributes;
using ConsoleApps.Interfaces;

namespace ConsoleApps.Classes
{
    public class StackWithList : ICustomStack
    {
        private List<int> stack;

        public StackWithList()
        {
            stack = new List<int>();
        }

        [Benchmark]
        public void Display()
        {
            stack = new List<int>();
            /*if (stack is null)
            {
                Console.WriteLine("Stack is empty.");
            }*/
            if (stack.Count == 0)
            {
                Console.WriteLine("Null");
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("The stack is empty.");
            }
            foreach (var item in stack)
            {
                Console.WriteLine($"{item}");
            }
        }

        public int Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("The stack is empty.");
                return -1;
            }
            int value = stack[index: stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            Console.WriteLine(value + " popped from stack.");
            return value;

        }

        public void Push(int value)
        {
            stack.Add(value);
            Console.WriteLine(value + " pushed onto stack.");
        }
    }
}
