using System.Xml.Serialization;

namespace ConsoleApps.Interfaces
{
    public interface ICustomStack
    {
        void Push(int value);
        int Pop();
        void Display();

    }
}
