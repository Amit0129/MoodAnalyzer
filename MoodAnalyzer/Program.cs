﻿namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");

            MoodAnalyzerBuilder obj = new MoodAnalyzerBuilder("");
            Console.WriteLine(obj.AnalyseMood());
        }
    }
}