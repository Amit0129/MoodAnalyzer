using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class MoodAnalyzerBuilder
    {
        public string  AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "Sad Mood";
            }
            if (message.ToUpper().Contains("GOOD"))
            {
                return "Good Mood";
            }
            return null;
        }
    }
}
