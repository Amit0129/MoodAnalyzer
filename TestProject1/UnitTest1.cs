using MoodAnalyzer;
using Newtonsoft.Json.Linq;
using System.Security.Claims;

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
            catch (MoodAnalyszerCustomException e)
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
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
        //TC4.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyzerBuilder(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuilder");
            expected.Equals(obj);
            //Assert.AreEqual(expected,obj);

        }
        //TC4.2
        [TestMethod]
        public void GivenClassNameWhenImproper_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object objFactory = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyzerBuildera", "MoodAnalyzerBuildera");
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }

        }
        //TC4.3
        [TestMethod]
        public void GivenClassWhenConstructorNotProperShouldThrowException()
        {
            try
            {
                object objFactory = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuildera");
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Constructor is not found", e.Message);
            }

        }
        //TC5.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyzerBuilder("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuilder","SAD");
            expected.Equals(obj);
            //Assert.AreEqual(expected,obj);
        }
        //TC5.2
        [TestMethod]
        public void GivenClassNameWhenImproper_ShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            try
            {
                object objFactory = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyzerBuildera", "MoodAnalyzerBuildera","SAD");
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }

        }
        //TC5.3
        [TestMethod]
        public void GivenClassWhenConstructorNotProperShouldThrowException_UsingParameterizedConstructor()
        {
            try
            {
                object objFactory = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuildera", "SAD");
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Constructor is not found", e.Message);
            }
        }
        //TC6.1
        [TestMethod]
        public void InvokeMethod_GivenHappy_ReturnHappy()
        {
            string expected = "HAPPY";
            string actual = MoodAnalyserFactory.InvokeMethod("AnalyseMood", "HAPPY");
            Assert.AreEqual(expected, actual);
        }
        //6.2
        [TestMethod]
        public void InvokeMethod_GivenImproperMethod_ReturnException()
        {
            try
            {
                object obj = MoodAnalyserFactory.InvokeMethod("Analysemood", "HAPPY");
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Method is not found", e.Message);
            }
        }
        // TC-7.1
        [TestMethod]
        public void ChangeMoodDynamically_GivenHappy_ReturnHappy()
        {
            string expected = "HAPPY";
            string actual = MoodAnalyserFactory.ChangeMoodDynamically("message","HAPPY");
            Assert.AreEqual(expected, actual);
        }
        // TC-7.2
        [TestMethod]
        public void ChangeMoodDynamically_GivenImproperField_ReturnException()
        {
            try
            {
                string except = MoodAnalyserFactory.ChangeMoodDynamically("cool", "HAPPY");
            }
            catch(MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Field is not found", e.Message);
            }
        }
    }
}
