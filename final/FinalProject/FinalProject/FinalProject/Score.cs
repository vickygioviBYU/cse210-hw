using System;
using System.Collections.Generic;
using Commons.Music.Midi;
using FinalProject;

public class Score
{
    private List<Beat> _beats;
    private IMidiOutput _output;

    public int QuantityBeats()
    {
        return _beats.Count;
    }

    public void AddBeat(int blackNoteDuration, int beatDuration) {
        Beat b = new Beat(blackNoteDuration, beatDuration, _output);
        _beats.Add(b);
    }

    public void DeleteBeat(int beatNumber) {
        _beats.RemoveAt(beatNumber - 1);
    }

    public List<Beat> GetBeats() {
        return _beats;
    }

    public Beat GetBeat(int index)
    {
        return _beats[index - 1];
    }

    public Score(IMidiOutput output)
    {
        _output = output;
        _beats = new List<Beat>();
        //Beat beat1 = new Beat(1000, 4000, _output);
        //Beat beat2 = new Beat(2000, 8000, _output);

        //List<MIDIMessage> beat1Messages = beat1.GetMessages();

        //beat1Messages = new List<MIDIMessage>()
        //{
        //    new MIDIMessage(1, 0x90, 60, 0, _output),
        //    new MIDIMessage(2, 0x90, 64, 0, _output),
        //    new MIDIMessage(1, 0x80, 60, 1000, _output),
        //    new MIDIMessage(2, 0x80, 64, 1000, _output),
        //    new MIDIMessage(3, 0x90, 62, 1000, _output),
        //    new MIDIMessage(3, 0x80, 62, 2000, _output),
        //    new MIDIMessage(4, 0x90, 64, 2000, _output),
        //    new MIDIMessage(4, 0x80, 64, 3000, _output),
        //    new MIDIMessage(5, 0x90, 65, 3000, _output),
        //    new MIDIMessage(5, 0x80, 65, 4000, _output),
        //};

        //List<Note> beat1Note = beat1.GetNotes();

        //beat1Note = new List<Note>()
        //{
        //    new Note(1, 60, beat1._typeNotes.GetTypes()[0], 0),
        //    new Note(2, 60, beat1._typeNotes.GetTypes()[1], 1),
        //};


        //List<MIDIMessage> beat2Messages = beat2.GetMessages();

        //beat2Messages = new List<MIDIMessage>()
        //{
        //    new MIDIMessage(1, 0x90, 60, 0, _output),
        //    new MIDIMessage(2, 0x90, 64, 0, _output),
        //    new MIDIMessage(1, 0x80, 60, 1000, _output),
        //    new MIDIMessage(2, 0x80, 64, 1000, _output),
        //};

        //List<Note> beat2Note = beat2.GetNotes();

        //beat2Note = new List<Note>()
        //{
        //    new Note(1, 64, beat2._typeNotes.GetTypes()[0], 0),
        //    new Note(2, 64, beat2._typeNotes.GetTypes()[1], 1),
        //};

        //_beats = new List<Beat>()
        //{
        //    beat1,
        //    beat2,
        //};
    }
}