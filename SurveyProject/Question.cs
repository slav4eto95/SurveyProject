using System;

namespace SurveyProject
{
    public abstract class Question
    {
        public string Label { get; set; }

        protected abstract Answer CreateAnswer(string input);

        protected virtual void PrintQuestion()
        {
            Console.WriteLine(Label);
        }

        public Answer Ask()
        {
            PrintQuestion();

            string input = Console.ReadLine();

            return CreateAnswer(input);
        }
    }
}
