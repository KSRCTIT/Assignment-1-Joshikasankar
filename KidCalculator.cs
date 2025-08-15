using System;
class KidCalculator
{
    static void Main()
    {
        int a = 10, b = 5;
        Console.WriteLine("Total apples:" + (a + b));
        Console.WriteLine("Difference of Pencils :" + (a - b));
        Console.WriteLine("Total pages when 10 pages are copied 5 times :" + (a *b));
        Console.WriteLine("Divide 10 chocolates among 5 kids :" + a / b);
        Console.WriteLine("Leftover candies after equal distribution :" + a % b);


    }
}