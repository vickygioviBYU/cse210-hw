using System;

public class Activity
{
    protected string _name;
    protected string _desc;
    protected int _duration;

    private DateTime _startTime;
    private DateTime _futureTime;
    private DateTime _currentTime;

    public void Animation(){
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b\b");
    }

    public void InitStopwatch(){
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(_duration);
        _currentTime = DateTime.Now;
    }

    public bool VerifyStopwatch() {
        if (DateTime.Now < _futureTime)
        {
            return false;
        } else {
            return true;
        }
    }

    public virtual void ActivityInstructions() {
        StartingMessage();
        Prepare();
        Animation();
        EndingMessage();
    }

    public string Prepare() {
        return "Get Ready...";
    }

    public void StartingMessage(){
        Console.WriteLine("Welcome to the " + _name);
        Console.WriteLine(_desc);
        Console.WriteLine("How long, in seconds, will be your session?");
        string stringMessage = Console.ReadLine();
        int intMessage = int.Parse(stringMessage);
        SetDuration(intMessage);
        InitStopwatch();
    }

    public void EndingMessage() {
        Console.WriteLine("Nicely done!");
        Animation();
        Console.WriteLine("You have completed another " + _duration + " seconds of the " + _name);
        Animation();
    }

    public void SetDuration(int duration){
        _duration = duration;
    } 

    public int GetDuration(){
        return _duration;
    }
}