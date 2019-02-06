using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorthimApp
{
    class HighNlow : Guesser
    {

        protected int min = 1;
        protected int max = 100;
        int lastGuess;
        Random x = new Random();

        public static int Guess()
        {
            int guessCount = 0;
            guessCount++;
            return guessCount;
        }

        public int BinarySearch(int direction)
        {
            if (direction == 2)
            {
                lastGuess = x.Next(min, max + 1);
                return lastGuess;
            }


            if (direction == 1)
            {
                max = lastGuess - 1;
                lastGuess = x.Next(min, max + 1);
                return lastGuess;
            }
            else if (direction == -1)
            {
                min = lastGuess + 1;
                lastGuess = x.Next(min, max + 1);
                return lastGuess;
            }

            return -2;
        }

        internal void PrintGuess()
        {
            throw new NotImplementedException();
        }

        internal void Guesscount()
        {
            throw new NotImplementedException();
        }
    }
}

