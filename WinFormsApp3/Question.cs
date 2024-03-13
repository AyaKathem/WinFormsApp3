namespace Labb3_NET22.DataModels;

public class Question
{
    public string Statement { get; }
    public string[] Answers { get; }
    public int CorrectAnswer { get; }

    public Question(string statement, int correctAnswer, string[] answers)
    {
        Statement = statement;
        Answers = answers;
        CorrectAnswer = correctAnswer;
    }
}