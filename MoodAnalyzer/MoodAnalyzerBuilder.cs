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
        public string message;


        public MoodAnalyzerBuilder(string message)
        {
            this.message = message;
        }
        public MoodAnalyzerBuilder()
        {
        }
        public string AnalyseMood()
        {
            
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
