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

            string result = obj.AnalyseMood("I am in Happy Mood");  //Act

            Assert.AreEqual("HAPPY", result);  //Assert

        }
        [TestMethod]
        public void TestMethod2()
        {

            MoodAnalyzerBuilder obj = new MoodAnalyzerBuilder("I am in Happy Mood"); //Arrange

            string result = obj.AnalyseMood();  //Act

            Assert.AreEqual("SAD", result);  //Assert

        }
    }
}