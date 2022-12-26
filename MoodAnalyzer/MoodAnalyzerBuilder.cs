using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public  class MoodAnalyzerBuilder
    {
        string msg;
        

        public MoodAnalyzerBuilder(string msg)
        {
            this.msg = msg;
        }
        
        
        public string AnalyseMood()
        {
            try
            {
                if (this.msg.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
