using System;

public class Prompt
{
    public List<string> listPrompts = new List<string>();

    public Prompt(){
        listPrompts.Add("Who was the most interesting person I interacted with today?");
        listPrompts.Add("What was the best part of my day?");
        listPrompts.Add("How did I see the hand of the Lord in my life today?");
        listPrompts.Add("What was the strongest emotion I felt today?");
        listPrompts.Add("If I had one thing I could do over today, what would it be?");
    }
    
    public string GeneratePrompt(){
        Random rd = new Random();
        int rand_num = rd.Next(0,4);
        return listPrompts[rand_num];
    }
}