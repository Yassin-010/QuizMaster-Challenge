using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            StartQuiz();
        }
        catch(Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Quiz completed. Press any key to exit.");
            Console.ReadKey();
        }
    }

    static void StartQuiz()
    {
        Console.WriteLine("This is Math Quiz:");
        Console.WriteLine("Choose the correct answer code!");
        List<string> questions = new List<string>
        {
            "1 + 2 = ? A) 3 |  B) 4",
            "5 * 3 = ? A) 10 |  B) 15 ",
            "10 - 6 = ? A) 3 |  B) 4",
            "20 / 2 = ? A) 10 |  B) 5"
        };

        List<string> answers = new List<string>
        {
            "A",
            "B",
            "B",
            "A"
        };

        int score = 0;

        for(int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine("Question {0}:", i + 1);
            Console.WriteLine(questions[i]);

            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine();

            while(!userAnswer.Equals("A", StringComparison.OrdinalIgnoreCase) && !userAnswer.Equals("B", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Please choose the correct answer code (A or B).");
                Console.Write("Your answer: ");
                userAnswer = Console.ReadLine();
            }

            if(userAnswer.Equals(answers[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Quiz completed. Your score: {0}/{1}", score, questions.Count);
    }
}