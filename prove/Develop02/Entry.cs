using System;

public class Entry
{
    public string prompt;
    public string response;

    public string signature;

    public string currentDate;

    public void EntryInput(){
        currentDate = DateTime.Now.ToString();
        Prompt pr = new Prompt();
        prompt = pr.GeneratePrompt();
        Console.WriteLine(prompt);
        response = Console.ReadLine();
        Console.WriteLine("Signature: ");
        signature = Console.ReadLine();
    }

    public void Display(){
        Console.WriteLine(currentDate);
        Console.WriteLine(prompt);
        Console.WriteLine(response);
        Console.WriteLine("Signature: " + signature);
    }
}