using System;

public class Entry
{
    public string _prompt;
    public string _response;

    public string _signature;

    public string _currentDate;

    public void EntryInput(){
        _currentDate = DateTime.Now.ToString();
        Prompt pr = new Prompt();
        _prompt = pr.GeneratePrompt();
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
        Console.WriteLine("Signature: ");
        _signature = Console.ReadLine();
    }

    public void Display(){
        Console.WriteLine(_currentDate);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
        Console.WriteLine("Signature: " + _signature);
    }
}