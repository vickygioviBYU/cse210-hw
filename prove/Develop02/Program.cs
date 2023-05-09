using System;
using System.IO;

class Program

// We added a signature functionality in each Entry

{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        // Entry entry = new Entry();
        // entry.EntryInput();
        // journal.entries.Add(entry);

        // Entry entry2 = new Entry();
        // entry2.EntryInput();
        // journal.entries.Add(entry2);

        // journal.Display();

        string option = "0";

        while (option != "5"){

            Console.WriteLine("Please select one of the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            option = Console.ReadLine();

            if (option == "1"){
                Write(journal);
            } else if (option == "2"){
                Display(journal);
            } else if (option == "3"){
                Load(journal);
            } else if (option == "4"){
                Save(journal);
            }
        }

        Console.WriteLine("Bye bye");

    }

    static void Write(Journal journal){
        Console.WriteLine("Write");
        Entry entry = new Entry();
        entry.EntryInput();
        journal._entries.Add(entry);
    }
    static void Display(Journal journal){
       Console.WriteLine("Display"); 
       journal.Display();
    }
    static void Load(Journal journal){
        Console.WriteLine("Load. Type the filename: ");

        journal._entries.Clear();

        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry entry = new Entry();
            entry._currentDate = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            entry._signature = parts[3];
            journal._entries.Add(entry);
        }

    }
    static void Save(Journal journal){
        Console.WriteLine("Save. Type the filename: ");

        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            foreach (Entry entry in journal._entries){
                outputFile.WriteLine(entry._currentDate + "," + entry._prompt + "," + entry._response + "," + entry._signature);
            }

            // You can add text to the file with the WriteLine method
            
            
            // You can use the $ and include variables just like with Console.WriteLine
            // string color = "Blue";
            // outputFile.WriteLine($"My favorite color is {color}");
        }

    }
}