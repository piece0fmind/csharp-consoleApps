
using ConsoleApps.Classes;
using ConsoleApps.Interfaces;
Console.WriteLine("Stack operations with array");

ICustomStack stack = new StackWithArray(5);

// Perform stack operations

stack.Push(10);
stack.Push(20);
stack.Display();

stack.Pop();
stack.Display();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

Console.WriteLine("Stack operations with list");
ICustomStack listStack = new StackWithList();  

// Perform stack operations
listStack.Push(10);
listStack.Push(20);
listStack.Display();

listStack.Pop();
listStack.Display();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();