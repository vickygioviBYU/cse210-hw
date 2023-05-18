using System;

public class Scriptures{
    private List<Scripture> _listScriptures = new List<Scripture>();

    public Scriptures(){
        
        _listScriptures.Add(new Scripture(new Passage(
        3, 7, "1 Nephi"
        ), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        _listScriptures.Add(new Scripture(new Passage(
        3, 5, 6, "Proverbs"
        ), "Trust in the Lord with all thine bheart; and lean not unto thine cown dunderstanding. In all thy ways aacknowledge him, and he shall bdirect thy cpaths."));

        _listScriptures.Add(new Scripture(new Passage(
        3, 1, "Jacob"
        ), "But behold, I, Jacob, would speak unto you that are pure in heart. Look unto God with firmness of mind, and apray unto him with exceeding faith, and he will bconsole you in your cafflictions, and he will plead your cause, and send down djustice upon those who seek your destruction."));

        _listScriptures.Add(new Scripture(new Passage(
        1, 1, "1 Nephi"
        ), "I, Nephi, having been aborn of bgoodly cparents, therefore I was dtaught somewhat in all the learning of my father; and having seen many eafflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a frecord of my proceedings in my days."));

        _listScriptures.Add(new Scripture(new Passage(
        32, 28, "Alma"
        ), "Now, we will compare the word unto a aseed. Now, if ye give place, that a bseed may be planted in your cheart, behold, if it be a true seed, or a good seed, if ye do not cast it out by your dunbelief, that ye will resist the Spirit of the Lord, behold, it will begin to swell within your breasts; and when you feel these swelling motions, ye will begin to say within yourselves—It must needs be that this is a good seed, or that the word is good, for it beginneth to enlarge my soul; yea, it beginneth to eenlighten my funderstanding, yea, it beginneth to be delicious to me."));

    }

    public Scripture GetScripture() {
        Random rnd = new Random();
        int num = rnd.Next(0, _listScriptures.Count);
        return _listScriptures[num];
    }
}