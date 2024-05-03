using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Type 0 when finished");

        
        while (input != 0)
        {
            Console.Write("Enter Number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers entered");
        }
    }
}