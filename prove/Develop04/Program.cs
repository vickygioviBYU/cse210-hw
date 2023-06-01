using System;

class Program
{
    static void Main(string[] args)
    {
        // I exceeded requirements: Keeping a log of how many times activities were performed.
        Log log = new Log();
        int option = -1;
        while (option != 4) {
            Console.WriteLine("Menu options: ");
            Console.WriteLine();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("5. Query Log");

            option = int.Parse(Console.ReadLine());

            if (option == 1) {
                BreathingActivity ba = new BreathingActivity();
                log.addOne(1, ba.GetDuration());
                Console.WriteLine();
            } else if (option == 2) {
                ReflectionActivity ra = new ReflectionActivity();
                log.addOne(2, ra.GetDuration());
                Console.WriteLine();
            } else if (option == 3) {
                ListingActivity la = new ListingActivity();
                log.addOne(3, la.GetDuration());
                Console.WriteLine();
            } else if (option == 4) {
                
            } else if (option == 5) {
                Console.WriteLine(log.queryLog());
            }
        }
        
    }
}