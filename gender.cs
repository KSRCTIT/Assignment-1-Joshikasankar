 using System;
class Gender
{
    public static void Main()
    {
        char gender = 'M';

        if (gender == 'M')
        {
            Console.WriteLine("Male");
        }

        else if (gender == 'F')
        {
            Console.WriteLine("Female");
        }
        else
        {
            Console.WriteLine("Others");
        }
    }
}