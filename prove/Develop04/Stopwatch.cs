using System;

public class Stopwatch
{
    private DateTime _start;
    public void Start() {
        _start = DateTime.Now;
    }

    public TimeSpan Elapsed(){
        return (DateTime.Now - _start);
    }
}