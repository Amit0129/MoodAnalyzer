namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");

            MoodAnalyzerBuilder moodAnalyzerBuilder = new MoodAnalyzerBuilder();
            
            Console.WriteLine(moodAnalyzerBuilder.AnalyseMood("I am in a good mood"));
            Console.WriteLine(moodAnalyzerBuilder.AnalyseMood("I am in a sad mood"));
        }
    }
}