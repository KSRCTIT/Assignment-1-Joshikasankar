using System;

class QuizPoints
{
    static void Main()
    {
        int score = 50;
        Console.WriteLine("Starting score: " + score);

        score += 10; 
        Console.WriteLine("After correct answer: " + score);

        score -= 5; 
        Console.WriteLine("After wrong answer: " + score);

        score *= 2; 
        Console.WriteLine("After bonus round: " + score);

        score /= 5;
        Console.WriteLine("After penalty: " + score);
    }
}