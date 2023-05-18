using System;

public class Passage
{
    private int _chapter;
    private int _verseStart;
    private int? _verseEnd;
    private string _book;
    // PASSAGE: New passage (pass the chapter, verse and book), 
    public Passage(int chapter, int verse, string book) {
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = null;
        _book = book;
    }

    // New passage (pass the chapter, verse start, verse end, and book),
    public Passage(int chapter, int verseStart, int verseEnd, string book) {
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _book = book;
    }

    public void DisplayPassage() {
        if (_verseEnd == null) {
            Console.Write(_book + " " + _chapter + ":" + _verseStart);
        } else {
            Console.Write(_book + " " + _chapter + ":" + _verseStart + "-" + _verseEnd);
        }
    }
}