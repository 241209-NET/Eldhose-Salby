using System;
using System.Collections.Generic;
using System.Dynamic;

class Program
{
    static List<Question> quiz=new List<Question>();
    static int score=0;
    static void Main(string[] args)
    {
        Console.WriteLine("--------------Welcome to the Quiz Application--------------\n");
        Console.WriteLine("Menu");

        quiz.Add(new Question("1) Name the process of hiding unnecessary details and showing only what is necessary.", "Abstraction"));
        quiz.Add(new Question("2) Name the process in which child class inherit parent's class.", "Inheritance"));
        quiz.Add(new Question("3) Name the process in which concrete classes should depend on abstract definition.", "Dependency inversion"));
        quiz.Add(new Question("4) Which pattern have only one instance of a class?", "Singleton"));
        quiz.Add(new Question("5) What conversion is required when converting from a larger data type to a smaller data type, as this may result in data loss?", "Explicit"));

        while(true){
            ShowMenu();
            string choice=Console.ReadLine();

            switch(choice){
                case "1":
                    AddQuestion();
                    break;
                case "2":
                    StartQuiz();
                    break;
                case "3":
                    Console.WriteLine("\n--------------Thank you for using the Quiz Application.--------------");
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Error, invalid choice. Choose from the option\n");
                    break;
            }
        }    
    }


static void ShowMenu(){
        Console.WriteLine("1. Add a question");
        Console.WriteLine("2. Enter the quiz.");
        Console.WriteLine("3. Exit the application\n");
        Console.Write("Enter your choice: ");
    }

static void AddQuestion(){
    Console.Write("Enter a question: ");
    string? questionText=Console.ReadLine();

    Console.Write("Enter the answer: ");
    string? answerText=Console.ReadLine();

    if(string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(answerText)){
        Console.WriteLine("\nQuestion or answer cannot be empty.\n");
        return;
    }

    quiz.Add(new Question(questionText,answerText));
        Console.WriteLine("Question and answer added successfully.");
    

}

static void StartQuiz(){
    score =0;
    foreach(var question in quiz){
        Console.WriteLine(question.Text);
        string userAnswer=Console.ReadLine();

        if(userAnswer.Equals(question.Answer,StringComparison.OrdinalIgnoreCase)){
            score++;
            Console.WriteLine("\nCorrect\n");
        }else{
            Console.WriteLine($"\nIncorrect, the correct answer is {question.Answer}\n");
        }
    }
    Console.WriteLine($"\nYour total score is {score}/{quiz.Count}\n");
    }
}
class Question{
    public string? Text{get; set;}
    public string? Answer{get; set;}

    public Question(string text, string answer){
        Text=text;
        Answer=answer;
    }
}
