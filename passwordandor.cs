using System;

class Password
{
    static void Main()
    {
        string username = "admin", password = "1234";
        bool isUsernameValid = username == "admin";
        bool isPasswordValid = password == "1234";
        if (isUsernameValid && isPasswordValid)
        {
            Console.WriteLine("Login successful");
        }
        else
        {
            Console.WriteLine("Login failed");
        }
        if (isUsernameValid || isPasswordValid)
        {
            Console.WriteLine("At least one  is correct");
        }
        else
        {
            Console.WriteLine("Both username and password are incorrect");
        }
    }
}
