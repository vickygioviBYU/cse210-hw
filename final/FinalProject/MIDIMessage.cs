using System;
using Commons.Music.Midi;

class MIDIMessage
{
    private byte _byteTypeMessage;
    private byte _byteNote;
    private int _deltaTime;
    private IMidiOutput _output;

    public int GetDelta() {
        return _deltaTime;
    }
    
    public MIDIMessage(byte byteTypeMessage, byte byteNote, int deltaTime, IMidiOutput output){
        _byteTypeMessage = byteTypeMessage;
        _byteNote = byteNote;
        _deltaTime = deltaTime;
        _output = output;
    }

    public void SendMessage() {
        _output.Send(new byte[] { _byteTypeMessage, _byteNote, 0x70 }, 0, 3, 0);
    }
}