using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        
        What is your first name? Scott
        What is your last name? Burton

        Your name is Burton, Scott Burton.

        */

        Console.WriteLine("What is your first name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {name} {surname}.");
    }
}