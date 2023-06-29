using System.Collections.Generic;

class TypeNoteManager
{
    private List<TypeNote> _types;
    public TypeNoteManager(int blackNoteDuration) {
        _types = new List<TypeNote>();
        _types.Add(new TypeNote("Round Note", 1, blackNoteDuration * 4));
        _types.Add(new TypeNote("Half Note", 2, blackNoteDuration * 2));
        _types.Add(new TypeNote("Quarter Note", 4, blackNoteDuration * 1));
        _types.Add(new TypeNote("Eight Note", 8, blackNoteDuration / 2));
        _types.Add(new TypeNote("Semiquaver Note", 16, blackNoteDuration / 4));
        _types.Add(new TypeNote("Fuse Note", 32, blackNoteDuration / 8));
        _types.Add(new TypeNote("Semifuse Note", 64, blackNoteDuration / 16));
    }

    public List<TypeNote> GetTypes() {
        return _types;
    }
}