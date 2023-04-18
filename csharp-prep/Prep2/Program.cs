using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        
        Write a program that determines the letter grade for a course according to the following scale:

        A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60

        */

        Console.WriteLine("What is your percentage? ");
        string percentage = Console.ReadLine();
        int percentageInt = int.Parse(percentage);
        string letter;

        if (percentageInt >= 90) {
            letter = "A";
        } else if (percentageInt >= 80) {
            letter = "B";
        } else if (percentageInt >= 70) {
            letter = "C";
        } else if (percentageInt >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }

        int percentageRemainder = percentageInt % 10;
        string sign;

        if (percentageRemainder >= 7) {
            sign = "+";
        } else if (percentageRemainder < 3) {
            sign = "-";
        } else {
            sign = "";
        }

        letter = letter + sign;

        Console.WriteLine($"Grade: {letter}");

        if (percentageInt >= 70) {
            Console.WriteLine("You passed!!");
        } else {
            Console.WriteLine("Try next time");
        }
    }
}