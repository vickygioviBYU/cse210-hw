using System;

public class Scripture
{
    private Passage _passage;
    private List<Word> _words = new List<Word>();
    private List<int> _wordsNumber = new List<int>();
    private string _text;

    public bool AllUnderscored(){
        foreach (Word word in _words) {
            if (word.GetUnderscored() == false) {
                return false;
            }
        }
        return true;
    }
    public Scripture(Passage passage, string text) {
        _passage = passage;
        _text = text;
        List<string> wordsString = _text.Split(" ").ToList();
        foreach(string wrd in wordsString){
            _words.Add(new Word(wrd));
        }
    }

    public void AddWord(Word word){
        _words.Add(word);
    }

    public void DisplayAll(){
        Console.Clear();
        _passage.DisplayPassage();
        Console.Write(" - ");
        foreach (Word word in _words){
            word.ShowWord();
            Console.Write(" ");
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Enter to hide words, quit to exit.");

    }

    public void RandomSelect(){
        Random rnd = new Random();
        int num = rnd.Next(0, _words.Count);
        _words[num].SetUnderscore();

        Random rnd2 = new Random();
        int num2 = rnd.Next(0, _words.Count);
        _words[num2].SetUnderscore();

        Random rnd3 = new Random();
        int num3 = rnd.Next(0, _words.Count);
        _words[num3].SetUnderscore();

        DisplayAll();
    }
}