public class Facade
{
    private Score _score;
    public void AddBeat(int blackNoteDuration, int beatDuration) {
        _score.AddBeat(blackNoteDuration, beatDuration);
    }

    public void DeleteBeat(int beatNumber){
        _score.DeleteBeat(beatNumber);
    }

    public void AddNote(byte pitch, int typeNote, int deltaTime, int beatNumber){
        _score.GetBeats()[beatNumber - 1].AddNote(pitch, typeNote, deltaTime);
    }

    public void DeleteNote(int noteNumber, int beatNumber){
        _score.GetBeats()[beatNumber - 1].DeleteNote(noteNumber);
    }

    public Facade()
    {
        _score = new Score();
    }
}