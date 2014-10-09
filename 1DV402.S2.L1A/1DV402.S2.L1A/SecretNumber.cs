using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        public const int MaxNumberOfGuesses = 8;
        public int _count = MaxNumberOfGuesses;
        private int _secretNumber = -1;


        public SecretNumber()
        {
        }

        public void Initialize()
        {
            Random random = new Random();
            _secretNumber = random.Next(1, 101);
        }


        public bool MakeGuess(int number)
        {
            _count--;
            if (number > _secretNumber)
            {
                Console.WriteLine("{0} To high. You have {1} guesses left", number, _count);
                if (_count == 0)
                {
                    Console.WriteLine("The secret number was {0}", _secretNumber);
                }
                return false;
            }
            else if (number < _secretNumber)
            {
                Console.WriteLine("{0} To low. You have {1} guesses left", number, _count);
                if (_count == 0)
                {
                    Console.WriteLine("The scret number was {0}", _secretNumber);
                }
                return false;
            }
            else
            {
                Console.WriteLine("Correctly guessed. You did it in {0} attempts", MaxNumberOfGuesses - _count);
                return true;
            }
        }
    }
}
