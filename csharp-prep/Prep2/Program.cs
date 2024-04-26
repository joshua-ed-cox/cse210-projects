using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter you grade percentage: ");
        string userInput = Console.ReadLine();

        int userPercentage = int.Parse(userInput);
        string userGrade = "";
        bool didPass;
        
        if (userPercentage >= 90)
        {
            userGrade = "A";
            didPass = true;
        }
        else if (userPercentage >= 80)
        {
            userGrade = "B";
            didPass = true;
        }
        else if (userPercentage >= 70)
        {
            userGrade = "C";
            didPass = true;
        }
        else
        {
            didPass = false;
        }

        if (didPass)
        {
            Console.WriteLine($"You passed the class with a grade of: {userGrade}");
        }
        else
        {
            Console.WriteLine("You did not pass the class");
        }

    }
}