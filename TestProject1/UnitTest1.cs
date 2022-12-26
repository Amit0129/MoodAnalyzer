using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyzerBuilder obj = new MoodAnalyzerBuilder(); //Arrange

            string result = obj.AnalyseMood("I am in Sad Mood");  //Act

            Assert.AreEqual("SAD", result);  //Assert
        }
    }
}