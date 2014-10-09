using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        // Publik namngiven konstant
        public const int MaxNumberOfGuesses = 7;

        // _Count privat i classen secret number
        private int _count;


        private int _number;

       //Default constructor
        public SecretNumber()
        {
            Initialize();
        }

        public void Initialize()
        {           
            Random random = new Random();
            _number = random.Next(1, 101);
            _count = 0;            
        }

        public bool MakeGuess(int number)
        {
          if (_count < MaxNumberOfGuesses)
          {
            if (number < 1 | number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {            
                 if (number < _number)
                {
                   Console.Write("{0} är för lågt. Du har {1} försök på dig.", (1+ _count));
                }

                else
                {
                   Console.Write("{0} är för lågt. Du har {1} försök på dig.", (1+ _count));
                }  
          
                if (_count == 7)
                {

                }
                ++_count;
                return false;
           }
        }
         else
          {
              throw new ApplicationException();
          }

        }

    }
}
