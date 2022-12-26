using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null)]
        public void TestMethod1(string message)
        {
            string except = "HAPPY";
            MoodAnalyzerBuilder moodAnalyzerBuilder = new MoodAnalyzerBuilder(message);

            string mood = moodAnalyzerBuilder.AnalyseMood();

            Assert.AreEqual(except, mood);
            
        }
      
    }
}