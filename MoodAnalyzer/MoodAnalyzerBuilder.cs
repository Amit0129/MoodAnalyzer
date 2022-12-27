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
                if (this.msg.Equals(string.Empty))
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.msg.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
