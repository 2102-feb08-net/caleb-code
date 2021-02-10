using System;

namespace caleb_rockPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ai = new RockPaperSciss();
            string userInput = Console.ReadLine();
            ai.Status = userInput;
            Console.WriteLine($"{userInput}");
            Console.WriteLine($"{ai.Status}");
        }
    }
}
