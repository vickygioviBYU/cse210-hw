using System;
using System.Collections.Generic;
using Commons.Music.Midi;

class Score
{
    private List<Beat> _beats;
    private IMidiOutput _output;

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
}