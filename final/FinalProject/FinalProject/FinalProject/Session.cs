using Commons.Music.Midi;

class Session
{
    private Score _score;
    private string _title;
    private string _author;
    private IMidiOutput _output;

    public void SetTitle(string title){
        _title = title;
    }
    public void SetAuthor(string author){
        _author = author;
    }

    public string GetTitle() {
        return _title;
    }
    public string GetAuthor() {
        return _author;
    }

    public Session(IMidiOutput output)
    {
        _output = output;
    }

    public void NewScore() {
        _score = new Score(_output);
    }
}