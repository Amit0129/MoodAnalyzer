using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public  class MoodAnalyzerBuilder
    {
        public string  AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            if (message.ToUpper().Contains("GOOD"))
            {
                return "GOOD";
            }
            return null;
        }
    }
}
