using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction defualt = new Fraction();
        Fraction whole = new Fraction(5);
        Fraction custom = new Fraction(3, 4);
        Fraction custom2 = new Fraction(1, 3);

        Console.WriteLine(defualt.DisplayFractionString());
        Console.WriteLine(defualt.DisplayFractionDecimal());
        Console.WriteLine(whole.DisplayFractionString());
        Console.WriteLine(whole.DisplayFractionDecimal());
        Console.WriteLine(custom.DisplayFractionString());
        Console.WriteLine(custom.DisplayFractionDecimal());
        Console.WriteLine(custom2.DisplayFractionString());
        Console.WriteLine(custom2.DisplayFractionDecimal());
    }
}