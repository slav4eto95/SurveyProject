using System.Collections.Generic;

namespace SurveyProject
{
    public class Survey
    {
        public string Title { get; set; }

        public List<Question> Questions { get; private set; }

        public Survey(string title)
        {
            Title = title;

            Questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public int GetScore()
        {
            int total = 0;
            foreach (var question in Questions)
            {
                Answer answer = question.Ask();
                total = total + answer.Score;
            }
            return total;
        }
    }
}
