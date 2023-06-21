using System;
using Commons.Music.Midi;
class Program
{
    static void Main(string[] args)
    {
        var access = MidiAccessManager.Default;
        var output = access.OpenOutputAsync(access.Outputs.First().Id).Result;

        // output.Send(new byte[] { 0x90, 0x40, 0x70 }, 0, 3, 0);
        // output.Send(new byte[] { 0x90, 0x50, 0x70 }, 0, 3, 0);
        // Thread.Sleep(1000);
        // output.Send(new byte[] { 0x80, 0x40, 0x70 }, 0, 3, 0);
        // output.Send(new byte[] { 0x80, 0x50, 0x70 }, 0, 3, 0);
        // Thread.Sleep(1000);

        var beat = new List<MIDIMessage>()
        {
            new MIDIMessage(0x90, 60, 0, output),
            new MIDIMessage(0x80, 60, 1000, output),
            new MIDIMessage(0x90, 62, 1000, output),
            new MIDIMessage(0x80, 62, 2000, output),
            new MIDIMessage(0x90, 64, 2000, output),
            new MIDIMessage(0x80, 64, 3000, output),
        };

        for(int i = 0; i < beat.Count(); i++){
            int sleep;
            if (i != 0) {
                sleep = beat[i].GetDelta() - beat[i - 1].GetDelta();     
            } else {
                sleep = beat[i].GetDelta();
            }

            if (sleep != 0) {
                Thread.Sleep(sleep);
            }
            
            beat[i].SendMessage();
        }

        output.CloseAsync();
    }
}