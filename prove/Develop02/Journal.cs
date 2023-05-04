using System;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void Display(){
        foreach (Entry entry in entries){
            entry.Display();
        }
    }
}