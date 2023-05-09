using System;

public class Prompt
{
    public List<string> _listPrompts = new List<string>();

    public Prompt(){
        _listPrompts.Add("Who was the most interesting person I interacted with today?");
        _listPrompts.Add("What was the best part of my day?");
        _listPrompts.Add("How did I see the hand of the Lord in my life today?");
        _listPrompts.Add("What was the strongest emotion I felt today?");
        _listPrompts.Add("If I had one thing I could do over today, what would it be?");
    }
    
    public string GeneratePrompt(){
        Random rd = new Random();
        int rand_num = rd.Next(0,4);
        return _listPrompts[rand_num];
    }
}