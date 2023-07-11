using Commons.Music.Midi;
using FinalProject;
using System.Collections.Generic;

public class Facade : Observable
{
    private Score _score;
    private IMidiOutput _output;
    private PlayingCursor _pc;
    public void AddBeat(int blackNoteDuration, int beatDuration) {
        _score.AddBeat(blackNoteDuration, beatDuration);
        Avisar("Update score");
    }

    public void DeleteBeat(int beatNumber){
        _score.DeleteBeat(beatNumber);
        Avisar("Update score");
    }

    public void AddNote(byte pitch, int typeNote, int deltaTime, int beatNumber){
        _score.GetBeats()[beatNumber - 1].AddNote(pitch, typeNote, deltaTime);
        Avisar("Update score");
    }

    public void DeleteNote(int noteNumber, int beatNumber){
        _score.GetBeats()[beatNumber - 1].DeleteNote(noteNumber);
        Avisar("Update score");
    }

    public int GetDuration(int beatNumber)
    {
        return _score.GetBeat(beatNumber).GetDuration();
    }

    public Beat GetBeat(int index)
    {
        return _score.GetBeat(index);
    }

    public List<Note> GetNotes(int beatNumber)
    {
        if (_score.GetBeats().Count == 0)
        {
            return null;
        }
        return _score.GetBeats()[beatNumber - 1].GetNotes();
    }

    public void IterateNotes()
    {
        _pc.PlayIterate();
    }

    public int QuantityBeats()
    {
        return _score.QuantityBeats();
    }

    public int QuantityNotes(int beatNumber)
    {
        return _score.GetBeat(beatNumber).QuantityNotes();
    }

    public Facade(IMidiOutput output)
    {
        _output = output;
        _score = new Score(_output);
        _pc = new PlayingCursor(_score);
    }
}