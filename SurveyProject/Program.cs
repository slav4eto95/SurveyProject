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

            var Score = survey.GetScore();

            /*survey.AddQuestion(question1);
            survey.AddQuestion(question2);*/

            Console.WriteLine(survey.Title);
            Console.WriteLine($"Your score: {Score}");
        }
    }
}
