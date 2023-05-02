using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fr = new Fraction(1);

        Console.WriteLine(fr.GetDecimalValue());

        Console.WriteLine(fr.GetFractionString());

        Fraction fr2 = new Fraction(5);

        Console.WriteLine(fr2.GetDecimalValue());

        Console.WriteLine(fr2.GetFractionString());

        Fraction fr3 = new Fraction(3, 4);

        Console.WriteLine(fr3.GetDecimalValue());

        Console.WriteLine(fr3.GetFractionString());

        Fraction fr4 = new Fraction(1, 3);

        Console.WriteLine(fr4.GetDecimalValue());

        Console.WriteLine(fr4.GetFractionString());
    }
}