using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // I exceeded requirements. I created a method called WriteIndex, and another called ReadIndex (in DataFile class).
        // The method WriteIndex write to a file the name of the file of the goals saved, and ReadIndex shows the names of
        // all the files created by the program.
        GoalManager goalManager = new GoalManager();
        int option = -1;

        while (option != 6) {

            Console.WriteLine();

            Console.WriteLine("You have " + goalManager.getPoints() + " points.");

            Console.WriteLine();


            Console.WriteLine("Menu Options: ");

            Console.WriteLine();

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("7. Load Index of Files");

            Console.WriteLine();

            Console.WriteLine("Select a Choice from the Menu: ");

            Console.WriteLine();

            option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (option == 1) {
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine();
                int selectGoal = int.Parse(Console.ReadLine());
                if (selectGoal == 1) {
                    Console.Write("Name of your goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Description of your goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Points associated: ");
                    int pointsAssociated = int.Parse(Console.ReadLine());
                    SimpleGoal sg = new SimpleGoal(name, description, pointsAssociated);
                    goalManager.newGoal(sg);
                } else if (selectGoal == 2){
                    Console.Write("Name of your goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Description of your goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Points associated: ");
                    int pointsAssociated = int.Parse(Console.ReadLine());
                    EternalGoal eg = new EternalGoal(name, description, pointsAssociated);
                    goalManager.newGoal(eg);
                } else if (selectGoal == 3){
                    Console.Write("Name of your goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Description of your goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Points associated: ");
                    int pointsAssociated = int.Parse(Console.ReadLine());
                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());
                    Console.Write("Points Bonus: ");
                    int pointsBonus = int.Parse(Console.ReadLine());
                    ChecklistGoal cg = new ChecklistGoal(name, description, pointsAssociated, bonus, pointsBonus);
                    goalManager.newGoal(cg);
                }
            } else if (option == 2) {
                Console.WriteLine("List Goals");
                Console.WriteLine("You have " + goalManager.getPoints() + " points.");
                goalManager.DisplayAllGoals();

            } else if (option == 3) {
                Console.WriteLine("Save Goals");
                DataFile df = new DataFile();
                df.WriteFile(goalManager);
            } else if (option == 4) {
                Console.WriteLine("Load Goals");
                DataFile df = new DataFile();
                df.ReadFile(goalManager);
            } else if (option == 5) {
                Console.WriteLine("Record");
                Console.Write("What goal did you accomplish? ");
                int goal = int.Parse(Console.ReadLine());
                Goal goalCurrent = goalManager.ObtainGoal(goal - 1);
                Console.WriteLine("Congrats! You have earned " + goalCurrent.ObtainPointsAssociated() + " points");
                goalCurrent.AddCurrentPoints(goalCurrent.ObtainPointsAssociated());
                goalCurrent.setCompleted(true);
                goalCurrent.AddTime();
                goalManager.AddCurrentPoints(goalCurrent.ObtainPointsAssociated());
                if (goalCurrent.TimesBonusEqualCurrentTimes()) {
                    goalManager.AddCurrentPoints(goalCurrent.GetPointsBonus());
                }
            } else if (option == 6) {
                
            } else if (option == 7) {
                DataFile df = new DataFile();
                df.ReadIndex();
            }
        }

        
    }
}