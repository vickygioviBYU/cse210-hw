using Commons.Music.Midi;
using FinalProject;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Beat
{
    public List<MIDIMessage> GetMessages()
    {
        return _messages;
    }
    private List<Note> _notes;

    public int QuantityNotes()
    {
        return _notes.Count;
    }

    public List<Note> GetNotes()
    {
        return _notes;
    }

    private int _nextNoteNumber = 1;
    private IMidiOutput _output;
    private List<MIDIMessage> _messages;

    private int _blackNoteDuration;
    private int _beatDuration;

    public int GetDuration()
    {
        return _beatDuration;
    }

    public TypeNoteManager _typeNotes;

    public void IterateNotes()
    {
        List<MIDIMessage> beatNew = _messages.OrderBy(message => message.GetDelta()).ToList();

        for (int i = 0; i < beatNew.Count(); i++)
        {
            int sleep;

            if (i != 0)
            {
                sleep = beatNew[i].GetDelta() - beatNew[i - 1].GetDelta();
            }
            else if (i == 0)
            {
                sleep = beatNew[i].GetDelta();
            }
            else if (i == (beatNew.Count() - 1))
            {
                sleep = _beatDuration - beatNew[i].GetDelta();
            }
            else
            {
                sleep = 0;
            }

            if (sleep != 0)
            {
                Thread.Sleep(sleep);
            }

            beatNew[i].SendMessage();
        }
    }
    public void AddNote(byte pitch, int typeNote, int deltaTime)
    {
        if (deltaTime < _beatDuration)
        {
            _notes.Add(new Note(_nextNoteNumber, pitch, _typeNotes.GetTypes()[typeNote], deltaTime));

            _messages.Add(new MIDIMessage(_nextNoteNumber, 0x90, pitch, deltaTime, _output));

            if ((deltaTime + _typeNotes.GetTypes()[typeNote].GetTypeNote()) <= _beatDuration)
            {
                _messages.Add(new MIDIMessage(_nextNoteNumber, 0x80, pitch, deltaTime + _typeNotes.GetTypes()[typeNote].GetTypeNote(), _output));
            }
        }
        _nextNoteNumber++;
    }

    public void DeleteNote(int noteNumber)
    {
        for (int i = 0; i < _notes.Count(); i++)
        {
            if (_notes[i].GetNoteNumber() == noteNumber)
            {
                _notes.RemoveAt(i);
                break;
            }
        }

        for (int i = 0; i < _messages.Count(); i++)
        {
            if (_messages[i].GetNoteNumber() == noteNumber)
            {
                _messages.RemoveAt(i);
            }
        }
    }

    public Beat(int blackNoteDuration, int beatDuration, IMidiOutput output)
    {
        _typeNotes = new TypeNoteManager(blackNoteDuration);
        _output = output;
        _blackNoteDuration = blackNoteDuration;
        _beatDuration = beatDuration;
        _notes = new List<Note>();
        _messages = new List<MIDIMessage>();
    }
}
