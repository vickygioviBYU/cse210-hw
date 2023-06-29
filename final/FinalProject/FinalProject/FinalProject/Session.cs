class Session
{
    private Score _score;
    private string _title;
    private string _author;

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

    public void NewScore() {
        _score = new Score();
    }
}