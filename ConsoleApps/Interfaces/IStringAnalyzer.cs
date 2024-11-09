using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.Interfaces
{
    public interface IStringAnalyzer
    {
        List<char> GetMostFrequentCharacter(string text, out int count);
    }
}
