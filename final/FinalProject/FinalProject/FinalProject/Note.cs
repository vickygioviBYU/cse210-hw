class Note
{
    private int _noteNumber;
    private int _pitch;
    private TypeNote _typeNote;
    private int _deltaTime;

    public int GetNoteNumber() {
        return _noteNumber;
    }
    public Note(int noteNumber, int pitch, TypeNote typeNote, int deltaTime){
        _noteNumber = noteNumber;
        _pitch = pitch;
        _typeNote = typeNote;
        _deltaTime = deltaTime;
    }
}