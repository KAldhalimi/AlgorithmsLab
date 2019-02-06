using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorthimApp
{
    class BruteForce
    {
        class bruteForce : Guesser
        {

            protected int bruteforce = 100;



            public static int Guess()
            {

                int guessCount = 0;
                guessCount++;
                return guessCount;
            }

            public int BruceForce()
            {

                bruteforce--;
                return bruteforce;
            }

        }

        internal int BruteForce()
        {
            throw new NotImplementedException();
        }

        internal void PrintGuesses()
        {
            throw new NotImplementedException();
        }
    }
}