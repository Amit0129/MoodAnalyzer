using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static MoodAnalyzer.MoodAnalyszerCustomException;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        //UC4
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {

                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");

                }


            }
            else
            {
                throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
        //UC5
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyzerBuilder);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
            }
        }
        //UC6
        public static string InvokeMethod(string methodName, string message)
        {
            Type type = typeof(MoodAnalyzerBuilder);
            try
            {
                object methodObject = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuilder", message);
                MethodInfo methodInfo = type.GetMethod(methodName);
                if (methodInfo == null)
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_METHOD, "Method is not found");
                }
                string method = (string)methodInfo.Invoke(methodObject, null);
                return method;
            }
            catch (MoodAnalyszerCustomException ex)
            {
                return ex.Message;
            }
        }
        //UC7
        public static string ChangeMoodDynamically(string variableName, string setValue)
        {
            MoodAnalyzerBuilder objMood = new MoodAnalyzerBuilder();
            Type type = typeof(MoodAnalyzerBuilder);
            try
            {
                PropertyInfo propertyInfo = type.GetProperty("message");
                propertyInfo.SetValue(objMood, setValue);
                if (setValue == null)
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
                }
                if (propertyInfo == null)
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_FIELD, "Field is not found");
                   
                }
                return objMood.message;
            }
            catch (MoodAnalyszerCustomException ex)
            {
                return ex.Message;
            }
        }
    }
}