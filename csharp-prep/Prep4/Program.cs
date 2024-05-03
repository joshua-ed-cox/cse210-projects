using System;

class Program
{
    static void Main(string[] args)
    {
        int input = -1;
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

            //sort the numbers list
            numbers.Sort();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            Console.WriteLine($"The ordered list is: ");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers entered");
        }
    }
}