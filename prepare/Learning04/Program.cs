using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Giovanni Canavesi", "Differential Ecuations");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math1 = new MathAssignment("Juan Perez", "Fractions", "Section 10", "Problems 20-30");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Mathias Gonzalez", "Fantasy Books", "The fantasy gender along the years");
        Console.WriteLine(writing1.GetWritingInformation());
    
    }
}