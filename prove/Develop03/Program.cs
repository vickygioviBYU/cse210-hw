using System;

class Program
{
    // I have a system that chooses a random scripture from a library of scriptures.
    static void Main(string[] args)
    {
        Scripture scriptureOld = new Scripture(new Passage(
        3, 7, "1 Nephi"
        ), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
        Scripture scriptureOld2 = new Scripture(new Passage(
            3, 5, 6, "Proverbs"
        ), "Trust in the Lord with all thine heart; and lean not unto thine cown dunderstanding. In all thy ways acknowledge him, and he shall direct thy paths.");        

        Scriptures sc = new Scriptures();

        Scripture scripture1 = sc.GetScripture();
        
        scripture1.DisplayAll();

        string option = "";

        while (option != "quit") {
            option = Console.ReadLine();
            if (option == "quit") {
                Console.WriteLine("Bye bye");
            } else {
                scripture1.RandomSelect();
                if (scripture1.AllUnderscored() == true) {
                    option = "quit";
                }
            }
        }

        
    }
}