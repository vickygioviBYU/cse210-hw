using System.Collections.Generic;

class PlayingCursor
{
    private Score _score;
    public PlayingCursor(Score score) {
        _score = score;
        
    }

    public void PlayIterate() {
        List<Beat> beats = _score.GetBeats();
        foreach (Beat b in beats) {
            b.IterateNotes();
        }
    }
}


