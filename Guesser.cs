using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorthimApp
{
    class Guesser
    {
        public abstract class guesser
        {
            protected int guessCount = 0;
            public int GuessCount { get { return guessCount; } }
            protected string name;

            public abstract int Guess();

            public void PrintGuesses()
            {
                Console.WriteLine(name + " guessed " + guessCount + " time(s)");
                if (guessCount < 5)
                {
                    Console.WriteLine("Wow good job");
                }
                else if (guessCount < 10)
                {
                    Console.WriteLine("nice!");
                }
                else if (guessCount < 20)
                {
                    Console.WriteLine("maybe next time");
                }
            }

        }
    }
}

