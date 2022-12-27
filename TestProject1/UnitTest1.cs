using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
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

    }
}