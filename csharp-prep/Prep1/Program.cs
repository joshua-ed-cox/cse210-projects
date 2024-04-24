using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name: ");
        string first_nam = Console.ReadLine();

        Console.Write("What is your last name: ");
        string last_nam = Console.ReadLine();

        Console.WriteLine($"Your name is {last_nam}, {first_nam} {last_nam}.");
    }
}