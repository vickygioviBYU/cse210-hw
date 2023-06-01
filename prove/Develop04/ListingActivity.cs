using System;

public class ListingActivity : Activity
{
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
        while (!VerifyStopwatch()) {
            string newResponse = Console.ReadLine();
            responses.Add(newResponse);
        }
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
}