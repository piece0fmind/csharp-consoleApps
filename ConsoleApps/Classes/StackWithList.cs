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

        public void Display()
        {
            if (!stack.Any())
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
            if (!stack.Any())
            {
                Console.WriteLine("The stack is empty.");
                return -1;
            }
            int value = stack[stack.Count - 1];
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
