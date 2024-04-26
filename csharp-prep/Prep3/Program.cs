using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // variable initialization
        int userGuess = 0;
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("Welocome to the magic number game!");

        while (userGuess != randomNumber)
        {
            Console.Write("Please enter a guess 1-100: ");
            string userGuessInput = Console.ReadLine();
            userGuess = int.Parse(userGuessInput);


            if (userGuess > randomNumber)
            {
                Console.WriteLine();
                Console.WriteLine("The magic number is lower");
            }
            else if (userGuess < randomNumber)
            {
                Console.WriteLine();
                Console.WriteLine("The magic number is higher");
            }
        }
        Console.WriteLine("");
        Console.WriteLine("You guessed the magic nubmer!");
    }
}