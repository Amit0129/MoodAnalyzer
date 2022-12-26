using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public  class MoodAnalyzerBuilder
    {
        string msg;
        public MoodAnalyzerBuilder() { }

        public MoodAnalyzerBuilder(string msg)
        {
            this.msg = msg;
        }
        public string  AnalyseMood()
        {
            if (this.msg.Contains("Sad", StringComparison.OrdinalIgnoreCase))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
            return null;
        }
    }
}
