public class TypeNote
{
    private string _name;
    private int _number;
    private int _typeNote;

    public TypeNote(string name, int number, int typeNote) {
        _name = name;
        _number = number;
        _typeNote = typeNote;
    }

    public void SetName(string name){
        _name = name;
    }
    public void SetNumber(int number){
        _number = number;
    }
    public void SetTypeNote(int typeNote){
        _typeNote = typeNote;
    }

    public string GetName() {
        return _name;
    }
    public int GetNumber() {
        return _number;
    }
    public int GetTypeNote() {
        return _typeNote;
    }
}