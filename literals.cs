using System;
class Literals
{
    static void Main()
    {
        int age = 25;
        float temperature = 98.6f;
        char grade = 'A';
        bool isPassed = true;

        Console.WriteLine("DataType of Age :" + age.GetType());
        Console.WriteLine("DataType of temperature :" + temperature.GetType());
        Console.WriteLine("DataType of grade :" + grade.GetType());
        Console.WriteLine("DataType of isPassed :" + isPassed.GetType());

    }
}