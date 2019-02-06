using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorthimApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool foundNumB = false;
            bool foundNumR = false;
            int direction = 2;
            
            GuessingGameApp ga = new GuessingGameApp();
            BruteForce brute = new BruteForce();
            HighNlow shoot = new HighNlow();

            Console.WriteLine("BruteForce will start us off!.");
            while (foundNumB == false)
            {
                brute.PrintGuesses();
                int guess = brute.BruteForce();
                foundNumB = ga.GuessAnswer(guess);
            }

            brute.PrintGuesses();
            Console.WriteLine("Press enter any Random Number");
            Console.ReadLine();
            Ran rando = new Ran();
            while (foundNumR == false)
            {
                rando.Guess();
                int guess = rando.GuessRand();
                foundNumR = ga.GuessAnswer(guess);
            }

            Console.WriteLine("Ran tried and ");
            rando.PrintGuess();

            Console.WriteLine("Press enter to run high Low.");
            Console.ReadLine();
            shoot.BinarySearch(direction);

            do
            {
                shoot.Guesscount();
                int guess = shoot.BinarySearch(direction);
                direction = ga.GuessAnswerInt(guess);
            } while (direction != 0);

            Console.WriteLine(" Shooter ");
            shoot.PrintGuess();
            
            Console.ReadLine();
        }
    }
}
