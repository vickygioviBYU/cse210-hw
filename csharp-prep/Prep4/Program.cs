using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0) {
            Console.WriteLine("Enter: ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);

            if (number != 0) {
                
                numbers.Add(number);
            }

        }

        Console.WriteLine(numbers.Sum());

        Console.WriteLine(numbers.Average());

        Console.WriteLine(numbers.Max());

        numbers.Sort();

        foreach (int numb in numbers) {
            Console.WriteLine(numb);
        }

        
    }
}