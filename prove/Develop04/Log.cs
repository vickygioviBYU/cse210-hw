using System;

public class Log
{
    private int _timesBreathing;
    private int _timesReflection;
    private int _timesListing;

    private int _sBreathing;
    private int _sReflection;
    private int _sListing;
    public string queryLog(){
        string message = "Times performed Breathing Activity: " + _timesBreathing + " - " + _sBreathing + " seconds";
        message += "\nTimes performed Reflection Activity: " + _timesReflection + " - " + _sReflection + " seconds";
        message += "\nTimes performed Listing Activity: " + _timesListing + " - " + _sListing + " seconds";
        return message;
    }

    public void addOne(int activity, int seconds){
        if (activity == 1){
            _timesBreathing++;
            _sBreathing += seconds;
        } else if (activity == 2){
            _timesReflection++;
            _sReflection += seconds;
        } else if (activity == 3){
            _timesListing++;
            _sListing += seconds;
        }
    }
}