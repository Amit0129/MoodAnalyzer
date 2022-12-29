using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //TC3.1
        public void Given_NULL_Mood_Should_Throw_MoodAnalyszerCustomException()
        {
            try
            {
                string message = null;
                MoodAnalyzerBuilder moodAnalyzer = new MoodAnalyzerBuilder(message);
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch(MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        [TestMethod]
        //TC3.2
        public void Given_Empyt_Mood_Should_Throw_MoodAnalyszerCustomException()
        {
            try
            {
                string message = "";
                MoodAnalyzerBuilder moodAnalyzer = new MoodAnalyzerBuilder(message);
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch(MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }

    }
}