namespace SurveyProject
{
    public class TextQuestion : Question
    {
        protected override Answer CreateAnswer(string input)
        {
            return new TextAnswer { Text = input, Score = input.Length };
        }
    }
}
