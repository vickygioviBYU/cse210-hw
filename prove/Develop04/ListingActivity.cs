using System;

public class ListingActivity : Activity
{
    private Stopwatch _sw = new Stopwatch();
    private double _lastFrame;

    private double DeltaTime()
    {
        TimeSpan ts = this._sw.Elapsed();
        double firstFrame = ts.TotalMilliseconds;
        double dt = firstFrame - _lastFrame;
        this._lastFrame = ts.TotalMilliseconds;
        return dt;
    }
    private List<string> prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> responses = new List<string>();

    public override void ActivityInstructions() {
        StartingMessage();
        Prepare();
        Animation();
        ListInstructions();
        EndingMessage();
    }

    public void ListInstructions(){
        Random rnd = new Random();
        int num = rnd.Next(0, prompts.Count);
        Console.WriteLine(prompts[num]);
        Animation();
        Console.WriteLine();

        this._sw.Start();

        double acc = 0.0;

        List<string> buf = new List<string>();

        Console.WriteLine("Go!");

        while (acc <= _duration * 1000)
        {
            acc += DeltaTime();
            if (!Console.KeyAvailable)
            {
                continue;
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                buf.Add("\n");
            }
            else
            {
                buf.Add(key.KeyChar.ToString());
            }
        }
        Console.WriteLine("\nTime's up!");
        string bufStr = String.Join<string>("", buf);
        Console.WriteLine($"Here's what you typed: {bufStr}");

        // string newResponse = Console.ReadLine();
        // responses.Add(newResponse);

        Console.WriteLine("Items entered: " + responses.Count);     
    }

    public ListingActivity()
    {
        _name = "Listing Activity";
        _desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 50;

        
        ActivityInstructions();
        // Set other values here that are unique to the Reflecting Activity
    }

    public ListingActivity(int duration)
    {
        _name = "Listing Activity";
        _desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = duration;

        
        ActivityInstructions();
        // Set other values here that are unique to the Reflecting Activity
    }
}