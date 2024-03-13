using Labb3_NET22.DataModels;
using Microsoft.Win32;
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
    private string jsonFilePath = "";
    private static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Quiz";
    private List<int> indexOfaskedQ = new List<int>();

    public Quiz()
    {
        _questions = new List<Question>();
        CreateDirectory();
    }
    public Quiz(String quizname)
    {
        jsonFilePath = "/" + quizname + ".json";
        _questions = new List<Question>();
        CreateDirectory();
    }
    private void CreateDirectory()
    {
        try
        {
            if (!Directory.Exists(folderPath))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(folderPath);
            }
        }
        catch (IOException ioex)
        {
            Console.WriteLine(ioex.Message);
        }


    }
    public bool validateCorrectAnswer(string CorrectAnswer)
    {
        return false;
    }


    public int count()
    {

        return 0;
    }


    public void EditQuestion(int indexToEdit, Question EditQ)
    {



    }
    public IEnumerable<Question> LoadQuiz()
    {

        if (File.Exists(folderPath + jsonFilePath))
        {
            string jsonS = File.ReadAllText(folderPath + jsonFilePath);
            _questions = JsonSerializer.Deserialize<List<Question>>(jsonS) ?? new List<Question>();
        }
        else
        {
            MessageBox.Show("The file is not found!");
        }
        return _questions;

    }


    public void AddQuestion(string statement, int correctAnswer, params string[] answers)
    {

    }


    public string[] GetLists()
    {
        string[] files = Directory.GetFiles(folderPath, "*.json");
        string[] lists = new string[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].EndsWith(".json"))
            {
                lists[i] = Path.GetFileName(files[i].Substring(0, files[i].Length - 5));
            }
        }
        return lists;
    }
}