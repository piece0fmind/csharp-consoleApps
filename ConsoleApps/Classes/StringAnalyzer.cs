using ConsoleApps.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.Classes
{
    public class StringAnalyzer : IStringAnalyzer
    {
        /// <summary>
        /// Analyzes the provided text and returns the most frequent character,
        /// ignoring spaces. Outputs the character count as an out parameter.
        /// </summary>
        /// <param name="text">The input text to analyze.</param>
        /// <param name="count">Outputs the frequency of the most frequent character.</param>
        /// <returns>The most frequent character in the text.</returns>
        public List<char> GetMostFrequentCharacter(string text, out int count)
        {
            // Define a dictionary that holds character and its count
            var charCounts = new Dictionary<char, int>();
            // Iterate through the text
            foreach (char c in text) 
            {
                if(c == ' ')
                {
                    continue;
                }
                // If the dictionary contains the char, increment the count
                // Else, insert the character and set count = 1

                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }
            var mostFrequentChar = '\0';
            var mostFrequentChars = new List<char>();
            var maxCount = 0;

            foreach (var pair in charCounts)
            {
                if(pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostFrequentChar = pair.Key;
                    mostFrequentChars.Add(pair.Key);
                }
            }
            count = maxCount;
            return mostFrequentChars;
        }
    }
}
