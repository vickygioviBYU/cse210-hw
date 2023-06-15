using System;
using System.IO;

class DataFile
{
    private string fileIndex = "index.txt";
    public void WriteIndex(string filename) {
        using (StreamWriter outputFile = File.AppendText(fileIndex))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(filename);
        }
    }

    public void ReadIndex() {
        string[] lines = System.IO.File.ReadAllLines(fileIndex);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    
    public void WriteFile(GoalManager goalManager) {
        Console.WriteLine("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(goalManager.getPoints());

            foreach(Goal g in goalManager.Goals()) {
                if (g._goalType == "SimpleGoal") {
                    outputFile.WriteLine(g._goalType + ":" + g.GetName() + "," + g.GetDescription() + "," + g.ObtainPointsAssociated() + "," + g.isComplete());
                } else if (g._goalType == "EternalGoal") {
                    outputFile.WriteLine(g._goalType + ":" + g.GetName() + "," + g.GetDescription() + "," + g.ObtainPointsAssociated());
                } else if (g._goalType == "ChecklistGoal") {
                    outputFile.WriteLine(g._goalType + ":" + g.GetName() + "," + g.GetDescription() + "," + g.ObtainPointsAssociated() + "," + g.GetPointsBonus() + "," + g.GetTimesBonus() + "," + g.GetCurrentTimes());
                }
            }
            
        }

        WriteIndex(filename);
    }

    public void ReadFile(GoalManager goalManager){
        Console.WriteLine("Filename: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        Console.WriteLine(lines[0]);

        for (int i=1; i<lines.Count(); i++) {
            string[] parts = lines[i].Split(":");

            Console.WriteLine(parts[0]);
            string[] parts2 = parts[1].Split(",");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal sg = new SimpleGoal(parts2[0], parts2[1], int.Parse(parts2[2]));
                if (parts2[3] == "True") {
                    sg.setCompleted(true);
                } else {
                    sg.setCompleted(false);
                }
                goalManager.newGoal(sg);

                Console.WriteLine(parts2[0]);
                Console.WriteLine(parts2[1]);
                Console.WriteLine(parts2[2]);
                Console.WriteLine(parts2[3]);

            } else if (parts[0] == "EternalGoal") {

                EternalGoal eg = new EternalGoal(parts2[0], parts2[1], int.Parse(parts2[2]));
                goalManager.newGoal(eg);

                Console.WriteLine(parts2[0]);
                Console.WriteLine(parts2[1]);
                Console.WriteLine(parts2[2]);
                
            } else if (parts[0] == "ChecklistGoal") {
                
                ChecklistGoal cg = new ChecklistGoal(parts2[0], parts2[1], int.Parse(parts2[2]), int.Parse(parts2[4]), int.Parse(parts2[3]));
                cg.GetCurrentTimes();
                goalManager.newGoal(cg);

                Console.WriteLine(parts2[0]);
                Console.WriteLine(parts2[1]);
                Console.WriteLine(parts2[2]);
                Console.WriteLine(parts2[3]);
                Console.WriteLine(parts2[4]);
                Console.WriteLine(parts2[5]);

            }

            
        }

        // goalManager.newGoal(new SimpleGoal("Name1", "Desc1", 100));
    }
}