using ConsoleApps.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.Utility
{
    public static class StackUtils
    {
        public static void PerformStackOperations(ICustomStack stack)
        {
            Console.WriteLine($"Performing operations on stack of type: {stack.GetType().Name}");

            stack.Push(10);
            stack.Display();

            stack.Pop();
            stack.Display();
        }
    }
}
