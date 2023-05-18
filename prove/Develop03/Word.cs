using System;

public class Word
{
    private string _word;
    private bool _underscored;

    public bool GetUnderscored() {
        return _underscored;
    }
    public void ShowWord(){
        if (_underscored == true) {
            foreach (char c in _word) {
                Console.Write("_");
            }
        } else {
            Console.Write(_word);
        }
    }

    public Word(string word){
        _word = word;
    }

    public void SetWord(){
        _underscored = false;
    }
    public void SetUnderscore(){
        _underscored = true;
    }
}