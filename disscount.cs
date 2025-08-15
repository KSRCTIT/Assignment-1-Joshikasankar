using System;
class Discount {
    static void Main()
    {
        double price = 1000.0, discount = 10.0;
        double Final_price = price - (price * discount / 100);
        Console.WriteLine("Final price :" +Final_price);
    } 
}