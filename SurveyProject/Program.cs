using System;

namespace SurveyProject
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Survey survey = new Survey("My Survey");

            TextQuestion question1 = new TextQuestion { Label = "Where are you from?" };
            TextQuestion question2 = new TextQuestion { Label = "Where do you live?" };

            survey.AddQuestion(question1);
            survey.AddQuestion(question2);

            int surveyScore = survey.GetScore();
            
            Console.WriteLine($"Your score: {surveyScore}");
        }
    }
}
