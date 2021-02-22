using System;

namespace classTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Burglar = new test1("a1z5", "Steven", 1000);
            var Nick = new test1("tk421", "Nick", 100000);

            Console.WriteLine(Nick.Money);
            Burglar.drainAccount(Nick);

            //Console.WriteLine(Nick.money);




        }
    }
}
