using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorthimApp
{
    class Ran : Guesser
    {


        Random r = new Random();
        int RandomNumber = r.Next(min, max);

        public override int Guess()
        {
            int guessCount = 0;
            guessCount++;
            ;
            return guessCount;
        }

        public int GuessRand()
        {

            int rndNum = r.Next(1, 101);
            return Random;
    }

        internal void PrintGuess()
        {
            throw new NotImplementedException();
        }
    }
}