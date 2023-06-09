using System;

public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe in";
    private string _breatheOut = "Breathe out";
    public override void ActivityInstructions() {
        StartingMessage();
        Prepare();
        Animation();
        BreatheInstructions();
        EndingMessage();
    }

    private void BreatheInstructions(){
        
            for(int i=1; i<=4; i++){
                while (!VerifyStopwatch()) {
                    Console.WriteLine(_breatheIn);
                    Animation();
                    Console.WriteLine(_breatheOut);
                    Animation();
                }        
            }
        
    }
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _desc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 50;

        
        ActivityInstructions();

        // Set other values here that are unique to the Reflecting Activity
    }

    public BreathingActivity(int duration)
    {
        _name = "Breathing Activity";
        _desc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = duration;

        
        ActivityInstructions();

        // Set other values here that are unique to the Reflecting Activity
    }
}