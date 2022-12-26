namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");

            MoodAnalyzerBuilder moodAnalyzerBuilder = new MoodAnalyzerBuilder("I am in a Any mood");
            Console.WriteLine(moodAnalyzerBuilder.AnalyseMood());
            MoodAnalyzerBuilder moodAnalyzerBuilder1 = new MoodAnalyzerBuilder("I am in a sad mood");
            Console.WriteLine(moodAnalyzerBuilder1.AnalyseMood());



        }
    }
}