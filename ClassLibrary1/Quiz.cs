using Labb3_NET22.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;


public class Quiz
{
    private IEnumerable<Question> _questions;
    private string _title = string.Empty;
    public IEnumerable<Question> Questions => _questions;
    public string Title => _title;
    private string jsonFilePath = "quiz.json";

    public Quiz()
    {
        _questions = new List<Question>();
    }

    public Question GetRandomQuestion()
    {
        string jsonS = File.ReadAllText("quiz.json");

        _questions = JsonSerializer.Deserialize<List<Question>>(jsonS);

        Random RandIndex = new Random();
        int Index = RandIndex.Next(0, _questions.Count());

        return Questions.ElementAt(Index);


    }
    private void LoadQuiz()
    {

        string jsonS = File.ReadAllText("quiz.json");
        _questions = JsonSerializer.Deserialize<List<Question>>(jsonS);

    }
    
    public void AddQuestion(string statement, int correctAnswer, params string[] answers)
    {
        Question q = new Question(statement, correctAnswer, answers);
        _questions = Questions.Concat(new List<Question> { q });
        List<Question> questionList = _questions.ToList();

        // Serialize the list of questions to JSON
        string jsonString = JsonSerializer.Serialize(questionList);

        // Write the JSON data to a file
        File.WriteAllText(jsonFilePath, jsonString);

        Console.WriteLine("JSON file created successfully."); 
    }

    public void RemoveQuestion(int index)
    {
        List<Question> questionList = _questions.ToList();
        questionList.RemoveAt(index);
        string jsonString = JsonSerializer.Serialize(questionList);
        File.WriteAllText(jsonFilePath, jsonString);


    }
}